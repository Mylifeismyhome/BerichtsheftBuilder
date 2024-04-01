namespace BerichtsheftBuilder.Forms
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DTP_Ausbildungsstart = new System.Windows.Forms.DateTimePicker();
            DTP_Ausbildungsende = new System.Windows.Forms.DateTimePicker();
            LB_Ausbildungsstart = new System.Windows.Forms.Label();
            LB_Ausbildungsende = new System.Windows.Forms.Label();
            LB_AuszubildenderName = new System.Windows.Forms.Label();
            TB_AuszubildenderName = new System.Windows.Forms.TextBox();
            TB_AusbilderName = new System.Windows.Forms.TextBox();
            LB_AusbilderName = new System.Windows.Forms.Label();
            BTN_Apply = new System.Windows.Forms.Button();
            LB_Ausbildungsabteilung = new System.Windows.Forms.Label();
            TB_Ausbildungsabteilung = new System.Windows.Forms.TextBox();
            TBC_Profile = new System.Windows.Forms.TabControl();
            TP_General = new System.Windows.Forms.TabPage();
            TP_SFTP = new System.Windows.Forms.TabPage();
            NUD_Port = new System.Windows.Forms.NumericUpDown();
            LB_Password = new System.Windows.Forms.Label();
            TB_Password = new System.Windows.Forms.TextBox();
            LB_Username = new System.Windows.Forms.Label();
            TB_Username = new System.Windows.Forms.TextBox();
            LB_Port = new System.Windows.Forms.Label();
            CB_IsEnabled = new System.Windows.Forms.CheckBox();
            LB_Host = new System.Windows.Forms.Label();
            TB_Host = new System.Windows.Forms.TextBox();
            LB_IsEnabled = new System.Windows.Forms.Label();
            TBC_Profile.SuspendLayout();
            TP_General.SuspendLayout();
            TP_SFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Port).BeginInit();
            SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            DTP_Ausbildungsstart.Cursor = System.Windows.Forms.Cursors.Hand;
            DTP_Ausbildungsstart.Location = new System.Drawing.Point(154, 90);
            DTP_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            DTP_Ausbildungsstart.Size = new System.Drawing.Size(279, 23);
            DTP_Ausbildungsstart.TabIndex = 0;
            // 
            // DTP_Ausbildungsende
            // 
            DTP_Ausbildungsende.Cursor = System.Windows.Forms.Cursors.Hand;
            DTP_Ausbildungsende.Location = new System.Drawing.Point(154, 126);
            DTP_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsende.Name = "DTP_Ausbildungsende";
            DTP_Ausbildungsende.Size = new System.Drawing.Size(279, 23);
            DTP_Ausbildungsende.TabIndex = 1;
            // 
            // LB_Ausbildungsstart
            // 
            LB_Ausbildungsstart.AutoSize = true;
            LB_Ausbildungsstart.Location = new System.Drawing.Point(12, 94);
            LB_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsstart.Name = "LB_Ausbildungsstart";
            LB_Ausbildungsstart.Size = new System.Drawing.Size(106, 16);
            LB_Ausbildungsstart.TabIndex = 2;
            LB_Ausbildungsstart.Text = "Ausbildungsstart:";
            // 
            // LB_Ausbildungsende
            // 
            LB_Ausbildungsende.AutoSize = true;
            LB_Ausbildungsende.Location = new System.Drawing.Point(12, 130);
            LB_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsende.Name = "LB_Ausbildungsende";
            LB_Ausbildungsende.Size = new System.Drawing.Size(108, 16);
            LB_Ausbildungsende.TabIndex = 3;
            LB_Ausbildungsende.Text = "Ausbildungsende:";
            // 
            // LB_AuszubildenderName
            // 
            LB_AuszubildenderName.AutoSize = true;
            LB_AuszubildenderName.Location = new System.Drawing.Point(12, 29);
            LB_AuszubildenderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_AuszubildenderName.Name = "LB_AuszubildenderName";
            LB_AuszubildenderName.Size = new System.Drawing.Size(45, 16);
            LB_AuszubildenderName.TabIndex = 4;
            LB_AuszubildenderName.Text = "Name:";
            // 
            // TB_AuszubildenderName
            // 
            TB_AuszubildenderName.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_AuszubildenderName.Location = new System.Drawing.Point(154, 26);
            TB_AuszubildenderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_AuszubildenderName.Name = "TB_AuszubildenderName";
            TB_AuszubildenderName.Size = new System.Drawing.Size(279, 23);
            TB_AuszubildenderName.TabIndex = 5;
            // 
            // TB_AusbilderName
            // 
            TB_AusbilderName.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_AusbilderName.Location = new System.Drawing.Point(154, 58);
            TB_AusbilderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_AusbilderName.Name = "TB_AusbilderName";
            TB_AusbilderName.Size = new System.Drawing.Size(279, 23);
            TB_AusbilderName.TabIndex = 6;
            // 
            // LB_AusbilderName
            // 
            LB_AusbilderName.AutoSize = true;
            LB_AusbilderName.Location = new System.Drawing.Point(12, 61);
            LB_AusbilderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_AusbilderName.Name = "LB_AusbilderName";
            LB_AusbilderName.Size = new System.Drawing.Size(102, 16);
            LB_AusbilderName.TabIndex = 7;
            LB_AusbilderName.Text = "Ausbilder Name:";
            // 
            // BTN_Apply
            // 
            BTN_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Apply.Location = new System.Drawing.Point(12, 249);
            BTN_Apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Apply.Name = "BTN_Apply";
            BTN_Apply.Size = new System.Drawing.Size(460, 54);
            BTN_Apply.TabIndex = 8;
            BTN_Apply.Text = "Übernehmen";
            BTN_Apply.UseVisualStyleBackColor = true;
            BTN_Apply.Click += BTN_Apply_Click;
            // 
            // LB_Ausbildungsabteilung
            // 
            LB_Ausbildungsabteilung.AutoSize = true;
            LB_Ausbildungsabteilung.Location = new System.Drawing.Point(10, 166);
            LB_Ausbildungsabteilung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsabteilung.Name = "LB_Ausbildungsabteilung";
            LB_Ausbildungsabteilung.Size = new System.Drawing.Size(132, 16);
            LB_Ausbildungsabteilung.TabIndex = 9;
            LB_Ausbildungsabteilung.Text = "Ausbildungsabteilung:";
            // 
            // TB_Ausbildungsabteilung
            // 
            TB_Ausbildungsabteilung.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Ausbildungsabteilung.Location = new System.Drawing.Point(154, 162);
            TB_Ausbildungsabteilung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Ausbildungsabteilung.Name = "TB_Ausbildungsabteilung";
            TB_Ausbildungsabteilung.Size = new System.Drawing.Size(279, 23);
            TB_Ausbildungsabteilung.TabIndex = 10;
            // 
            // TBC_Profile
            // 
            TBC_Profile.Controls.Add(TP_General);
            TBC_Profile.Controls.Add(TP_SFTP);
            TBC_Profile.Location = new System.Drawing.Point(12, 13);
            TBC_Profile.Name = "TBC_Profile";
            TBC_Profile.SelectedIndex = 0;
            TBC_Profile.Size = new System.Drawing.Size(460, 230);
            TBC_Profile.TabIndex = 11;
            // 
            // TP_General
            // 
            TP_General.Controls.Add(TB_AuszubildenderName);
            TP_General.Controls.Add(TB_Ausbildungsabteilung);
            TP_General.Controls.Add(DTP_Ausbildungsstart);
            TP_General.Controls.Add(LB_Ausbildungsabteilung);
            TP_General.Controls.Add(DTP_Ausbildungsende);
            TP_General.Controls.Add(LB_Ausbildungsstart);
            TP_General.Controls.Add(LB_AusbilderName);
            TP_General.Controls.Add(LB_Ausbildungsende);
            TP_General.Controls.Add(TB_AusbilderName);
            TP_General.Controls.Add(LB_AuszubildenderName);
            TP_General.Location = new System.Drawing.Point(4, 25);
            TP_General.Name = "TP_General";
            TP_General.Padding = new System.Windows.Forms.Padding(3);
            TP_General.Size = new System.Drawing.Size(452, 201);
            TP_General.TabIndex = 0;
            TP_General.Text = "Allgemein";
            TP_General.UseVisualStyleBackColor = true;
            // 
            // TP_SFTP
            // 
            TP_SFTP.Controls.Add(NUD_Port);
            TP_SFTP.Controls.Add(LB_Password);
            TP_SFTP.Controls.Add(TB_Password);
            TP_SFTP.Controls.Add(LB_Username);
            TP_SFTP.Controls.Add(TB_Username);
            TP_SFTP.Controls.Add(LB_Port);
            TP_SFTP.Controls.Add(CB_IsEnabled);
            TP_SFTP.Controls.Add(LB_Host);
            TP_SFTP.Controls.Add(TB_Host);
            TP_SFTP.Controls.Add(LB_IsEnabled);
            TP_SFTP.Location = new System.Drawing.Point(4, 24);
            TP_SFTP.Name = "TP_SFTP";
            TP_SFTP.Padding = new System.Windows.Forms.Padding(3);
            TP_SFTP.Size = new System.Drawing.Size(452, 202);
            TP_SFTP.TabIndex = 1;
            TP_SFTP.Text = "SFTP";
            TP_SFTP.UseVisualStyleBackColor = true;
            // 
            // NUD_Port
            // 
            NUD_Port.Location = new System.Drawing.Point(154, 90);
            NUD_Port.Name = "NUD_Port";
            NUD_Port.Size = new System.Drawing.Size(279, 23);
            NUD_Port.TabIndex = 16;
            // 
            // LB_Password
            // 
            LB_Password.AutoSize = true;
            LB_Password.Location = new System.Drawing.Point(10, 166);
            LB_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Password.Name = "LB_Password";
            LB_Password.Size = new System.Drawing.Size(64, 16);
            LB_Password.TabIndex = 15;
            LB_Password.Text = "Passwort:";
            // 
            // TB_Password
            // 
            TB_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Password.Location = new System.Drawing.Point(154, 162);
            TB_Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '*';
            TB_Password.Size = new System.Drawing.Size(279, 23);
            TB_Password.TabIndex = 14;
            // 
            // LB_Username
            // 
            LB_Username.AutoSize = true;
            LB_Username.Location = new System.Drawing.Point(12, 130);
            LB_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new System.Drawing.Size(70, 16);
            LB_Username.TabIndex = 13;
            LB_Username.Text = "Username:";
            // 
            // TB_Username
            // 
            TB_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Username.Location = new System.Drawing.Point(154, 126);
            TB_Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new System.Drawing.Size(279, 23);
            TB_Username.TabIndex = 12;
            // 
            // LB_Port
            // 
            LB_Port.AutoSize = true;
            LB_Port.Location = new System.Drawing.Point(12, 94);
            LB_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Port.Name = "LB_Port";
            LB_Port.Size = new System.Drawing.Size(35, 16);
            LB_Port.TabIndex = 11;
            LB_Port.Text = "Port:";
            // 
            // CB_IsEnabled
            // 
            CB_IsEnabled.AutoSize = true;
            CB_IsEnabled.Location = new System.Drawing.Point(154, 26);
            CB_IsEnabled.Name = "CB_IsEnabled";
            CB_IsEnabled.Size = new System.Drawing.Size(15, 14);
            CB_IsEnabled.TabIndex = 9;
            CB_IsEnabled.UseVisualStyleBackColor = true;
            CB_IsEnabled.CheckedChanged += CB_IsEnabled_CheckedChanged;
            // 
            // LB_Host
            // 
            LB_Host.AutoSize = true;
            LB_Host.Location = new System.Drawing.Point(12, 61);
            LB_Host.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Host.Name = "LB_Host";
            LB_Host.Size = new System.Drawing.Size(37, 16);
            LB_Host.TabIndex = 8;
            LB_Host.Text = "Host:";
            // 
            // TB_Host
            // 
            TB_Host.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Host.Location = new System.Drawing.Point(154, 58);
            TB_Host.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Host.Name = "TB_Host";
            TB_Host.Size = new System.Drawing.Size(279, 23);
            TB_Host.TabIndex = 7;
            // 
            // LB_IsEnabled
            // 
            LB_IsEnabled.AutoSize = true;
            LB_IsEnabled.Location = new System.Drawing.Point(12, 29);
            LB_IsEnabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_IsEnabled.Name = "LB_IsEnabled";
            LB_IsEnabled.Size = new System.Drawing.Size(50, 16);
            LB_IsEnabled.TabIndex = 6;
            LB_IsEnabled.Text = "Enable:";
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 311);
            Controls.Add(TBC_Profile);
            Controls.Add(BTN_Apply);
            Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Profile";
            Text = "Profile";
            TBC_Profile.ResumeLayout(false);
            TP_General.ResumeLayout(false);
            TP_General.PerformLayout();
            TP_SFTP.ResumeLayout(false);
            TP_SFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Port).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_Ausbildungsstart;
        private System.Windows.Forms.DateTimePicker DTP_Ausbildungsende;
        private System.Windows.Forms.Label LB_Ausbildungsstart;
        private System.Windows.Forms.Label LB_Ausbildungsende;
        private System.Windows.Forms.Label LB_AuszubildenderName;
        private System.Windows.Forms.TextBox TB_AuszubildenderName;
        private System.Windows.Forms.TextBox TB_AusbilderName;
        private System.Windows.Forms.Label LB_AusbilderName;
        private System.Windows.Forms.Button BTN_Apply;
        private System.Windows.Forms.Label LB_Ausbildungsabteilung;
        private System.Windows.Forms.TextBox TB_Ausbildungsabteilung;
        private System.Windows.Forms.TabControl TBC_Profile;
        private System.Windows.Forms.TabPage TP_General;
        private System.Windows.Forms.TabPage TP_SFTP;
        private System.Windows.Forms.TextBox TB_Host;
        private System.Windows.Forms.Label LB_IsEnabled;
        private System.Windows.Forms.Label LB_Host;
        private System.Windows.Forms.CheckBox CB_IsEnabled;
        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label LB_Port;
    }
}