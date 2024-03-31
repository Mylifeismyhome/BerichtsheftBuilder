using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerichtsheftBuilder.dto
{
    [Serializable]
    public class ProfileDto
    {
        protected ushort version;
        public ushort Version
        {
            get => version;
        }

        protected string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        protected string ausbilderName;
        public string AusbilderName
        {
            get => ausbilderName;
            set => ausbilderName = value;
        }

        protected DateTime ausbildungsstart;
        public DateTime Ausbildungsstart
        {
            get => ausbildungsstart;
            set => ausbildungsstart = value;
        }

        protected DateTime ausbildungsend;
        public DateTime Ausbildungsend
        {
            get => ausbildungsend;
            set => ausbildungsend = value;
        }

        protected string ausbildungsabteilung;
        public string Ausbildungsabteilung
        {
            get => ausbildungsabteilung;
            set => ausbildungsabteilung = value;
        }

        protected List<TaskDto> taskList;
        public List<TaskDto> TaskList
        {
            get => taskList;
            set => taskList = value;
        }

        protected SFTPDto sftp;
        public SFTPDto Sftp
        {
            get => sftp;
        }
    }
}
