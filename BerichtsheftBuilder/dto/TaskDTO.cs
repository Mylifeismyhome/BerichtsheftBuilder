using System;
using System.Text.Json.Serialization;

namespace BerichtsheftBuilder.Dto
{
    [Serializable()]
    public class TaskDto
    {
        protected DateDto date;
        public DateDto Date
        {
            get => date;
        }

        protected string desc;
        public string Desc
        {
            get => desc;
        }

        protected bool isSchool;
        public bool IsSchool
        {
            get => isSchool;
        }

        [JsonConstructor]
        public TaskDto(DateDto date, string desc, bool isSchool)
        {
            this.date = date;
            this.desc = desc;
            this.isSchool = isSchool;
        }
    }
}