using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BerichtsheftBuilder.Dto
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

        protected string exportName;
        public string ExportName
        {
            get => exportName;
            set => exportName = value;
        }

        public ProfileDto()
        {
            version = 1;
            sftp = new SFTPDto();

            name = "";
            ausbilderName = "";
            ausbildungsstart = new DateTime();
            ausbildungsend = new DateTime();
            ausbildungsabteilung = "";
            taskList = new List<TaskDto>();

            exportName = "output.pdf";
        }

        [JsonConstructor]
        public ProfileDto(ushort version, string name, string ausbilderName, DateTime ausbildungsstart, DateTime ausbildungsend, string ausbildungsabteilung, List<TaskDto> taskList, string exportName = "output.pdf")
        {
            this.version = version;
            this.name = name;
            this.ausbilderName = ausbilderName;
            this.ausbildungsstart = ausbildungsstart;
            this.ausbildungsend = ausbildungsend;
            this.ausbildungsabteilung = ausbildungsabteilung;
            this.taskList = taskList;
            this.exportName = exportName;
        }

        public byte[] serializeUtf8()
        {
            return JsonSerializer.SerializeToUtf8Bytes(this);
        }

        public void deserializeUtf8(string utf8)
        {
            ProfileDto? profile = JsonSerializer.Deserialize<ProfileDto>(utf8);

            if (profile == null)
            {
                throw new Exception("unable to deserialize profile");
            }

            if (version != profile.version)
            {
                throw new Exception("version mismatch");
            }

            sftp = profile.sftp;
            name = profile.name;
            ausbilderName = profile.ausbilderName;
            ausbildungsstart = profile.ausbildungsstart;
            Ausbildungsend = profile.ausbildungsend;
            ausbildungsabteilung = profile.ausbildungsabteilung;
            taskList = profile.taskList;
            exportName = profile.exportName;
        }
    }
}