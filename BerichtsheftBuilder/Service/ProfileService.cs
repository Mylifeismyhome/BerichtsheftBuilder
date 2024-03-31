using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using BerichtsheftBuilder.dto;
using System.Collections.Generic;
using Renci.SshNet;
using System.Linq;

namespace BerichtsheftBuilder.service
{
    public class ProfileService : ProfileDto
    {
        public delegate void OnReadDelegate();
        private OnReadDelegate onRead;
        public OnReadDelegate OnRead
        {
            get => onRead;
            set => onRead = value;
        }

        public ProfileService()
        {
            version = 1;
            sftp = new SFTPDto();

            name = "";
            ausbilderName = "";
            ausbildungsstart = new DateTime();
            ausbildungsend = new DateTime();
            taskList = new List<TaskDto>();

            onRead = new OnReadDelegate(() => { });
        }

        private void BinaryWriter(IFormatter formatter, Stream stream, object obj)
        {
            if (formatter == null || stream == null)
            {
                return;
            }

            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object BinaryRead(IFormatter formatter, Stream stream)
        {
            if (formatter == null || stream == null)
            {
                return null;
            }

            try
            {
                return formatter.Deserialize(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void writeToStream(Stream stream)
        {
            IFormatter formatter = new BinaryFormatter();

            BinaryWriter(formatter, stream, version);
            BinaryWriter(formatter, stream, sftp);

            BinaryWriter(formatter, stream, name);
            BinaryWriter(formatter, stream, ausbilderName);
            BinaryWriter(formatter, stream, ausbildungsstart);
            BinaryWriter(formatter, stream, ausbildungsend);
            BinaryWriter(formatter, stream, ausbildungsabteilung);
            BinaryWriter(formatter, stream, taskList);
        }

        private void readFromStream(Stream stream)
        {
            IFormatter formatter = new BinaryFormatter();

            version = (ushort)BinaryRead(formatter, stream);
            sftp = (SFTPDto)BinaryRead(formatter, stream);

            name = (string)BinaryRead(formatter, stream);
            ausbilderName = (string)BinaryRead(formatter, stream);
            ausbildungsstart = (DateTime)BinaryRead(formatter, stream);
            ausbildungsend = (DateTime)BinaryRead(formatter, stream);
            ausbildungsabteilung = (string)BinaryRead(formatter, stream);
            taskList = (List<TaskDto>)BinaryRead(formatter, stream);
        }

        public bool Save()
        {
            try
            {
                using (FileStream stream = File.Open("profile.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    if (stream == null || !stream.CanWrite)
                    {
                        return false;
                    }

                    writeToStream(stream);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                using (FileStream stream = File.Open("profile.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    if (stream == null || !stream.CanRead || stream.Length == 0)
                    {
                        return false;
                    }

                    IFormatter formatter = new BinaryFormatter();
                    readFromStream(stream);
                    onRead.Invoke();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void SFTPSync()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                SftpClient client = new SftpClient(sftp.Host, sftp.Port, sftp.Username, sftp.Password);

                try
                {
                    client.Connect();

                    if (!client.IsConnected)
                    {
                        throw new Exception("Not connected to SFTP server");
                    }

                    bool fileExists = client.Exists("profile.bin");

                    if (!fileExists)
                    {
                        writeToStream(memoryStream);
                        client.WriteAllBytes("profile.bin", memoryStream.ToArray());
                        return;
                    }

                    byte[] data = client.ReadAllBytes("profile.bin");
                    memoryStream.Write(data, 0, data.Length);
                    memoryStream.Position = 0;

                    ProfileService tempProfileStorage = new ProfileService();
                    tempProfileStorage.readFromStream(memoryStream);

                    if (version != tempProfileStorage.version)
                    {
                        throw new Exception("Version mismatch");
                    }

                    name = tempProfileStorage.name;
                    ausbilderName = tempProfileStorage.ausbilderName;
                    ausbildungsstart = tempProfileStorage.ausbildungsstart;
                    ausbildungsend = tempProfileStorage.ausbildungsend;
                    ausbildungsabteilung = tempProfileStorage.ausbildungsabteilung;
                    taskList = taskList.Union(tempProfileStorage.taskList).ToList();

                    memoryStream.Flush();
                    memoryStream.Position = 0;

                    writeToStream(memoryStream);

                    client.WriteAllBytes("profile.bin", memoryStream.ToArray());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "SFTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    client?.Disconnect();
                    client?.Dispose();
                    memoryStream.Close();
                }
            }
        }
    }
}
