using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    public class SFTPDto
    {
        private bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set => isEnabled = value;
        }

        private string host;
        public string Host
        {
            get => host;
            set => host = value;
        }

        private int port;
        public int Port
        {
            get => port;
            set => port = value;
        }

        private string username;
        public string Username
        {
            get => username;
            set => username = value;
        }

        private string password;
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
    }
}
