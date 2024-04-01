using BerichtsheftBuilder.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerichtsheftBuilder.dto
{
    [Serializable]
    public class ProfileDto
    {
        protected ushort version;
        public ushort Version
        {
            get => version;
            set => version = value;
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
            set => sftp = value;
        }

        public ProfileDto()
        {
            version = 1;
            sftp = new SFTPDto();

            name = "";
            ausbilderName = "";
            ausbildungsstart = new DateTime();
            ausbildungsend = new DateTime();
            taskList = new List<TaskDto>();
        }

        protected void BinaryWriter(IFormatter formatter, Stream stream, object obj)
        {
            if (formatter == null || stream == null)
            {
                return;
            }

            formatter.Serialize(stream, obj);
        }

        protected object BinaryRead(IFormatter formatter, Stream stream)
        {
            if (formatter == null || stream == null)
            {
                return null;
            }

            return formatter.Deserialize(stream);
        }

        public void writeToStream(Stream stream)
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

        public void readFromStream(Stream stream)
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
    }
}
