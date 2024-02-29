namespace BerichtsheftBuilder.Form
{
    partial class AddTaskForm
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
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.LB_HOUR = new System.Windows.Forms.Label();
            this.ND_HOUR = new System.Windows.Forms.NumericUpDown();
            this.ND_MINUTE = new System.Windows.Forms.NumericUpDown();
            this.LB_MINUTE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ND_HOUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ND_MINUTE)).BeginInit();
            this.SuspendLayout();
            // 
            // RTB_Description
            // 
            this.RTB_Description.Location = new System.Drawing.Point(12, 12);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(410, 120);
            this.RTB_Description.TabIndex = 0;
            this.RTB_Description.Text = "";
            // 
            // BTN_Add
            // 
            this.BTN_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Add.Location = new System.Drawing.Point(12, 218);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(410, 46);
            this.BTN_Add.TabIndex = 1;
            this.BTN_Add.Text = "Zu Aufgaben Hinzufügen";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // LB_HOUR
            // 
            this.LB_HOUR.AutoSize = true;
            this.LB_HOUR.Location = new System.Drawing.Point(89, 155);
            this.LB_HOUR.Name = "LB_HOUR";
            this.LB_HOUR.Size = new System.Drawing.Size(53, 13);
            this.LB_HOUR.TabIndex = 2;
            this.LB_HOUR.Text = "Stunde(n)";
            // 
            // ND_HOUR
            // 
            this.ND_HOUR.Location = new System.Drawing.Point(92, 173);
            this.ND_HOUR.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ND_HOUR.Name = "ND_HOUR";
            this.ND_HOUR.Size = new System.Drawing.Size(120, 20);
            this.ND_HOUR.TabIndex = 3;
            // 
            // ND_MINUTE
            // 
            this.ND_MINUTE.Location = new System.Drawing.Point(238, 173);
            this.ND_MINUTE.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ND_MINUTE.Name = "ND_MINUTE";
            this.ND_MINUTE.Size = new System.Drawing.Size(120, 20);
            this.ND_MINUTE.TabIndex = 4;
            // 
            // LB_MINUTE
            // 
            this.LB_MINUTE.AutoSize = true;
            this.LB_MINUTE.Location = new System.Drawing.Point(235, 153);
            this.LB_MINUTE.Name = "LB_MINUTE";
            this.LB_MINUTE.Size = new System.Drawing.Size(51, 13);
            this.LB_MINUTE.TabIndex = 5;
            this.LB_MINUTE.Text = "Minute(n)";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 275);
            this.Controls.Add(this.LB_MINUTE);
            this.Controls.Add(this.ND_MINUTE);
            this.Controls.Add(this.ND_HOUR);
            this.Controls.Add(this.LB_HOUR);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.RTB_Description);
            this.Name = "AddTaskForm";
            this.Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)(this.ND_HOUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ND_MINUTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label LB_HOUR;
        private System.Windows.Forms.NumericUpDown ND_HOUR;
        private System.Windows.Forms.NumericUpDown ND_MINUTE;
        private System.Windows.Forms.Label LB_MINUTE;
    }
}