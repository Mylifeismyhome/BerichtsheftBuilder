using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ABI.System;
using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.service;
using BerichtsheftBuilder.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BerichtsheftBuilder
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private SFTPService sftpService = Program.ServiceProvider.GetService<SFTPService>();

        private PDFService pdfService = Program.ServiceProvider.GetService<PDFService>();

        private CultureInfoService cultureInfoService = Program.ServiceProvider.GetService<CultureInfoService>();

        private DialogCenteringService dialogCenteringService = Program.ServiceProvider.GetService<DialogCenteringService>();

        private List<DateDto> dateDtoList;

        private List<TaskDto> taskList;

        public MainForm()
        {
            InitializeComponent();
            updateProfileStats();
            updateSftpStats();
            UpdateCalenderWeekComboBox();
            SetComboBoxToCurrentCalenderWeek();
        }

        private void updateProfileStats()
        {
            TB_Name.Text = profileService.Profile.Name;
            TB_AusbilderName.Text = profileService.Profile.AusbilderName;
            DTP_Ausbildungsstart.Value = profileService.Profile.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileService.Profile.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileService.Profile.Ausbildungsabteilung;
        }

        private void updateSftpStats()
        {
            CB_SFTP_IsEnabled.Checked = profileService.Profile.Sftp.IsEnabled;
            TB_SFTP_Host.Text = profileService.Profile.Sftp.Host;
            NUD_SFTP_Port.Value = profileService.Profile.Sftp.Port;
            TB_SFTP_Username.Text = profileService.Profile.Sftp.Username;

            BTN_SFTP_Pull.Enabled = profileService.Profile.Sftp.IsEnabled;
            BTN_SFTP_Pull.Cursor = BTN_SFTP_Pull.Enabled ? Cursors.Hand : Cursors.No;

            BTN_SFTP_Commit.Enabled = profileService.Profile.Sftp.IsEnabled;
            BTN_SFTP_Commit.Cursor = BTN_SFTP_Commit.Enabled ? Cursors.Hand : Cursors.No;

            if (profileService.Profile.Sftp.IsEnabled)
            {
                try
                {
                    DateTime lastPull = sftpService.getLastPull();
                    DateTime lastCommit = sftpService.getLastCommit();

                    LB_SFTP_LastPull.Text = $"Letzter Pull: {cultureInfoService.dateTimeFormat(lastPull)}";
                    LB_SFTP_LastCommit.Text = $"Letzter Commit: {cultureInfoService.dateTimeFormat(lastCommit)}";
                }
                catch (System.Exception ex)
                {
                    dialogCenteringService.nextOwner(this);
                    MessageBox.Show(ex.Message, "SFTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                LB_SFTP_LastPull.Text = "";
                LB_SFTP_LastCommit.Text = "";
            }
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

            DateTime tmpAusbildungsstart = DTP_Ausbildungsstart.Value;
            while (tmpAusbildungsstart.CompareTo(DTP_Ausbildungsende.Value) <= 0)
            {
                DateDto kalenderwoche = DateDto.GetCalendarWeek(tmpAusbildungsstart);
                dateDtoList.Add(kalenderwoche);
                tmpAusbildungsstart = tmpAusbildungsstart.AddDays(7);
            }

            CB_Kalenderwoche.Items.Clear();
            CB_Kalenderwoche.Items.AddRange(dateDtoList.Select(item => (object)item).ToArray());
        }

        private void updateTaskListView()
        {
            if (CB_Kalenderwoche.SelectedIndex > dateDtoList.Count - 1)
            {
                return;
            }

            DateDto calendarWeek = dateDtoList[CB_Kalenderwoche.SelectedIndex];
            taskList = profileService.Profile.TaskList.FindAll(it => it.Date.Match(calendarWeek));

            RTB_Task.Text = "";

            foreach (TaskDto task in taskList)
            {
                if (task.IsSchool)
                {
                    continue;
                }

                RTB_Task.Text += task.Desc + "\n";
            }

            RTB_SchoolTask.Text = "";

            foreach (TaskDto task in taskList)
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
                updateProfileStats();
                updateSftpStats();
                UpdateCalenderWeekComboBox();
                SetComboBoxToCurrentCalenderWeek();
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

            DateDto dateDto = dateDtoList[CB_Kalenderwoche.SelectedIndex];

            profileService.Profile.TaskList.RemoveAll(it => it.Date.Match(dateDto) && !it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                TaskDto taskDto = new TaskDto(dateDto, taskDesc, false);
                profileService.Profile.TaskList.Add(taskDto);
            }

            profileService.save();
        }

        private void RTB_SchoolTask_TextChanged(object sender, EventArgs e)
        {
            List<string> taskDescList = RTB_SchoolTask.Text.Split('\n').ToList();
            taskDescList.ForEach(it => it.Replace("\n", ""));
            taskDescList.RemoveAll(it => string.IsNullOrEmpty(it));

            DateDto dateDto = dateDtoList[CB_Kalenderwoche.SelectedIndex];

            profileService.Profile.TaskList.RemoveAll(it => it.Date.Match(dateDto) && it.IsSchool);

            foreach (string taskDesc in taskDescList)
            {
                TaskDto taskDto = new TaskDto(dateDto, taskDesc, true);
                profileService.Profile.TaskList.Add(taskDto);
            }

            profileService.save();
        }

        private void BTN_SFTP_Commit_Click(object sender, EventArgs e)
        {
            try
            {
                sftpService.commit();
            }
            catch(System.Exception ex)
            {
                dialogCenteringService.nextOwner(this);
                MessageBox.Show(ex.Message, "SFTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            updateSftpStats();
        }

        private void BTN_SFTP_Pull_Click(object sender, EventArgs e)
        {
            try
            {
                sftpService.pull();
            }
            catch(System.Exception ex)
            {
                dialogCenteringService.nextOwner(this);
                MessageBox.Show(ex.Message, "SFTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            updateProfileStats();
            updateSftpStats();
            UpdateCalenderWeekComboBox();
            SetComboBoxToCurrentCalenderWeek();
        }
    }
}
