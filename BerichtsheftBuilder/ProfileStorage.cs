using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using BerichtsheftBuilder.dto;
using System.Collections.Generic;

namespace BerichtsheftBuilder
{
    internal class ProfileStorage
    {
        private DateTime ausbildungsstart;
        public DateTime Ausbildungsstart
        {
            get => ausbildungsstart;
            set => ausbildungsstart = value;
        }

        private DateTime ausbildungsend;
        public DateTime Ausbildungsend
        {
            get => ausbildungsend;
            set => ausbildungsend = value;
        }

        private List<TaskDTO> taskList;
        public List<TaskDTO> TaskList
        {
            get => taskList;
            set => taskList = value;
        }

        public delegate void OnReadDelegate();
        private OnReadDelegate onRead;
        public OnReadDelegate OnRead
        {
            get => onRead;
            set => onRead = value;
        }

        public ProfileStorage()
        {
            ausbildungsstart = new DateTime();
            ausbildungsend = new DateTime();
            taskList = new List<TaskDTO>();
            onRead = new OnReadDelegate(() => { });
        }

        private void BinaryWriter(IFormatter formatter, FileStream stream, object obj)
        {
            if (formatter == null || stream == null)
            {
                return;
            }

            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object BinaryRead(IFormatter formatter, FileStream stream)
        {
            if (formatter == null || stream == null)
            {
                return null;
            }

            return formatter.Deserialize(stream);
        }

        public bool Save()
        {
            try
            {
                FileStream stream = File.Open("profile.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                if (stream == null)
                {
                    return false;
                }

                if(!stream.CanWrite)
                {
                    stream.Close();
                    return false;
                }

                IFormatter formatter = new BinaryFormatter();

                BinaryWriter(formatter, stream, ausbildungsstart);
                BinaryWriter(formatter, stream, ausbildungsend);
                BinaryWriter(formatter, stream, taskList);

                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool Read()
        {
            try
            {
                FileStream stream = File.Open("profile.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                if (stream == null)
                {
                    return false;
                }

                if(!stream.CanRead)
                {
                    stream.Close();
                    return false;
                }

                if(stream.Length == 0)
                {
                    stream.Close();
                    return false;
                }

                IFormatter formatter = new BinaryFormatter();

                ausbildungsstart = (DateTime)BinaryRead(formatter, stream);
                ausbildungsend = (DateTime)BinaryRead(formatter, stream);
                taskList = (List<TaskDTO>)BinaryRead(formatter, stream);

                stream.Close();
                onRead.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public bool addTask(DateUtils.CalendarWeek calendarWeek, string job, DurationDTO duration)
        {
            if(!duration.valid())
            {
                return false;
            }

            TaskDTO dto = TaskDTO.valueOf(calendarWeek, job, duration);
            taskList.Add(dto);

            return true;
        }

        public bool removeTask(TaskDTO dto)
        {
            return taskList.Remove(dto);
        }
    }
}
