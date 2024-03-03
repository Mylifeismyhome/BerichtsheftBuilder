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
            BTN_Save = new System.Windows.Forms.Button();
            LB_Ausbildungsabteilung = new System.Windows.Forms.Label();
            TB_Ausbildungsabteilung = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // DTP_Ausbildungsstart
            // 
            DTP_Ausbildungsstart.Location = new System.Drawing.Point(156, 87);
            DTP_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsstart.Name = "DTP_Ausbildungsstart";
            DTP_Ausbildungsstart.Size = new System.Drawing.Size(279, 23);
            DTP_Ausbildungsstart.TabIndex = 0;
            // 
            // DTP_Ausbildungsende
            // 
            DTP_Ausbildungsende.Location = new System.Drawing.Point(156, 121);
            DTP_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTP_Ausbildungsende.Name = "DTP_Ausbildungsende";
            DTP_Ausbildungsende.Size = new System.Drawing.Size(279, 23);
            DTP_Ausbildungsende.TabIndex = 1;
            // 
            // LB_Ausbildungsstart
            // 
            LB_Ausbildungsstart.AutoSize = true;
            LB_Ausbildungsstart.Location = new System.Drawing.Point(14, 91);
            LB_Ausbildungsstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsstart.Name = "LB_Ausbildungsstart";
            LB_Ausbildungsstart.Size = new System.Drawing.Size(99, 15);
            LB_Ausbildungsstart.TabIndex = 2;
            LB_Ausbildungsstart.Text = "Ausbildungsstart:";
            // 
            // LB_Ausbildungsende
            // 
            LB_Ausbildungsende.AutoSize = true;
            LB_Ausbildungsende.Location = new System.Drawing.Point(14, 125);
            LB_Ausbildungsende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsende.Name = "LB_Ausbildungsende";
            LB_Ausbildungsende.Size = new System.Drawing.Size(102, 15);
            LB_Ausbildungsende.TabIndex = 3;
            LB_Ausbildungsende.Text = "Ausbildungsende:";
            // 
            // LB_AuszubildenderName
            // 
            LB_AuszubildenderName.AutoSize = true;
            LB_AuszubildenderName.Location = new System.Drawing.Point(14, 30);
            LB_AuszubildenderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_AuszubildenderName.Name = "LB_AuszubildenderName";
            LB_AuszubildenderName.Size = new System.Drawing.Size(42, 15);
            LB_AuszubildenderName.TabIndex = 4;
            LB_AuszubildenderName.Text = "Name:";
            // 
            // TB_AuszubildenderName
            // 
            TB_AuszubildenderName.Location = new System.Drawing.Point(156, 27);
            TB_AuszubildenderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_AuszubildenderName.Name = "TB_AuszubildenderName";
            TB_AuszubildenderName.Size = new System.Drawing.Size(279, 23);
            TB_AuszubildenderName.TabIndex = 5;
            // 
            // TB_AusbilderName
            // 
            TB_AusbilderName.Location = new System.Drawing.Point(156, 57);
            TB_AusbilderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_AusbilderName.Name = "TB_AusbilderName";
            TB_AusbilderName.Size = new System.Drawing.Size(279, 23);
            TB_AusbilderName.TabIndex = 6;
            // 
            // LB_AusbilderName
            // 
            LB_AusbilderName.AutoSize = true;
            LB_AusbilderName.Location = new System.Drawing.Point(14, 60);
            LB_AusbilderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_AusbilderName.Name = "LB_AusbilderName";
            LB_AusbilderName.Size = new System.Drawing.Size(95, 15);
            LB_AusbilderName.TabIndex = 7;
            LB_AusbilderName.Text = "Ausbilder Name:";
            // 
            // BTN_Save
            // 
            BTN_Save.Location = new System.Drawing.Point(12, 252);
            BTN_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Save.Name = "BTN_Save";
            BTN_Save.Size = new System.Drawing.Size(423, 47);
            BTN_Save.TabIndex = 8;
            BTN_Save.Text = "Speichern";
            BTN_Save.UseVisualStyleBackColor = true;
            BTN_Save.Click += BTN_Save_Click;
            // 
            // LB_Ausbildungsabteilung
            // 
            LB_Ausbildungsabteilung.AutoSize = true;
            LB_Ausbildungsabteilung.Location = new System.Drawing.Point(12, 159);
            LB_Ausbildungsabteilung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Ausbildungsabteilung.Name = "LB_Ausbildungsabteilung";
            LB_Ausbildungsabteilung.Size = new System.Drawing.Size(126, 15);
            LB_Ausbildungsabteilung.TabIndex = 9;
            LB_Ausbildungsabteilung.Text = "Ausbildungsabteilung:";
            // 
            // TB_Ausbildungsabteilung
            // 
            TB_Ausbildungsabteilung.Location = new System.Drawing.Point(156, 155);
            TB_Ausbildungsabteilung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Ausbildungsabteilung.Name = "TB_Ausbildungsabteilung";
            TB_Ausbildungsabteilung.Size = new System.Drawing.Size(279, 23);
            TB_Ausbildungsabteilung.TabIndex = 10;
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 311);
            Controls.Add(TB_Ausbildungsabteilung);
            Controls.Add(LB_Ausbildungsabteilung);
            Controls.Add(BTN_Save);
            Controls.Add(LB_AusbilderName);
            Controls.Add(TB_AusbilderName);
            Controls.Add(TB_AuszubildenderName);
            Controls.Add(LB_AuszubildenderName);
            Controls.Add(LB_Ausbildungsende);
            Controls.Add(LB_Ausbildungsstart);
            Controls.Add(DTP_Ausbildungsende);
            Controls.Add(DTP_Ausbildungsstart);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Label LB_Ausbildungsabteilung;
        private System.Windows.Forms.TextBox TB_Ausbildungsabteilung;
    }
}