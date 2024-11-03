using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.Form;
using BerichtsheftBuilder.service;
using BerichtsheftBuilder.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BerichtsheftBuilder.Forms
{
    public partial class ExportForm : System.Windows.Forms.Form
    {
        private ApplicationController applicationController = Program.ServiceProvider.GetService<ApplicationController>();

        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private PDFService pdfService = Program.ServiceProvider.GetService<PDFService>();

        private DialogCenteringService dialogCenteringService = Program.ServiceProvider.GetService<DialogCenteringService>();

        private List<DateDto> dateDtoList;

        public ExportForm()
        {
            InitializeComponent();
            UpdateCalenderWeekComboBox();
            SetComboBoxToCurrentCalenderWeek();
            TB_Export_Name.Text = profileService.Profile.ExportName;
        }

        private void UpdateCalenderWeekComboBox()
        {
            if (dateDtoList is null)
            {
                dateDtoList = new List<DateDto>();
            }
            else
            {
                dateDtoList.Clear();
            }

            DateTime tmpAusbildungsstart = profileService.Profile.Ausbildungsstart;
            while (tmpAusbildungsstart.CompareTo(profileService.Profile.Ausbildungsend) <= 0)
            {
                DateDto kalenderwoche = DateDto.GetCalendarWeek(tmpAusbildungsstart);
                dateDtoList.Add(kalenderwoche);
                tmpAusbildungsstart = tmpAusbildungsstart.AddDays(7);
            }

            CB_Kalenderwoche.Items.Clear();
            CB_Kalenderwoche.Items.AddRange(dateDtoList.Select(item => (object)item).ToArray());
        }

        private void SetComboBoxToCurrentCalenderWeek()
        {
            DateDto currentDateDto = DateDto.GetCalendarWeek(DateTime.Today);
            foreach (object item in CB_Kalenderwoche.Items)
            {
                DateDto dateDto = item as DateDto;
                if (dateDto.Match(currentDateDto))
                {
                    CB_Kalenderwoche.SelectedItem = item;
                    break;
                }
            }
        }

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            DateDto dateDto = CB_Kalenderwoche.SelectedItem as DateDto;

            string outputName = TB_Export_Name.Text;

            string name = profileService.Profile.Name;
            string abteilung = profileService.Profile.Ausbildungsabteilung;

            DateTime begin = profileService.Profile.Ausbildungsstart;
            DateTime end = dateDto.WeekEndDate;

            List<TaskDto> tasks = profileService.Profile.TaskList;

            pdfService.generate(outputName, name, abteilung, begin, end, tasks);

            profileService.Profile.ExportName = outputName;

            profileService.save();

            Dispose();
        }
    }
}
