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
        private string host;
        public string Host
        {
            get => host;
        }

        private ushort port;
        public ushort Port
        {
            get => port;
        }

        private string username;
        public string Username
        {
            get => username;
        }

        private string password;
        public string Password
        {
            get => password;
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
