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

        protected float duration;
        public float Duration
        {
            get => duration;
        }

        public String formattedDuration
        {
            get
            {
                int hours = (int)duration;
                int minutes = (int)Math.Ceiling((duration - hours) * 100);
                return $"{hours}:{minutes:D2}h";
            }
        }

        [JsonConstructor]
        public TaskDto(DateDto date, string desc, bool isSchool, float duration = 0.0f)
        {
            this.date = date;
            this.desc = desc;
            this.isSchool = isSchool;
            this.duration = duration;
        }
    }
}