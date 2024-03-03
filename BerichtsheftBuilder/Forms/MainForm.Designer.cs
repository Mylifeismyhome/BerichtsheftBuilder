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
            LV_Task = new System.Windows.Forms.ListView();
            Task = new System.Windows.Forms.ColumnHeader();
            Duration = new System.Windows.Forms.ColumnHeader();
            BTN_Add = new System.Windows.Forms.Button();
            BTN_Remove = new System.Windows.Forms.Button();
            LB_Name = new System.Windows.Forms.Label();
            TB_Name = new System.Windows.Forms.TextBox();
            TB_AusbilderName = new System.Windows.Forms.TextBox();
            LB_AusbilderName = new System.Windows.Forms.Label();
            GP_Daten = new System.Windows.Forms.GroupBox();
            BTN_Modify = new System.Windows.Forms.Button();
            LB_Ausbildungsabteilung = new System.Windows.Forms.Label();
            TB_Ausbildungsabteilung = new System.Windows.Forms.TextBox();
            BTN_Generate = new System.Windows.Forms.Button();
            GP_Daten.SuspendLayout();
            SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            DTP_Ausbildungsstart.Enabled = false;
            DTP_Ausbildungsstart.Location = new System.Drawing.Point(6, 141);
            DTP_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            DTP_Ausbildungsstart.Size = new System.Drawing.Size(270, 23);
            DTP_Ausbildungsstart.TabIndex = 0;
            // 
            // DTP_Ausbildungsende
            // 
            DTP_Ausbildungsende.Enabled = false;
            DTP_Ausbildungsende.Location = new System.Drawing.Point(6, 199);
            DTP_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsende.Name = "DTP_Ausbildungsende";
            DTP_Ausbildungsende.Size = new System.Drawing.Size(270, 23);
            DTP_Ausbildungsende.TabIndex = 1;
            // 
            // LB_Ausbildungsstart
            // 
            LB_Ausbildungsstart.AutoSize = true;
            LB_Ausbildungsstart.Location = new System.Drawing.Point(6, 119);
            LB_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsstart.Name = "LB_Ausbildungsstart";
            LB_Ausbildungsstart.Size = new System.Drawing.Size(96, 15);
            LB_Ausbildungsstart.TabIndex = 2;
            LB_Ausbildungsstart.Text = "Ausbildungsstart";
            // 
            // LB_Ausbildungsende
            // 
            LB_Ausbildungsende.AutoSize = true;
            LB_Ausbildungsende.Location = new System.Drawing.Point(6, 177);
            LB_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsende.Name = "LB_Ausbildungsende";
            LB_Ausbildungsende.Size = new System.Drawing.Size(99, 15);
            LB_Ausbildungsende.TabIndex = 3;
            LB_Ausbildungsende.Text = "Ausbildungsende";
            // 
            // CB_Kalenderwoche
            // 
            CB_Kalenderwoche.FormattingEnabled = true;
            CB_Kalenderwoche.Location = new System.Drawing.Point(301, 28);
            CB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CB_Kalenderwoche.Name = "CB_Kalenderwoche";
            CB_Kalenderwoche.Size = new System.Drawing.Size(230, 23);
            CB_Kalenderwoche.TabIndex = 4;
            CB_Kalenderwoche.SelectedIndexChanged += CB_Kalenderwoche_SelectedIndexChanged;
            // 
            // LB_Kalenderwoche
            // 
            LB_Kalenderwoche.AutoSize = true;
            LB_Kalenderwoche.Location = new System.Drawing.Point(301, 6);
            LB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Kalenderwoche.Name = "LB_Kalenderwoche";
            LB_Kalenderwoche.Size = new System.Drawing.Size(93, 15);
            LB_Kalenderwoche.TabIndex = 5;
            LB_Kalenderwoche.Text = "Kalender Woche";
            // 
            // LV_Task
            // 
            LV_Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LV_Task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Task, Duration });
            LV_Task.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            LV_Task.Location = new System.Drawing.Point(301, 60);
            LV_Task.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LV_Task.Name = "LV_Task";
            LV_Task.ShowGroups = false;
            LV_Task.Size = new System.Drawing.Size(606, 414);
            LV_Task.TabIndex = 6;
            LV_Task.UseCompatibleStateImageBehavior = false;
            LV_Task.View = System.Windows.Forms.View.Details;
            LV_Task.SelectedIndexChanged += LV_Task_SelectedIndexChanged;
            // 
            // Task
            // 
            Task.Text = "Tätigkeit";
            Task.Width = 200;
            // 
            // Duration
            // 
            Duration.Text = "Dauer";
            // 
            // BTN_Add
            // 
            BTN_Add.Location = new System.Drawing.Point(301, 480);
            BTN_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Add.Name = "BTN_Add";
            BTN_Add.Size = new System.Drawing.Size(88, 27);
            BTN_Add.TabIndex = 7;
            BTN_Add.Text = "Hinzufügen";
            BTN_Add.UseVisualStyleBackColor = true;
            BTN_Add.Click += BTN_Add_Click;
            // 
            // BTN_Remove
            // 
            BTN_Remove.Location = new System.Drawing.Point(819, 480);
            BTN_Remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Remove.Name = "BTN_Remove";
            BTN_Remove.Size = new System.Drawing.Size(88, 27);
            BTN_Remove.TabIndex = 8;
            BTN_Remove.Text = "Entfernen";
            BTN_Remove.UseVisualStyleBackColor = true;
            BTN_Remove.Click += BTN_Remove_Click;
            // 
            // LB_Name
            // 
            LB_Name.AutoSize = true;
            LB_Name.Location = new System.Drawing.Point(6, 19);
            LB_Name.Name = "LB_Name";
            LB_Name.Size = new System.Drawing.Size(39, 15);
            LB_Name.TabIndex = 9;
            LB_Name.Text = "Name";
            // 
            // TB_Name
            // 
            TB_Name.Enabled = false;
            TB_Name.Location = new System.Drawing.Point(6, 39);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new System.Drawing.Size(270, 23);
            TB_Name.TabIndex = 10;
            // 
            // TB_AusbilderName
            // 
            TB_AusbilderName.Enabled = false;
            TB_AusbilderName.Location = new System.Drawing.Point(6, 88);
            TB_AusbilderName.Name = "TB_AusbilderName";
            TB_AusbilderName.Size = new System.Drawing.Size(270, 23);
            TB_AusbilderName.TabIndex = 11;
            // 
            // LB_AusbilderName
            // 
            LB_AusbilderName.AutoSize = true;
            LB_AusbilderName.Location = new System.Drawing.Point(6, 67);
            LB_AusbilderName.Name = "LB_AusbilderName";
            LB_AusbilderName.Size = new System.Drawing.Size(92, 15);
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
            GP_Daten.Size = new System.Drawing.Size(282, 498);
            GP_Daten.TabIndex = 13;
            GP_Daten.TabStop = false;
            GP_Daten.Text = "Daten";
            // 
            // BTN_Modify
            // 
            BTN_Modify.Location = new System.Drawing.Point(201, 469);
            BTN_Modify.Name = "BTN_Modify";
            BTN_Modify.Size = new System.Drawing.Size(75, 23);
            BTN_Modify.TabIndex = 15;
            BTN_Modify.Text = "Bearbeiten";
            BTN_Modify.UseVisualStyleBackColor = true;
            BTN_Modify.Click += BTN_Modify_Click;
            // 
            // LB_Ausbildungsabteilung
            // 
            LB_Ausbildungsabteilung.AutoSize = true;
            LB_Ausbildungsabteilung.Location = new System.Drawing.Point(6, 232);
            LB_Ausbildungsabteilung.Name = "LB_Ausbildungsabteilung";
            LB_Ausbildungsabteilung.Size = new System.Drawing.Size(123, 15);
            LB_Ausbildungsabteilung.TabIndex = 13;
            LB_Ausbildungsabteilung.Text = "Ausbildungsabteilung";
            // 
            // TB_Ausbildungsabteilung
            // 
            TB_Ausbildungsabteilung.Enabled = false;
            TB_Ausbildungsabteilung.Location = new System.Drawing.Point(6, 255);
            TB_Ausbildungsabteilung.Name = "TB_Ausbildungsabteilung";
            TB_Ausbildungsabteilung.Size = new System.Drawing.Size(270, 23);
            TB_Ausbildungsabteilung.TabIndex = 14;
            // 
            // BTN_Generate
            // 
            BTN_Generate.Location = new System.Drawing.Point(808, 28);
            BTN_Generate.Name = "BTN_Generate";
            BTN_Generate.Size = new System.Drawing.Size(99, 23);
            BTN_Generate.TabIndex = 14;
            BTN_Generate.Text = "Erstelle PDF";
            BTN_Generate.UseVisualStyleBackColor = true;
            BTN_Generate.Click += BTN_Generate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(BTN_Generate);
            Controls.Add(GP_Daten);
            Controls.Add(BTN_Remove);
            Controls.Add(BTN_Add);
            Controls.Add(LV_Task);
            Controls.Add(LB_Kalenderwoche);
            Controls.Add(CB_Kalenderwoche);
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
        private System.Windows.Forms.ListView LV_Task;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_AusbilderName;
        private System.Windows.Forms.Label LB_AusbilderName;
        private System.Windows.Forms.GroupBox GP_Daten;
        private System.Windows.Forms.Label LB_Ausbildungsabteilung;
        private System.Windows.Forms.TextBox TB_Ausbildungsabteilung;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.Button BTN_Modify;
    }
}

