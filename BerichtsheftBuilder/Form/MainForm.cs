using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.service;
using BerichtsheftBuilder.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BerichtsheftBuilder
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private PDFService pdfService = Program.ServiceProvider.GetService<PDFService>();

        private List<DateDto.CalendarWeek> calendarWeekList;

        private List<dto.TaskDto> calendarWeekTaskListView;

        public MainForm()
        {
            InitializeComponent();
            applyProfile();
        }

        private void applyProfile()
        {
            TB_Name.Text = profileService.Profile.Name;
            TB_AusbilderName.Text = profileService.Profile.AusbilderName;
            DTP_Ausbildungsstart.Value = profileService.Profile.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileService.Profile.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileService.Profile.Ausbildungsabteilung;

            UpdateCalenderWeekComboBox();
            SetComboBoxToCurrentCalenderWeek();
        }

        private void UpdateCalenderWeekComboBox()
        {
            if (calendarWeekList is null)
            {
                calendarWeekList = new List<DateDto.CalendarWeek>();
            }
            else
            {
                calendarWeekList.Clear();
            }

            DateTime tmpAusbildungsstart = DTP_Ausbildungsstart.Value;
            while (tmpAusbildungsstart.CompareTo(DTP_Ausbildungsende.Value) <= 0)
            {
                DateDto.CalendarWeek kalenderwoche = DateDto.GetCalendarWeek(tmpAusbildungsstart);
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

            DateDto.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];
            calendarWeekTaskListView = profileService.Profile.TaskList.FindAll(it => it.CalendarWeek.Match(calendarWeek));

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
            DateDto.CalendarWeek currentCalenderWeek = DateDto.GetCalendarWeek(DateTime.Today);
            foreach (object item in CB_Kalenderwoche.Items)
            {
                DateDto.CalendarWeek calendarWeek = item as DateDto.CalendarWeek;
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
            pdfService.generate("output.pdf");
        }

        private void RTB_Task_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_Task.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateDto.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileService.Profile.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && !it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                dto.TaskDto taskDto = dto.TaskDto.valueOf(calendarWeek, taskDesc, false);
                profileService.Profile.TaskList.Add(taskDto);
            }

            profileService.Save();
        }

        private void RTB_SchoolTask_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_SchoolTask.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateDto.CalendarWeek calendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            profileService.Profile.TaskList.RemoveAll(it => it.CalendarWeek.Match(calendarWeek) && it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                dto.TaskDto taskDto = dto.TaskDto.valueOf(calendarWeek, taskDesc, true);
                profileService.Profile.TaskList.Add(taskDto);
            }

            profileService.Save();
        }
    }
}
