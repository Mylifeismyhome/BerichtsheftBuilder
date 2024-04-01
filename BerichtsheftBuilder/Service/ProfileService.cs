using System;
using System.IO;
using System.Windows.Forms;
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

        public bool save()
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
                    stream.SetLength(0);
                    stream.Write(utf8, 0, utf8.Length);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool read()
        {
            if (!File.Exists(fileName))
            {
                return false;
            }

            try
            {
                using (FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
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
    }
}