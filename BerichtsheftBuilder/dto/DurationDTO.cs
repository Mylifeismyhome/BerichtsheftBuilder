using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    public class DurationDTO
    {
        private int hour;
        public int Hour
        {
            get => hour;
        }

        private int minute;
        public int Minute
        {
            get => hour;
        }

        public bool valid()
        {
            if(hour == 0 && minute == 0)
            {
                return false;
            }

            if(hour > 24 || hour < 0)
            {
                return false;
            }

            if(minute > 60 || minute < 0)
            {
                return false;
            }

            return true;
        }

        protected DurationDTO()
        {
            hour = 0;
            minute = 0;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", hour, minute);
        }

        public static DurationDTO valueOf(int hour, int minute)
        {
            DurationDTO dto = new DurationDTO();
            dto.hour = hour;
            dto.minute = minute;
            return dto;
        }
    }
}
