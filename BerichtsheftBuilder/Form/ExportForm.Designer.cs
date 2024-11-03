namespace BerichtsheftBuilder.Forms
{
    partial class ExportForm
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
            BTN_Export = new System.Windows.Forms.Button();
            LB_Kalenderwoche = new System.Windows.Forms.Label();
            CB_Kalenderwoche = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            TB_Export_Name = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // BTN_Export
            // 
            BTN_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Export.Location = new System.Drawing.Point(12, 249);
            BTN_Export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Export.Name = "BTN_Export";
            BTN_Export.Size = new System.Drawing.Size(460, 54);
            BTN_Export.TabIndex = 8;
            BTN_Export.Text = "Exportieren";
            BTN_Export.UseVisualStyleBackColor = true;
            BTN_Export.Click += BTN_Export_Click;
            // 
            // LB_Kalenderwoche
            // 
            LB_Kalenderwoche.AutoSize = true;
            LB_Kalenderwoche.Location = new System.Drawing.Point(13, 58);
            LB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LB_Kalenderwoche.Name = "LB_Kalenderwoche";
            LB_Kalenderwoche.Size = new System.Drawing.Size(120, 16);
            LB_Kalenderwoche.TabIndex = 10;
            LB_Kalenderwoche.Text = "bis Kalender Woche";
            // 
            // CB_Kalenderwoche
            // 
            CB_Kalenderwoche.Cursor = System.Windows.Forms.Cursors.Hand;
            CB_Kalenderwoche.FormattingEnabled = true;
            CB_Kalenderwoche.Location = new System.Drawing.Point(13, 82);
            CB_Kalenderwoche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CB_Kalenderwoche.Name = "CB_Kalenderwoche";
            CB_Kalenderwoche.Size = new System.Drawing.Size(460, 24);
            CB_Kalenderwoche.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 123);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 16);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // TB_Export_Name
            // 
            TB_Export_Name.Location = new System.Drawing.Point(12, 142);
            TB_Export_Name.Name = "TB_Export_Name";
            TB_Export_Name.Size = new System.Drawing.Size(461, 23);
            TB_Export_Name.TabIndex = 12;
            TB_Export_Name.Text = "output.pdf";
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 311);
            Controls.Add(TB_Export_Name);
            Controls.Add(label1);
            Controls.Add(LB_Kalenderwoche);
            Controls.Add(CB_Kalenderwoche);
            Controls.Add(BTN_Export);
            Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ExportForm";
            Text = "Export";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BTN_Export;
        private System.Windows.Forms.Label LB_Kalenderwoche;
        private System.Windows.Forms.ComboBox CB_Kalenderwoche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Export_Name;
    }
}