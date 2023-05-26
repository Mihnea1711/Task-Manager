namespace View
{
    partial class AskForDeadlineDialogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmit.Location = new System.Drawing.Point(117, 163);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Ok";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(101, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(140, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Enter Deadline";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeadline.Location = new System.Drawing.Point(43, 72);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(75, 20);
            this.labelDeadline.TabIndex = 3;
            this.labelDeadline.Text = "Deadline";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(47, 95);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerDeadline.TabIndex = 4;
            // 
            // AskForDeadlineDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "AskForDeadlineDialogControl";
            this.Size = new System.Drawing.Size(353, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
    }
}
