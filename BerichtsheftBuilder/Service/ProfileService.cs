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
    public class ProfileService
    {
        private ProfileDto profile;
        public ProfileDto Profile
        {
            get => profile;
        }

        public delegate void OnReadDelegate();
        private OnReadDelegate onRead;
        public OnReadDelegate OnRead
        {
            get => onRead;
            set => onRead = value;
        }

        public ProfileService()
        {
            profile = new ProfileDto();
            onRead = new OnReadDelegate(() => { });
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

                    profile.writeToStream(stream);

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
                    profile.readFromStream(stream);
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
                SftpClient client = new SftpClient(profile.Sftp.Host, profile.Sftp.Port, profile.Sftp.Username, profile.Sftp.Password);

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
                        profile.writeToStream(memoryStream);
                        client.WriteAllBytes("profile.bin", memoryStream.ToArray());
                        return;
                    }

                    byte[] data = client.ReadAllBytes("profile.bin");
                    memoryStream.Write(data, 0, data.Length);
                    memoryStream.Position = 0;

                    ProfileDto tempProfile = new ProfileDto();
                    tempProfile.readFromStream(memoryStream);

                    if (profile.Version != tempProfile.Version)
                    {
                        throw new Exception("Version mismatch");
                    }

                    profile.Name = tempProfile.Name;
                    profile.AusbilderName = tempProfile.AusbilderName;
                    profile.Ausbildungsstart = tempProfile.Ausbildungsstart;
                    profile.Ausbildungsend = tempProfile.Ausbildungsend;
                    profile.Ausbildungsabteilung = tempProfile.Ausbildungsabteilung;
                    profile.TaskList = profile.TaskList.Union(tempProfile.TaskList).ToList();

                    memoryStream.Flush();
                    memoryStream.Position = 0;

                    profile.writeToStream(memoryStream);

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
