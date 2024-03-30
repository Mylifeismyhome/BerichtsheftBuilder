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
            RTB_Description = new System.Windows.Forms.RichTextBox();
            BTN_Add = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // RTB_Description
            // 
            RTB_Description.Location = new System.Drawing.Point(14, 14);
            RTB_Description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RTB_Description.Name = "RTB_Description";
            RTB_Description.Size = new System.Drawing.Size(478, 138);
            RTB_Description.TabIndex = 0;
            RTB_Description.Text = "";
            // 
            // BTN_Add
            // 
            BTN_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            BTN_Add.Location = new System.Drawing.Point(14, 252);
            BTN_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Add.Name = "BTN_Add";
            BTN_Add.Size = new System.Drawing.Size(478, 53);
            BTN_Add.TabIndex = 1;
            BTN_Add.Text = "Zu Aufgaben Hinzufügen";
            BTN_Add.UseVisualStyleBackColor = true;
            BTN_Add.Click += BTN_Add_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 317);
            Controls.Add(BTN_Add);
            Controls.Add(RTB_Description);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddTaskForm";
            Text = "AddTask";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Button BTN_Add;
    }
}