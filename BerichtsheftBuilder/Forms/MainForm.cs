using BerichtsheftBuilder.dto;
using BerichtsheftBuilder.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace BerichtsheftBuilder
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private ProfileStorage profileStorage = Program.ServiceProvider.GetService<ProfileStorage>();

        private List<DateUtils.CalendarWeek> calendarWeekList;

        private List<TaskDTO> calendarWeekTaskListView;

        public MainForm()
        {
            InitializeComponent();
            applyProfile();
        }

        private void applyProfile()
        {
            TB_Name.Text = profileStorage.Name;
            TB_AusbilderName.Text = profileStorage.AusbilderName;
            DTP_Ausbildungsstart.Value = profileStorage.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileStorage.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileStorage.Ausbildungsabteilung;

            UpdateCalenderWeekComboBox();
            SetComboBoxToCurrentCalenderWeek();
        }

        private void UpdateCalenderWeekComboBox()
        {
            if (calendarWeekList is null)
            {
                calendarWeekList = new List<DateUtils.CalendarWeek>();
            }
            else
            {
                calendarWeekList.Clear();
            }

            DateTime tmpAusbildungsstart = DTP_Ausbildungsstart.Value;
            while (tmpAusbildungsstart.CompareTo(DTP_Ausbildungsende.Value) <= 0)
            {
                DateUtils.CalendarWeek kalenderwoche = DateUtils.GetCalendarWeek(tmpAusbildungsstart);
                calendarWeekList.Add(kalenderwoche);
                tmpAusbildungsstart = tmpAusbildungsstart.AddDays(7);
            }

            CB_Kalenderwoche.Items.Clear();
            CB_Kalenderwoche.Items.AddRange(calendarWeekList.Select(item => (object)item).ToArray());
        }

        private void updateTaskListView()
        {
            if (CB_Kalenderwoche.SelectedIndex > calendarWeekList.Count - 1)
            {
                return;
            }

            DateUtils.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];
            calendarWeekTaskListView = profileStorage.TaskList.FindAll(it => it.CalendarWeek.Match(calendarWeek));

            RTB_Task.Text = "";

            foreach (TaskDTO task in calendarWeekTaskListView)
            {
                if(task.IsSchool)
                {
                    continue;
                }

                RTB_Task.Text += task.Desc + "\n";
            }

            RTB_SchoolTask.Text = "";

            foreach (TaskDTO task in calendarWeekTaskListView)
            {
                if (!task.IsSchool)
                {
                    continue;
                }

                RTB_SchoolTask.Text += task.Desc + "\n";
            }
        }

        private void SetComboBoxToCurrentCalenderWeek()
        {
            DateUtils.CalendarWeek currentCalenderWeek = DateUtils.GetCalendarWeek(DateTime.Today);
            foreach (object item in CB_Kalenderwoche.Items)
            {
                DateUtils.CalendarWeek calendarWeek = item as DateUtils.CalendarWeek;
                if (calendarWeek.Match(currentCalenderWeek))
                {
                    CB_Kalenderwoche.SelectedItem = item;
                    break;
                }
            }
        }

        private void CB_Kalenderwoche_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTaskListView();
        }

        private void BTN_Modify_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.applyProfile();
            profile.IsModifyMode = true;
            DialogResult result = profile.ShowDialog();
            if (result == DialogResult.OK)
            {
                applyProfile();
            }
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            PDFGen.generate("output.pdf", profileStorage);
        }

        private void RTB_Task_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_Task.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateUtils.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileStorage.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && !it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                TaskDTO taskDto = TaskDTO.valueOf(calendarWeek, taskDesc, false);
                profileStorage.TaskList.Add(taskDto);
            }

            profileStorage.Save();
        }

        private void RTB_SchoolTask_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_SchoolTask.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateUtils.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileStorage.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                TaskDTO taskDto = TaskDTO.valueOf(calendarWeek, taskDesc, true);
                profileStorage.TaskList.Add(taskDto);
            }

            profileStorage.Save();
        }
    }
}
