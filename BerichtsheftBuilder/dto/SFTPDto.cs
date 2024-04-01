using System;
using System.Text.Json.Serialization;

namespace BerichtsheftBuilder.Dto
{
    [Serializable()]
    public class SFTPDto
    {
        protected bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set => isEnabled = value;
        }

        protected string host;
        public string Host
        {
            get => host;
            set => host = value;
        }

        protected int port;
        public int Port
        {
            get => port;
            set => port = value;
        }

        protected string username;
        public string Username
        {
            get => username;
            set => username = value;
        }

        protected string password;
        public string Password
        {
            get => password;
            set => password = value;
        }

        public SFTPDto()
        {
            host = "localhost";
            port = 22;
            username = "";
            password = "";
        }

        [JsonConstructor]
        public SFTPDto(bool isEnabled, string host, int port, string username, string password)
        {
            this.isEnabled = isEnabled;
            this.host = host;
            this.port = port;
            this.username = username;
            this.password = password;
        }
    }
}
