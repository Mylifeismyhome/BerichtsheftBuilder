using BerichtsheftBuilder.Form;
using BerichtsheftBuilder.service;
using BerichtsheftBuilder.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

namespace BerichtsheftBuilder.Forms
{
    public partial class Profile : System.Windows.Forms.Form
    {
        private ApplicationController applicationController = Program.ServiceProvider.GetService<ApplicationController>();

        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        private SFTPService sftpService = Program.ServiceProvider.GetService<SFTPService>();

        private DialogCenteringService dialogCenteringService = Program.ServiceProvider.GetService<DialogCenteringService>();

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
            TB_AuszubildenderName.Text = profileService.Profile.Name;
            TB_AusbilderName.Text = profileService.Profile.AusbilderName;
            DTP_Ausbildungsstart.Value = profileService.Profile.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileService.Profile.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileService.Profile.Ausbildungsabteilung;

            CB_IsEnabled.Checked = profileService.Profile.Sftp.IsEnabled;
            TB_Host.Text = profileService.Profile.Sftp.Host;
            NUD_Port.Value = profileService.Profile.Sftp.Port;
            TB_Username.Text = profileService.Profile.Sftp.Username;
            TB_Password.Text = profileService.Profile.Sftp.Password;
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
            dialogCenteringService.nextOwner(this);
            DialogResult result = MessageBox.Show(this, "Alle Eingaben korrekt?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            profileService.Profile.Name = TB_AuszubildenderName.Text;
            profileService.Profile.AusbilderName = TB_AusbilderName.Text;
            profileService.Profile.Ausbildungsstart = DTP_Ausbildungsstart.Value;
            profileService.Profile.Ausbildungsend = DTP_Ausbildungsende.Value;
            profileService.Profile.Ausbildungsabteilung = TB_Ausbildungsabteilung.Text;

            profileService.Profile.Sftp.IsEnabled = CB_IsEnabled.Checked;
            profileService.Profile.Sftp.Host = TB_Host.Text;
            profileService.Profile.Sftp.Port = Convert.ToInt32(NUD_Port.Value);
            profileService.Profile.Sftp.Username = TB_Username.Text;
            profileService.Profile.Sftp.Password = TB_Password.Text;

            if (!File.Exists(profileService.FileName))
            {
                if (profileService.Profile.Sftp.IsEnabled)
                {
                    try
                    {
                        sftpService.pull();
                    }
                    catch (System.Exception ex)
                    {
                        dialogCenteringService.nextOwner(this);
                        MessageBox.Show(ex.Message, "SFTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (!profileService.save())
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
                applicationController.switchForm(new MainForm());
            }
        }
    }
}
