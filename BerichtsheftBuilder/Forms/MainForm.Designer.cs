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
            BTN_Modify = new System.Windows.Forms.Button();
            LB_Ausbildungsabteilung = new System.Windows.Forms.Label();
            TB_Ausbildungsabteilung = new System.Windows.Forms.TextBox();
            BTN_Generate = new System.Windows.Forms.Button();
            RTB_Task = new System.Windows.Forms.RichTextBox();
            RTB_SchoolTask = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            LB_Task = new System.Windows.Forms.Label();
            GP_Daten.SuspendLayout();
            SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            DTP_Ausbildungsstart.Cursor = System.Windows.Forms.Cursors.Hand;
            DTP_Ausbildungsstart.Enabled = false;
            DTP_Ausbildungsstart.Location = new System.Drawing.Point(6, 151);
            DTP_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            DTP_Ausbildungsstart.Size = new System.Drawing.Size(270, 23);
            DTP_Ausbildungsstart.TabIndex = 0;
            // 
            // DTP_Ausbildungsende
            // 
            DTP_Ausbildungsende.Cursor = System.Windows.Forms.Cursors.Hand;
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
            CB_Kalenderwoche.Size = new System.Drawing.Size(230, 24);
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
            TB_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Name.Enabled = false;
            TB_Name.Location = new System.Drawing.Point(6, 41);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new System.Drawing.Size(270, 23);
            TB_Name.TabIndex = 10;
            // 
            // TB_AusbilderName
            // 
            TB_AusbilderName.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            GP_Daten.Size = new System.Drawing.Size(282, 531);
            GP_Daten.TabIndex = 13;
            GP_Daten.TabStop = false;
            GP_Daten.Text = "Daten";
            // 
            // BTN_Modify
            // 
            BTN_Modify.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Modify.Location = new System.Drawing.Point(201, 500);
            BTN_Modify.Name = "BTN_Modify";
            BTN_Modify.Size = new System.Drawing.Size(75, 24);
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
            TB_Ausbildungsabteilung.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_Ausbildungsabteilung.Enabled = false;
            TB_Ausbildungsabteilung.Location = new System.Drawing.Point(6, 272);
            TB_Ausbildungsabteilung.Name = "TB_Ausbildungsabteilung";
            TB_Ausbildungsabteilung.Size = new System.Drawing.Size(270, 23);
            TB_Ausbildungsabteilung.TabIndex = 14;
            // 
            // BTN_Generate
            // 
            BTN_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Generate.Location = new System.Drawing.Point(822, 29);
            BTN_Generate.Name = "BTN_Generate";
            BTN_Generate.Size = new System.Drawing.Size(99, 24);
            BTN_Generate.TabIndex = 14;
            BTN_Generate.Text = "Erstelle PDF";
            BTN_Generate.UseVisualStyleBackColor = true;
            BTN_Generate.Click += BTN_Generate_Click;
            // 
            // RTB_Task
            // 
            RTB_Task.BackColor = System.Drawing.SystemColors.Window;
            RTB_Task.Cursor = System.Windows.Forms.Cursors.IBeam;
            RTB_Task.Location = new System.Drawing.Point(301, 83);
            RTB_Task.Name = "RTB_Task";
            RTB_Task.Size = new System.Drawing.Size(620, 213);
            RTB_Task.TabIndex = 15;
            RTB_Task.Text = "";
            RTB_Task.TextChanged += RTB_Task_TextChanged;
            // 
            // RTB_SchoolTask
            // 
            RTB_SchoolTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            RTB_SchoolTask.Location = new System.Drawing.Point(301, 326);
            RTB_SchoolTask.Name = "RTB_SchoolTask";
            RTB_SchoolTask.Size = new System.Drawing.Size(620, 213);
            RTB_SchoolTask.TabIndex = 16;
            RTB_SchoolTask.Text = "";
            RTB_SchoolTask.TextChanged += RTB_SchoolTask_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(301, 305);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 16);
            label1.TabIndex = 17;
            label1.Text = "Berufsschule (Unterrichtsthemen)";
            // 
            // LB_Task
            // 
            LB_Task.AutoSize = true;
            LB_Task.Location = new System.Drawing.Point(301, 62);
            LB_Task.Name = "LB_Task";
            LB_Task.Size = new System.Drawing.Size(140, 16);
            LB_Task.TabIndex = 18;
            LB_Task.Text = "Betriebliche Tätigkeiten";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 553);
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
            Name = "MainForm";
            Text = "Berichtsheft Builder";
            GP_Daten.ResumeLayout(false);
            GP_Daten.PerformLayout();
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
    }
}

