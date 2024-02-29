using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    internal class TaskDTO 
    {
        private DateUtils.CalendarWeek calendarWeek;
        public DateUtils.CalendarWeek CalendarWeek
        {
            get => calendarWeek;
        }

        private string job;
        public string Job
        {
            get => job;
        }

        private DurationDTO duration;
        public DurationDTO Duration
        {
            get => duration;
        }

        protected TaskDTO()
        {
            calendarWeek = null;
            job = "";
            duration = DurationDTO.valueOf(0, 0);
        }

        public static TaskDTO valueOf(DateUtils.CalendarWeek calendarWeek, string job, DurationDTO duration)
        {
            TaskDTO dto = new TaskDTO();
            dto.calendarWeek = calendarWeek;
            dto.job = job;
            dto.duration = duration;
            return dto;
        }
    }
}
