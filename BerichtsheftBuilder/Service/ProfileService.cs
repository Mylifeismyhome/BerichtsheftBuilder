using System;
using System.IO;
using System.Windows.Forms;
using Renci.SshNet;
using System.Text;
using BerichtsheftBuilder.Dto;

namespace BerichtsheftBuilder.service
{
    public class ProfileService
    {
        private string fileName;
        public string FileName
        {
            get => fileName;
        }

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
            fileName = "profile.json";
            profile = new ProfileDto();
            onRead = new OnReadDelegate(() => { });
        }

        public bool Save()
        {
            try
            {
                using (FileStream stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    if (stream == null || !stream.CanWrite)
                    {
                        return false;
                    }

                    byte[] utf8 = profile.serializeUtf8();
                    stream.Write(utf8, 0, utf8.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return SFTPSync();
        }

        public bool Read()
        {
            try
            {
                using (FileStream stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    if (stream == null || !stream.CanRead || stream.Length == 0)
                    {
                        return false;
                    }

                    byte[] data = new byte[stream.Length];
                    stream.Read(data, 0, data.Length);

                    string utf8 = Encoding.UTF8.GetString(data, 0, data.Length);
                    profile.deserializeUtf8(utf8);

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

        public bool SFTPSync()
        {
            if(!profile.Sftp.IsEnabled)
            {
                return true;
            }

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

                    bool fileExists = client.Exists(fileName);

                    if (!fileExists)
                    {
                        byte[] utf8 = profile.serializeUtf8();
                        client.WriteAllBytes(fileName, utf8);
                        return true;
                    }

                    //byte[] data = client.ReadAllBytes("profile.bin");
                    //memoryStream.Write(data, 0, data.Length);
                    //memoryStream.Position = 0;

                    //ProfileDto tempProfile = new ProfileDto();
                    //tempProfile.readFromStream(memoryStream);

                    //if (profile.Version != tempProfile.Version)
                    //{
                    //    throw new Exception("Version mismatch");
                    //}

                    //profile.Name = tempProfile.Name;
                    //profile.AusbilderName = tempProfile.AusbilderName;
                    //profile.Ausbildungsstart = tempProfile.Ausbildungsstart;
                    //profile.Ausbildungsend = tempProfile.Ausbildungsend;
                    //profile.Ausbildungsabteilung = tempProfile.Ausbildungsabteilung;
                    //profile.TaskList = profile.TaskList.Union(tempProfile.TaskList).ToList();

                    //memoryStream.Flush();
                    //memoryStream.Position = 0;

                    //profile.writeToStream(memoryStream);

                    //client.WriteAllBytes("profile.bin", memoryStream.ToArray());
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

            return false;
        }
    }
}
