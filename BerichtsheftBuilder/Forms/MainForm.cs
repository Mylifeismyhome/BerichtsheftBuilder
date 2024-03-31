using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;

namespace BerichtsheftBuilder
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private List<DateUtils.CalendarWeek> calendarWeekList;

        private List<dto.TaskDto> calendarWeekTaskListView;

        public MainForm()
        {
            InitializeComponent();
            applyProfile();
        }

        private void applyProfile()
        {
            TB_Name.Text = profileService.Name;
            TB_AusbilderName.Text = profileService.AusbilderName;
            DTP_Ausbildungsstart.Value = profileService.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileService.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileService.Ausbildungsabteilung;

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
            calendarWeekTaskListView = profileService.TaskList.FindAll(it => it.CalendarWeek.Match(calendarWeek));

            RTB_Task.Text = "";

            foreach (dto.TaskDto task in calendarWeekTaskListView)
            {
                if(task.IsSchool)
                {
                    continue;
                }

                RTB_Task.Text += task.Desc + "\n";
            }

            RTB_SchoolTask.Text = "";

            foreach (dto.TaskDto task in calendarWeekTaskListView)
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
            Forms.Profile profile = new Forms.Profile();
            profile.applyProfile();
            profile.IsModifyMode = true;
            profile.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = profile.ShowDialog();
            if (result == DialogResult.OK)
            {
                applyProfile();
            }
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            PDFGen.generate("output.pdf", profileService);
        }

        private void RTB_Task_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_Task.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateUtils.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileService.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && !it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                dto.TaskDto taskDto = dto.TaskDto.valueOf(calendarWeek, taskDesc, false);
                profileService.TaskList.Add(taskDto);
            }

            profileService.Save();
        }

        private void RTB_SchoolTask_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_SchoolTask.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateUtils.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileService.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                dto.TaskDto taskDto = dto.TaskDto.valueOf(calendarWeek, taskDesc, true);
                profileService.TaskList.Add(taskDto);
            }

            profileService.Save();
        }
    }
}
