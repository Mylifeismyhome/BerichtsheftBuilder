using System;

namespace BerichtsheftBuilder
{
    partial class MainForm
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
            CB_Kalenderwoche = new System.Windows.Forms.ComboBox();
            LB_Kalenderwoche = new System.Windows.Forms.Label();
            LB_Name = new System.Windows.Forms.Label();
            TB_Name = new System.Windows.Forms.TextBox();
            TB_AusbilderName = new System.Windows.Forms.TextBox();
            LB_AusbilderName = new System.Windows.Forms.Label();
            GP_Daten = new System.Windows.Forms.GroupBox();
            GB_SFTP = new System.Windows.Forms.GroupBox();
            LB_SFTP_LastCommit = new System.Windows.Forms.Label();
            LB_SFTP_LastPull = new System.Windows.Forms.Label();
            BTN_SFTP_Commit = new System.Windows.Forms.Button();
            BTN_SFTP_Pull = new System.Windows.Forms.Button();
            NUD_SFTP_Port = new System.Windows.Forms.NumericUpDown();
            LB_SFTP_Username = new System.Windows.Forms.Label();
            TB_SFTP_Username = new System.Windows.Forms.TextBox();
            LB_SFTP_Port = new System.Windows.Forms.Label();
            LB_SFTP_Host = new System.Windows.Forms.Label();
            TB_SFTP_Host = new System.Windows.Forms.TextBox();
            CB_SFTP_IsEnabled = new System.Windows.Forms.CheckBox();
            BTN_Modify = new System.Windows.Forms.Button();
            LB_Ausbildungsabteilung = new System.Windows.Forms.Label();
            TB_Ausbildungsabteilung = new System.Windows.Forms.TextBox();
            BTN_Generate = new System.Windows.Forms.Button();
            RTB_Task = new System.Windows.Forms.RichTextBox();
            RTB_SchoolTask = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            LB_Task = new System.Windows.Forms.Label();
            LB_Total_Duration = new System.Windows.Forms.Label();
            GP_Daten.SuspendLayout();
            GB_SFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_SFTP_Port).BeginInit();
            SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            DTP_Ausbildungsstart.Cursor = System.Windows.Forms.Cursors.No;
            DTP_Ausbildungsstart.Enabled = false;
            DTP_Ausbildungsstart.Location = new System.Drawing.Point(6, 151);
            DTP_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            DTP_Ausbildungsstart.Size = new System.Drawing.Size(270, 23);
            DTP_Ausbildungsstart.TabIndex = 0;
            // 
            // DTP_Ausbildungsende
            // 
            DTP_Ausbildungsende.Cursor = System.Windows.Forms.Cursors.No;
            DTP_Ausbildungsende.Enabled = false;
            DTP_Ausbildungsende.Location = new System.Drawing.Point(6, 212);
            DTP_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsende.Name = "DTP_Ausbildungsende";
            DTP_Ausbildungsende.Size = new System.Drawing.Size(270, 23);
            DTP_Ausbildungsende.TabIndex = 1;
            // 
            // LB_Ausbildungsstart
            // 
            LB_Ausbildungsstart.AutoSize = true;
            LB_Ausbildungsstart.Location = new System.Drawing.Point(6, 127);
            LB_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsstart.Name = "LB_Ausbildungsstart";
            LB_Ausbildungsstart.Size = new System.Drawing.Size(101, 16);
            LB_Ausbildungsstart.TabIndex = 2;
            LB_Ausbildungsstart.Text = "Ausbildungsstart";
            // 
            // LB_Ausbildungsende
            // 
            LB_Ausbildungsende.AutoSize = true;
            LB_Ausbildungsende.Location = new System.Drawing.Point(6, 189);
            LB_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsende.Name = "LB_Ausbildungsende";
            LB_Ausbildungsende.Size = new System.Drawing.Size(103, 16);
            LB_Ausbildungsende.TabIndex = 3;
            LB_Ausbildungsende.Text = "Ausbildungsende";
            // 
            // CB_Kalenderwoche
            // 
            CB_Kalenderwoche.Cursor = System.Windows.Forms.Cursors.Hand;
            CB_Kalenderwoche.FormattingEnabled = true;
            CB_Kalenderwoche.Location = new System.Drawing.Point(301, 29);
            CB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CB_Kalenderwoche.Name = "CB_Kalenderwoche";
            CB_Kalenderwoche.Size = new System.Drawing.Size(765, 24);
            CB_Kalenderwoche.TabIndex = 4;
            CB_Kalenderwoche.SelectedIndexChanged += CB_Kalenderwoche_SelectedIndexChanged;
            // 
            // LB_Kalenderwoche
            // 
            LB_Kalenderwoche.AutoSize = true;
            LB_Kalenderwoche.Location = new System.Drawing.Point(301, 7);
            LB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Kalenderwoche.Name = "LB_Kalenderwoche";
            LB_Kalenderwoche.Size = new System.Drawing.Size(100, 16);
            LB_Kalenderwoche.TabIndex = 5;
            LB_Kalenderwoche.Text = "Kalender Woche";
            // 
            // LB_Name
            // 
            LB_Name.AutoSize = true;
            LB_Name.Location = new System.Drawing.Point(6, 20);
            LB_Name.Name = "LB_Name";
            LB_Name.Size = new System.Drawing.Size(40, 16);
            LB_Name.TabIndex = 9;
            LB_Name.Text = "Name";
            // 
            // TB_Name
            // 
            TB_Name.Cursor = System.Windows.Forms.Cursors.No;
            TB_Name.Enabled = false;
            TB_Name.Location = new System.Drawing.Point(6, 41);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new System.Drawing.Size(270, 23);
            TB_Name.TabIndex = 10;
            // 
            // TB_AusbilderName
            // 
            TB_AusbilderName.Cursor = System.Windows.Forms.Cursors.No;
            TB_AusbilderName.Enabled = false;
            TB_AusbilderName.Location = new System.Drawing.Point(6, 93);
            TB_AusbilderName.Name = "TB_AusbilderName";
            TB_AusbilderName.Size = new System.Drawing.Size(270, 23);
            TB_AusbilderName.TabIndex = 11;
            // 
            // LB_AusbilderName
            // 
            LB_AusbilderName.AutoSize = true;
            LB_AusbilderName.Location = new System.Drawing.Point(6, 72);
            LB_AusbilderName.Name = "LB_AusbilderName";
            LB_AusbilderName.Size = new System.Drawing.Size(97, 16);
            LB_AusbilderName.TabIndex = 12;
            LB_AusbilderName.Text = "Ausbilder Name";
            // 
            // GP_Daten
            // 
            GP_Daten.Controls.Add(GB_SFTP);
            GP_Daten.Controls.Add(BTN_Modify);
            GP_Daten.Controls.Add(LB_Ausbildungsabteilung);
            GP_Daten.Controls.Add(TB_Ausbildungsabteilung);
            GP_Daten.Controls.Add(LB_Name);
            GP_Daten.Controls.Add(LB_AusbilderName);
            GP_Daten.Controls.Add(DTP_Ausbildungsstart);
            GP_Daten.Controls.Add(TB_AusbilderName);
            GP_Daten.Controls.Add(DTP_Ausbildungsende);
            GP_Daten.Controls.Add(TB_Name);
            GP_Daten.Controls.Add(LB_Ausbildungsstart);
            GP_Daten.Controls.Add(LB_Ausbildungsende);
            GP_Daten.Location = new System.Drawing.Point(12, 9);
            GP_Daten.Name = "GP_Daten";
            GP_Daten.Size = new System.Drawing.Size(282, 740);
            GP_Daten.TabIndex = 13;
            GP_Daten.TabStop = false;
            GP_Daten.Text = "Informationen";
            // 
            // GB_SFTP
            // 
            GB_SFTP.Controls.Add(LB_SFTP_LastCommit);
            GB_SFTP.Controls.Add(LB_SFTP_LastPull);
            GB_SFTP.Controls.Add(BTN_SFTP_Commit);
            GB_SFTP.Controls.Add(BTN_SFTP_Pull);
            GB_SFTP.Controls.Add(NUD_SFTP_Port);
            GB_SFTP.Controls.Add(LB_SFTP_Username);
            GB_SFTP.Controls.Add(TB_SFTP_Username);
            GB_SFTP.Controls.Add(LB_SFTP_Port);
            GB_SFTP.Controls.Add(LB_SFTP_Host);
            GB_SFTP.Controls.Add(TB_SFTP_Host);
            GB_SFTP.Controls.Add(CB_SFTP_IsEnabled);
            GB_SFTP.Location = new System.Drawing.Point(6, 317);
            GB_SFTP.Name = "GB_SFTP";
            GB_SFTP.Size = new System.Drawing.Size(270, 375);
            GB_SFTP.TabIndex = 16;
            GB_SFTP.TabStop = false;
            GB_SFTP.Text = "SFTP";
            // 
            // LB_SFTP_LastCommit
            // 
            LB_SFTP_LastCommit.AutoSize = true;
            LB_SFTP_LastCommit.Location = new System.Drawing.Point(12, 345);
            LB_SFTP_LastCommit.Name = "LB_SFTP_LastCommit";
            LB_SFTP_LastCommit.Size = new System.Drawing.Size(89, 16);
            LB_SFTP_LastCommit.TabIndex = 27;
            LB_SFTP_LastCommit.Text = "last commit xy";
            // 
            // LB_SFTP_LastPull
            // 
            LB_SFTP_LastPull.AutoSize = true;
            LB_SFTP_LastPull.Location = new System.Drawing.Point(12, 260);
            LB_SFTP_LastPull.Name = "LB_SFTP_LastPull";
            LB_SFTP_LastPull.Size = new System.Drawing.Size(67, 16);
            LB_SFTP_LastPull.TabIndex = 26;
            LB_SFTP_LastPull.Text = "last pull xy";
            // 
            // BTN_SFTP_Commit
            // 
            BTN_SFTP_Commit.Location = new System.Drawing.Point(5, 285);
            BTN_SFTP_Commit.Name = "BTN_SFTP_Commit";
            BTN_SFTP_Commit.Size = new System.Drawing.Size(260, 50);
            BTN_SFTP_Commit.TabIndex = 25;
            BTN_SFTP_Commit.Text = "Commit";
            BTN_SFTP_Commit.UseVisualStyleBackColor = true;
            BTN_SFTP_Commit.Click += BTN_SFTP_Commit_Click;
            // 
            // BTN_SFTP_Pull
            // 
            BTN_SFTP_Pull.Location = new System.Drawing.Point(5, 200);
            BTN_SFTP_Pull.Name = "BTN_SFTP_Pull";
            BTN_SFTP_Pull.Size = new System.Drawing.Size(260, 50);
            BTN_SFTP_Pull.TabIndex = 24;
            BTN_SFTP_Pull.Text = "Pull";
            BTN_SFTP_Pull.UseVisualStyleBackColor = true;
            BTN_SFTP_Pull.Click += BTN_SFTP_Pull_Click;
            // 
            // NUD_SFTP_Port
            // 
            NUD_SFTP_Port.Cursor = System.Windows.Forms.Cursors.No;
            NUD_SFTP_Port.Enabled = false;
            NUD_SFTP_Port.Location = new System.Drawing.Point(12, 114);
            NUD_SFTP_Port.Name = "NUD_SFTP_Port";
            NUD_SFTP_Port.Size = new System.Drawing.Size(252, 23);
            NUD_SFTP_Port.TabIndex = 23;
            // 
            // LB_SFTP_Username
            // 
            LB_SFTP_Username.AutoSize = true;
            LB_SFTP_Username.Location = new System.Drawing.Point(10, 143);
            LB_SFTP_Username.Name = "LB_SFTP_Username";
            LB_SFTP_Username.Size = new System.Drawing.Size(65, 16);
            LB_SFTP_Username.TabIndex = 21;
            LB_SFTP_Username.Text = "Username";
            // 
            // TB_SFTP_Username
            // 
            TB_SFTP_Username.Cursor = System.Windows.Forms.Cursors.No;
            TB_SFTP_Username.Enabled = false;
            TB_SFTP_Username.Location = new System.Drawing.Point(12, 164);
            TB_SFTP_Username.Name = "TB_SFTP_Username";
            TB_SFTP_Username.Size = new System.Drawing.Size(252, 23);
            TB_SFTP_Username.TabIndex = 22;
            // 
            // LB_SFTP_Port
            // 
            LB_SFTP_Port.AutoSize = true;
            LB_SFTP_Port.Location = new System.Drawing.Point(10, 93);
            LB_SFTP_Port.Name = "LB_SFTP_Port";
            LB_SFTP_Port.Size = new System.Drawing.Size(30, 16);
            LB_SFTP_Port.TabIndex = 19;
            LB_SFTP_Port.Text = "Port";
            // 
            // LB_SFTP_Host
            // 
            LB_SFTP_Host.AutoSize = true;
            LB_SFTP_Host.Location = new System.Drawing.Point(10, 43);
            LB_SFTP_Host.Name = "LB_SFTP_Host";
            LB_SFTP_Host.Size = new System.Drawing.Size(32, 16);
            LB_SFTP_Host.TabIndex = 17;
            LB_SFTP_Host.Text = "Host";
            // 
            // TB_SFTP_Host
            // 
            TB_SFTP_Host.Cursor = System.Windows.Forms.Cursors.No;
            TB_SFTP_Host.Enabled = false;
            TB_SFTP_Host.Location = new System.Drawing.Point(12, 64);
            TB_SFTP_Host.Name = "TB_SFTP_Host";
            TB_SFTP_Host.Size = new System.Drawing.Size(252, 23);
            TB_SFTP_Host.TabIndex = 18;
            // 
            // CB_SFTP_IsEnabled
            // 
            CB_SFTP_IsEnabled.AutoSize = true;
            CB_SFTP_IsEnabled.Cursor = System.Windows.Forms.Cursors.No;
            CB_SFTP_IsEnabled.Enabled = false;
            CB_SFTP_IsEnabled.Location = new System.Drawing.Point(12, 22);
            CB_SFTP_IsEnabled.Name = "CB_SFTP_IsEnabled";
            CB_SFTP_IsEnabled.Size = new System.Drawing.Size(71, 20);
            CB_SFTP_IsEnabled.TabIndex = 16;
            CB_SFTP_IsEnabled.Text = "Enabled";
            CB_SFTP_IsEnabled.UseVisualStyleBackColor = true;
            // 
            // BTN_Modify
            // 
            BTN_Modify.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Modify.Location = new System.Drawing.Point(6, 698);
            BTN_Modify.Name = "BTN_Modify";
            BTN_Modify.Size = new System.Drawing.Size(270, 30);
            BTN_Modify.TabIndex = 15;
            BTN_Modify.Text = "Bearbeiten";
            BTN_Modify.UseVisualStyleBackColor = true;
            BTN_Modify.Click += BTN_Modify_Click;
            // 
            // LB_Ausbildungsabteilung
            // 
            LB_Ausbildungsabteilung.AutoSize = true;
            LB_Ausbildungsabteilung.Location = new System.Drawing.Point(6, 248);
            LB_Ausbildungsabteilung.Name = "LB_Ausbildungsabteilung";
            LB_Ausbildungsabteilung.Size = new System.Drawing.Size(127, 16);
            LB_Ausbildungsabteilung.TabIndex = 13;
            LB_Ausbildungsabteilung.Text = "Ausbildungsabteilung";
            // 
            // TB_Ausbildungsabteilung
            // 
            TB_Ausbildungsabteilung.Cursor = System.Windows.Forms.Cursors.No;
            TB_Ausbildungsabteilung.Enabled = false;
            TB_Ausbildungsabteilung.Location = new System.Drawing.Point(6, 272);
            TB_Ausbildungsabteilung.Name = "TB_Ausbildungsabteilung";
            TB_Ausbildungsabteilung.Size = new System.Drawing.Size(270, 23);
            TB_Ausbildungsabteilung.TabIndex = 14;
            // 
            // BTN_Generate
            // 
            BTN_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Generate.Location = new System.Drawing.Point(1073, 12);
            BTN_Generate.Name = "BTN_Generate";
            BTN_Generate.Size = new System.Drawing.Size(100, 50);
            BTN_Generate.TabIndex = 14;
            BTN_Generate.Text = "Exportieren";
            BTN_Generate.UseVisualStyleBackColor = true;
            BTN_Generate.Click += BTN_Generate_Click;
            // 
            // RTB_Task
            // 
            RTB_Task.BackColor = System.Drawing.SystemColors.Window;
            RTB_Task.Cursor = System.Windows.Forms.Cursors.IBeam;
            RTB_Task.Location = new System.Drawing.Point(300, 100);
            RTB_Task.Name = "RTB_Task";
            RTB_Task.Size = new System.Drawing.Size(870, 300);
            RTB_Task.TabIndex = 15;
            RTB_Task.Text = "";
            RTB_Task.KeyUp += RTB_Task_KeyUp;
            // 
            // RTB_SchoolTask
            // 
            RTB_SchoolTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            RTB_SchoolTask.Location = new System.Drawing.Point(300, 450);
            RTB_SchoolTask.Name = "RTB_SchoolTask";
            RTB_SchoolTask.Size = new System.Drawing.Size(870, 300);
            RTB_SchoolTask.TabIndex = 16;
            RTB_SchoolTask.Text = "";
            RTB_SchoolTask.KeyUp += RTB_SchoolTask_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(300, 419);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 16);
            label1.TabIndex = 17;
            label1.Text = "Berufsschule (Unterrichtsthemen)";
            // 
            // LB_Task
            // 
            LB_Task.AutoSize = true;
            LB_Task.Location = new System.Drawing.Point(301, 70);
            LB_Task.Name = "LB_Task";
            LB_Task.Size = new System.Drawing.Size(140, 16);
            LB_Task.TabIndex = 18;
            LB_Task.Text = "Betriebliche Tätigkeiten";
            // 
            // LB_Total_Duration
            // 
            LB_Total_Duration.Location = new System.Drawing.Point(447, 70);
            LB_Total_Duration.Name = "LB_Total_Duration";
            LB_Total_Duration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LB_Total_Duration.Size = new System.Drawing.Size(723, 16);
            LB_Total_Duration.TabIndex = 19;
            LB_Total_Duration.Text = "Insgesamt erfasste Sunden: 0";
            LB_Total_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 761);
            Controls.Add(LB_Total_Duration);
            Controls.Add(LB_Task);
            Controls.Add(label1);
            Controls.Add(RTB_SchoolTask);
            Controls.Add(RTB_Task);
            Controls.Add(BTN_Generate);
            Controls.Add(GP_Daten);
            Controls.Add(LB_Kalenderwoche);
            Controls.Add(CB_Kalenderwoche);
            Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Berichtsheft Builder";
            GP_Daten.ResumeLayout(false);
            GP_Daten.PerformLayout();
            GB_SFTP.ResumeLayout(false);
            GB_SFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_SFTP_Port).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_Ausbildungsstart;
        private System.Windows.Forms.DateTimePicker DTP_Ausbildungsende;
        private System.Windows.Forms.Label LB_Ausbildungsstart;
        private System.Windows.Forms.Label LB_Ausbildungsende;
        private System.Windows.Forms.ComboBox CB_Kalenderwoche;
        private System.Windows.Forms.Label LB_Kalenderwoche;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_AusbilderName;
        private System.Windows.Forms.Label LB_AusbilderName;
        private System.Windows.Forms.GroupBox GP_Daten;
        private System.Windows.Forms.Label LB_Ausbildungsabteilung;
        private System.Windows.Forms.TextBox TB_Ausbildungsabteilung;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.Button BTN_Modify;
        private System.Windows.Forms.RichTextBox RTB_Task;
        private System.Windows.Forms.RichTextBox RTB_SchoolTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Task;
        private System.Windows.Forms.GroupBox GB_SFTP;
        private System.Windows.Forms.Button BTN_SFTP_Pull;
        private System.Windows.Forms.NumericUpDown NUD_SFTP_Port;
        private System.Windows.Forms.Label LB_SFTP_Username;
        private System.Windows.Forms.TextBox TB_SFTP_Username;
        private System.Windows.Forms.Label LB_SFTP_Port;
        private System.Windows.Forms.Label LB_SFTP_Host;
        private System.Windows.Forms.TextBox TB_SFTP_Host;
        private System.Windows.Forms.CheckBox CB_SFTP_IsEnabled;
        private System.Windows.Forms.Label LB_SFTP_LastCommit;
        private System.Windows.Forms.Label LB_SFTP_LastPull;
        private System.Windows.Forms.Button BTN_SFTP_Commit;
        private System.Windows.Forms.Label LB_Total_Duration;
    }
}

