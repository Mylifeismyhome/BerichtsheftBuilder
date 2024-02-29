
using BerichtsheftBuilder.dto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BerichtsheftBuilder.Form
{
    public partial class AddTaskForm : System.Windows.Forms.Form
    {
        private ProfileStorage profileStorage = Program.ServiceProvider.GetService<ProfileStorage>();

        private DateUtils.CalendarWeek calendarWeek;

        public DateUtils.CalendarWeek CalendarWeek
        {
            get => calendarWeek;
            set => calendarWeek = value;
        }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, System.EventArgs e)
        {
            DurationDTO duration = null;

            try
            {
                int hour = Convert.ToInt32(ND_HOUR.Value);
                int minute = Convert.ToInt32(ND_MINUTE.Value);
                duration = DurationDTO.valueOf(hour, minute);
            }
            catch (OverflowException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            if(!profileStorage.addTask(CalendarWeek, RTB_Description.Text, duration))
            {
                MessageBox.Show("Bitte überprüfe die Eingaben.");
                return;
            }

            profileStorage.Save();

            Dispose();
        }
    }
}
