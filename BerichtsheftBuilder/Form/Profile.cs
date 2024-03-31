using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerichtsheftBuilder.Forms
{
    public partial class Profile : System.Windows.Forms.Form
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private bool isModifyMode;
        public bool IsModifyMode
        {
            get => isModifyMode;
            set => isModifyMode = value;
        }

        public Profile()
        {
            InitializeComponent();
            IsEnabledChanged();
            isModifyMode = false;
        }

        private void switchToMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Location = Location;
            mainForm.Show();
            Hide();
        }

        public void applyProfile()
        {
            TB_AuszubildenderName.Text = profileService.Name;
            TB_AusbilderName.Text = profileService.AusbilderName;
            DTP_Ausbildungsstart.Value = profileService.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileService.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileService.Ausbildungsabteilung;

            CB_IsEnabled.Checked = profileService.Sftp.IsEnabled;
            TB_Host.Text = profileService.Sftp.Host;
            NUD_Port.Value = profileService.Sftp.Port;
            TB_Username.Text = profileService.Sftp.Username;
            TB_Password.Text = profileService.Sftp.Password;
        }

        private void IsEnabledChanged()
        {
            TB_Host.Enabled = CB_IsEnabled.Checked;
            NUD_Port.Enabled = CB_IsEnabled.Checked;
            TB_Username.Enabled = CB_IsEnabled.Checked;
            TB_Password.Enabled = CB_IsEnabled.Checked;
        }

        private void CB_IsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabledChanged();
        }

        private void BTN_Apply_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
            {
                result = MessageBox.Show(this, "Alle Eingaben korrekt?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (result == DialogResult.No)
            {
                return;
            }

            profileService.Name = TB_AuszubildenderName.Text;
            profileService.AusbilderName = TB_AusbilderName.Text;
            profileService.Ausbildungsstart = DTP_Ausbildungsstart.Value;
            profileService.Ausbildungsend = DTP_Ausbildungsende.Value;
            profileService.Ausbildungsabteilung = TB_Ausbildungsabteilung.Text;

            profileService.Sftp.IsEnabled = CB_IsEnabled.Checked;
            profileService.Sftp.Host = TB_Host.Text;
            profileService.Sftp.Port = Convert.ToInt32(NUD_Port.Value);
            profileService.Sftp.Username = TB_Username.Text;
            profileService.Sftp.Password = TB_Password.Text;

            if (!profileService.Save())
            {
                return;
            }

            if (isModifyMode)
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
            else
            {
                switchToMainForm();
            }
        }
    }
}
