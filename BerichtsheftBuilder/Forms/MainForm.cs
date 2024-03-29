using BerichtsheftBuilder.dto;
using BerichtsheftBuilder.Form;
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

            LV_Task.Items.Clear();

            foreach (TaskDTO task in calendarWeekTaskListView)
            {
                ListViewItem item = new ListViewItem();
                item.Text = task.Job;
                item.SubItems.Add(task.Duration.ToString());
                LV_Task.Items.Add(item);
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

        private void LV_Task_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();

            if (CB_Kalenderwoche.SelectedIndex > calendarWeekList.Count - 1)
            {
                return;
            }

            addTaskForm.CalendarWeek = calendarWeekList[CB_Kalenderwoche.SelectedIndex];

            DialogResult result = addTaskForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateTaskListView();
            }
        }

        private void CB_Kalenderwoche_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTaskListView();
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Diese Aktion wird [{0}] Elemente löschen. Sind Sie sicher?", LV_Task.SelectedIndices.Count), "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes)
            {
                return;
            }

            int countDeleted = 0;
            foreach (int selectedIndex in LV_Task.SelectedIndices)
            {
                TaskDTO dto = calendarWeekTaskListView[selectedIndex];
                if (!profileStorage.removeTask(dto))
                {
                    //MessageBox.Show("Es gab ein Problem beim Entfernen der Elemente. Bitte versuchen Sie es erneut.");
                    continue;
                }

                ++countDeleted;
            }

            //MessageBox.Show(string.Format("Die Anzahl von [{0}] Element(en) wurde(n) erfolgreich entfernt.", countDeleted), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
