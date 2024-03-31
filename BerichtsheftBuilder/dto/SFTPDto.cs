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
    }
}
