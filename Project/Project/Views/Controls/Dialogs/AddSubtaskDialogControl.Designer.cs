
namespace Project.Controls
{
    partial class AddSubtaskDialogControl
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
            this.buttonAddSubtask = new System.Windows.Forms.Button();
            this.labelAddSubtaskHeader = new System.Windows.Forms.Label();
            this.comboBoxAssign = new System.Windows.Forms.ComboBox();
            this.labelAddTaskAssignTo = new System.Windows.Forms.Label();
            this.labelAddSubtaskDescription = new System.Windows.Forms.Label();
            this.labelAddSubtaskName = new System.Windows.Forms.Label();
            this.buttonAssignToMe = new System.Windows.Forms.Button();
            this.textBoxSubtaskDesc = new System.Windows.Forms.TextBox();
            this.textBoxSubtaskName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddSubtask
            // 
            this.buttonAddSubtask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddSubtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubtask.Location = new System.Drawing.Point(560, 584);
            this.buttonAddSubtask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAddSubtask.Name = "buttonAddSubtask";
            this.buttonAddSubtask.Size = new System.Drawing.Size(220, 53);
            this.buttonAddSubtask.TabIndex = 22;
            this.buttonAddSubtask.Text = "Create Subtask";
            this.buttonAddSubtask.UseVisualStyleBackColor = true;
            this.buttonAddSubtask.Click += new System.EventHandler(this.buttonAddSubtask_Click);
            // 
            // labelAddSubtaskHeader
            // 
            this.labelAddSubtaskHeader.AutoSize = true;
            this.labelAddSubtaskHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskHeader.Location = new System.Drawing.Point(268, 28);
            this.labelAddSubtaskHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddSubtaskHeader.Name = "labelAddSubtaskHeader";
            this.labelAddSubtaskHeader.Size = new System.Drawing.Size(277, 31);
            this.labelAddSubtaskHeader.TabIndex = 21;
            this.labelAddSubtaskHeader.Text = "Create a new subtask";
            // 
            // comboBoxAssign
            // 
            this.comboBoxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAssign.FormattingEnabled = true;
            this.comboBoxAssign.Location = new System.Drawing.Point(260, 475);
            this.comboBoxAssign.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxAssign.Name = "comboBoxAssign";
            this.comboBoxAssign.Size = new System.Drawing.Size(284, 28);
            this.comboBoxAssign.TabIndex = 20;
            // 
            // labelAddTaskAssignTo
            // 
            this.labelAddTaskAssignTo.AutoSize = true;
            this.labelAddTaskAssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTaskAssignTo.Location = new System.Drawing.Point(119, 475);
            this.labelAddTaskAssignTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddTaskAssignTo.Name = "labelAddTaskAssignTo";
            this.labelAddTaskAssignTo.Size = new System.Drawing.Size(84, 20);
            this.labelAddTaskAssignTo.TabIndex = 18;
            this.labelAddTaskAssignTo.Text = "Assign To";
            // 
            // labelAddSubtaskDescription
            // 
            this.labelAddSubtaskDescription.AutoSize = true;
            this.labelAddSubtaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskDescription.Location = new System.Drawing.Point(108, 207);
            this.labelAddSubtaskDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddSubtaskDescription.Name = "labelAddSubtaskDescription";
            this.labelAddSubtaskDescription.Size = new System.Drawing.Size(95, 40);
            this.labelAddSubtaskDescription.TabIndex = 17;
            this.labelAddSubtaskDescription.Text = "Subtask \r\nDescription";
            // 
            // labelAddSubtaskName
            // 
            this.labelAddSubtaskName.AutoSize = true;
            this.labelAddSubtaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskName.Location = new System.Drawing.Point(80, 135);
            this.labelAddSubtaskName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddSubtaskName.Name = "labelAddSubtaskName";
            this.labelAddSubtaskName.Size = new System.Drawing.Size(118, 20);
            this.labelAddSubtaskName.TabIndex = 16;
            this.labelAddSubtaskName.Text = "Subtask Name";
            // 
            // buttonAssignToMe
            // 
            this.buttonAssignToMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignToMe.Location = new System.Drawing.Point(583, 475);
            this.buttonAssignToMe.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAssignToMe.Name = "buttonAssignToMe";
            this.buttonAssignToMe.Size = new System.Drawing.Size(197, 34);
            this.buttonAssignToMe.TabIndex = 15;
            this.buttonAssignToMe.Text = "Assign To Me";
            this.buttonAssignToMe.UseVisualStyleBackColor = true;
            // 
            // textBoxSubtaskDesc
            // 
            this.textBoxSubtaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtaskDesc.Location = new System.Drawing.Point(260, 207);
            this.textBoxSubtaskDesc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxSubtaskDesc.Multiline = true;
            this.textBoxSubtaskDesc.Name = "textBoxSubtaskDesc";
            this.textBoxSubtaskDesc.Size = new System.Drawing.Size(519, 223);
            this.textBoxSubtaskDesc.TabIndex = 14;
            // 
            // textBoxSubtaskName
            // 
            this.textBoxSubtaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtaskName.Location = new System.Drawing.Point(260, 132);
            this.textBoxSubtaskName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxSubtaskName.Name = "textBoxSubtaskName";
            this.textBoxSubtaskName.Size = new System.Drawing.Size(519, 26);
            this.textBoxSubtaskName.TabIndex = 13;
            // 
            // AddSubtaskDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSubtask);
            this.Controls.Add(this.labelAddSubtaskHeader);
            this.Controls.Add(this.comboBoxAssign);
            this.Controls.Add(this.labelAddTaskAssignTo);
            this.Controls.Add(this.labelAddSubtaskDescription);
            this.Controls.Add(this.labelAddSubtaskName);
            this.Controls.Add(this.buttonAssignToMe);
            this.Controls.Add(this.textBoxSubtaskDesc);
            this.Controls.Add(this.textBoxSubtaskName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSubtaskDialogControl";
            this.Size = new System.Drawing.Size(872, 668);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddSubtask;
        private System.Windows.Forms.Label labelAddSubtaskHeader;
        private System.Windows.Forms.ComboBox comboBoxAssign;
        private System.Windows.Forms.Label labelAddTaskAssignTo;
        private System.Windows.Forms.Label labelAddSubtaskDescription;
        private System.Windows.Forms.Label labelAddSubtaskName;
        private System.Windows.Forms.Button buttonAssignToMe;
        private System.Windows.Forms.TextBox textBoxSubtaskDesc;
        private System.Windows.Forms.TextBox textBoxSubtaskName;
    }
}
