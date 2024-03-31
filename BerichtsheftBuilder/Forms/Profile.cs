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
        private ProfileStorage profileStorage = Program.ServiceProvider.GetService<ProfileStorage>();

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

        public void applyProfile()
        {
            TB_AuszubildenderName.Text = profileStorage.Name;
            TB_AusbilderName.Text = profileStorage.AusbilderName;
            DTP_Ausbildungsstart.Value = profileStorage.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileStorage.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileStorage.Ausbildungsabteilung;

            CB_IsEnabled.Checked = profileStorage.Sftp.IsEnabled;
            TB_Host.Text = profileStorage.Sftp.Host;
            NUD_Port.Value = profileStorage.Sftp.Port;
            TB_Username.Text = profileStorage.Sftp.Username;
            TB_Password.Text = profileStorage.Sftp.Password;
        }

        private void switchToMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Location = Location;
            mainForm.Show();
            Hide();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sind alle Daten korrekt?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            profileStorage.Name = TB_AuszubildenderName.Text;
            profileStorage.AusbilderName = TB_AusbilderName.Text;
            profileStorage.Ausbildungsstart = DTP_Ausbildungsstart.Value;
            profileStorage.Ausbildungsend = DTP_Ausbildungsende.Value;
            profileStorage.Ausbildungsabteilung = TB_Ausbildungsabteilung.Text;

            if (!profileStorage.Save())
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

        private void BTN_Sync_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sind alle Daten korrekt?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            profileStorage.Sftp.IsEnabled = CB_IsEnabled.Checked;
            profileStorage.Sftp.Host = TB_Host.Text;
            profileStorage.Sftp.Port = Convert.ToInt32(NUD_Port.Value);
            profileStorage.Sftp.Username = TB_Username.Text;
            profileStorage.Sftp.Password = TB_Password.Text;

            if (!profileStorage.Save())
            {
                return;
            }

            profileStorage.SFTPSync();

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
