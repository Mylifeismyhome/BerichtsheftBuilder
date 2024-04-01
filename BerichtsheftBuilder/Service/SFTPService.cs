using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;
using Renci.SshNet;
using System;
using System.IO;
using System.Text;

namespace BerichtsheftBuilder.Service
{
    public class SFTPService
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        public void pull()
        {
            if (!profileService.Profile.Sftp.IsEnabled)
            {
                throw new System.Exception("SFTP is not enabled");
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                SftpClient client = new SftpClient(profileService.Profile.Sftp.Host, profileService.Profile.Sftp.Port, profileService.Profile.Sftp.Username, profileService.Profile.Sftp.Password);
                try
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        throw new System.Exception("Not connected to SFTP server");
                    }

                    if (!client.Exists(profileService.FileName))
                    {
                        throw new System.Exception($"{profileService.FileName} does not exists");
                    }

                    byte[] data = client.ReadAllBytes(profileService.FileName);
                    string utf8 = Encoding.UTF8.GetString(data);

                    ProfileDto tempProfile = new ProfileDto();
                    tempProfile.deserializeUtf8(utf8);

                    profileService.Profile.Name = tempProfile.Name;
                    profileService.Profile.AusbilderName = tempProfile.AusbilderName;
                    profileService.Profile.Ausbildungsstart = tempProfile.Ausbildungsstart;
                    profileService.Profile.Ausbildungsend = tempProfile.Ausbildungsend;
                    profileService.Profile.Ausbildungsabteilung = tempProfile.Ausbildungsabteilung;
                    profileService.Profile.TaskList = tempProfile.TaskList;
                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    client?.Disconnect();
                    client?.Dispose();
                    memoryStream.Close();
                }
            }
        }

        public void commit()
        {
            if (!profileService.Profile.Sftp.IsEnabled)
            {
                throw new System.Exception("SFTP is not enabled");
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                SftpClient client = new SftpClient(profileService.Profile.Sftp.Host, profileService.Profile.Sftp.Port, profileService.Profile.Sftp.Username, profileService.Profile.Sftp.Password);
                try
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        throw new System.Exception("Not connected to SFTP server");
                    }

                    byte[] utf8 = profileService.Profile.serializeUtf8();

                    var fileStream = client.Open(profileService.FileName, FileMode.OpenOrCreate | FileMode.Truncate);
                    fileStream.Write(utf8, 0, utf8.Length);
                    fileStream.Close();
                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    client?.Disconnect();
                    client?.Dispose();
                    memoryStream.Close();
                }
            }
        }

        public DateTime getLastPull()
        {
            if (!profileService.Profile.Sftp.IsEnabled)
            {
                throw new System.Exception("SFTP is not enabled");
            }

            DateTime lastPull = DateTime.UnixEpoch;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                SftpClient client = new SftpClient(profileService.Profile.Sftp.Host, profileService.Profile.Sftp.Port, profileService.Profile.Sftp.Username, profileService.Profile.Sftp.Password);
                try
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        throw new System.Exception("Not connected to SFTP server");
                    }

                    if (client.Exists(profileService.FileName))
                    {
                        lastPull = client.GetLastAccessTime(profileService.FileName);
                    }
                    else
                    {
                        throw new System.Exception($"{profileService.FileName} does not exists");
                    }
                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    client?.Disconnect();
                    client?.Dispose();
                    memoryStream.Close();
                }
            }

            return lastPull;
        }

        public DateTime getLastCommit()
        {
            if (!profileService.Profile.Sftp.IsEnabled)
            {
                throw new System.Exception("SFTP is not enabled");
            }

            DateTime lastCommit = DateTime.UnixEpoch;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                SftpClient client = new SftpClient(profileService.Profile.Sftp.Host, profileService.Profile.Sftp.Port, profileService.Profile.Sftp.Username, profileService.Profile.Sftp.Password);
                try
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        throw new System.Exception("Not connected to SFTP server");
                    }

                    if (client.Exists(profileService.FileName))
                    {
                        lastCommit = client.GetLastWriteTime(profileService.FileName);
                    }
                    else
                    {
                        throw new System.Exception($"{profileService.FileName} does not exists");
                    }
                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }
                finally
                {
                    client?.Disconnect();
                    client?.Dispose();
                    memoryStream.Close();
                }
            }

            return lastCommit;
        }
    }
}
