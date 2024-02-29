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
            this.DTP_Ausbildungsstart = new System.Windows.Forms.DateTimePicker();
            this.DTP_Ausbildungsende = new System.Windows.Forms.DateTimePicker();
            this.LB_Ausbildungsstart = new System.Windows.Forms.Label();
            this.LB_Ausbildungsende = new System.Windows.Forms.Label();
            this.CB_Kalenderwoche = new System.Windows.Forms.ComboBox();
            this.LB_Kalenderwoche = new System.Windows.Forms.Label();
            this.LV_Task = new System.Windows.Forms.ListView();
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            this.DTP_Ausbildungsstart.Location = new System.Drawing.Point(10, 28);
            this.DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            this.DTP_Ausbildungsstart.Size = new System.Drawing.Size(200, 20);
            this.DTP_Ausbildungsstart.TabIndex = 0;
            this.DTP_Ausbildungsstart.ValueChanged += new System.EventHandler(this.DTP_Ausbildungsstart_ValueChanged);
            // 
            // DTP_Ausbildungsende
            // 
            this.DTP_Ausbildungsende.Location = new System.Drawing.Point(10, 78);
            this.DTP_Ausbildungsende.Name = "DTP_Ausbildungsende";
            this.DTP_Ausbildungsende.Size = new System.Drawing.Size(200, 20);
            this.DTP_Ausbildungsende.TabIndex = 1;
            this.DTP_Ausbildungsende.ValueChanged += new System.EventHandler(this.DTP_Ausbildungsende_ValueChanged);
            // 
            // LB_Ausbildungsstart
            // 
            this.LB_Ausbildungsstart.AutoSize = true;
            this.LB_Ausbildungsstart.Location = new System.Drawing.Point(10, 9);
            this.LB_Ausbildungsstart.Name = "LB_Ausbildungsstart";
            this.LB_Ausbildungsstart.Size = new System.Drawing.Size(84, 13);
            this.LB_Ausbildungsstart.TabIndex = 2;
            this.LB_Ausbildungsstart.Text = "Ausbildungsstart";
            // 
            // LB_Ausbildungsende
            // 
            this.LB_Ausbildungsende.AutoSize = true;
            this.LB_Ausbildungsende.Location = new System.Drawing.Point(10, 59);
            this.LB_Ausbildungsende.Name = "LB_Ausbildungsende";
            this.LB_Ausbildungsende.Size = new System.Drawing.Size(88, 13);
            this.LB_Ausbildungsende.TabIndex = 3;
            this.LB_Ausbildungsende.Text = "Ausbildungsende";
            // 
            // CB_Kalenderwoche
            // 
            this.CB_Kalenderwoche.FormattingEnabled = true;
            this.CB_Kalenderwoche.Location = new System.Drawing.Point(10, 121);
            this.CB_Kalenderwoche.Name = "CB_Kalenderwoche";
            this.CB_Kalenderwoche.Size = new System.Drawing.Size(200, 21);
            this.CB_Kalenderwoche.TabIndex = 4;
            this.CB_Kalenderwoche.SelectedIndexChanged += new System.EventHandler(this.CB_Kalenderwoche_SelectedIndexChanged);
            // 
            // LB_Kalenderwoche
            // 
            this.LB_Kalenderwoche.AutoSize = true;
            this.LB_Kalenderwoche.Location = new System.Drawing.Point(13, 105);
            this.LB_Kalenderwoche.Name = "LB_Kalenderwoche";
            this.LB_Kalenderwoche.Size = new System.Drawing.Size(87, 13);
            this.LB_Kalenderwoche.TabIndex = 5;
            this.LB_Kalenderwoche.Text = "Kalender Woche";
            // 
            // LV_Task
            // 
            this.LV_Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV_Task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task,
            this.Duration});
            this.LV_Task.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Task.HideSelection = false;
            this.LV_Task.Location = new System.Drawing.Point(258, 21);
            this.LV_Task.Name = "LV_Task";
            this.LV_Task.ShowGroups = false;
            this.LV_Task.Size = new System.Drawing.Size(520, 322);
            this.LV_Task.TabIndex = 6;
            this.LV_Task.UseCompatibleStateImageBehavior = false;
            this.LV_Task.View = System.Windows.Forms.View.Details;
            this.LV_Task.SelectedIndexChanged += new System.EventHandler(this.LV_Task_SelectedIndexChanged);
            // 
            // Task
            // 
            this.Task.Text = "Tätigkeit";
            this.Task.Width = 200;
            // 
            // Duration
            // 
            this.Duration.Text = "Dauer";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(258, 349);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 7;
            this.BTN_Add.Text = "Hinzufügen";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(703, 349);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(75, 23);
            this.BTN_Remove.TabIndex = 8;
            this.BTN_Remove.Text = "Entfernen";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.LV_Task);
            this.Controls.Add(this.LB_Kalenderwoche);
            this.Controls.Add(this.CB_Kalenderwoche);
            this.Controls.Add(this.LB_Ausbildungsende);
            this.Controls.Add(this.LB_Ausbildungsstart);
            this.Controls.Add(this.DTP_Ausbildungsende);
            this.Controls.Add(this.DTP_Ausbildungsstart);
            this.Name = "MainForm";
            this.Text = "Berichtsheft Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

