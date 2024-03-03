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
            applyProfile();
            isModifyMode = false;
        }

        private void applyProfile()
        {
            TB_AuszubildenderName.Text = profileStorage.Name;
            TB_AusbilderName.Text = profileStorage.AusbilderName;
            DTP_Ausbildungsstart.Value = profileStorage.Ausbildungsstart;
            DTP_Ausbildungsende.Value = profileStorage.Ausbildungsend;
            TB_Ausbildungsabteilung.Text = profileStorage.Ausbildungsabteilung;
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

            profileStorage.Created = true;
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
    }
}
