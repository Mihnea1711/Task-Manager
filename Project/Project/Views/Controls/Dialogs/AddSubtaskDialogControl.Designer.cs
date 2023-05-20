
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
            this.labelAddSubtaskDescription = new System.Windows.Forms.Label();
            this.labelAddSubtaskName = new System.Windows.Forms.Label();
            this.textBoxSubtaskDesc = new System.Windows.Forms.TextBox();
            this.textBoxSubtaskName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddSubtask
            // 
            this.buttonAddSubtask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddSubtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubtask.Location = new System.Drawing.Point(420, 388);
            this.buttonAddSubtask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSubtask.Name = "buttonAddSubtask";
            this.buttonAddSubtask.Size = new System.Drawing.Size(165, 43);
            this.buttonAddSubtask.TabIndex = 22;
            this.buttonAddSubtask.Text = "Create Subtask";
            this.buttonAddSubtask.UseVisualStyleBackColor = true;
            // 
            // labelAddSubtaskHeader
            // 
            this.labelAddSubtaskHeader.AutoSize = true;
            this.labelAddSubtaskHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskHeader.Location = new System.Drawing.Point(201, 23);
            this.labelAddSubtaskHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddSubtaskHeader.Name = "labelAddSubtaskHeader";
            this.labelAddSubtaskHeader.Size = new System.Drawing.Size(222, 26);
            this.labelAddSubtaskHeader.TabIndex = 21;
            this.labelAddSubtaskHeader.Text = "Create a new subtask";
            // 
            // labelAddSubtaskDescription
            // 
            this.labelAddSubtaskDescription.AutoSize = true;
            this.labelAddSubtaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskDescription.Location = new System.Drawing.Point(81, 168);
            this.labelAddSubtaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddSubtaskDescription.Name = "labelAddSubtaskDescription";
            this.labelAddSubtaskDescription.Size = new System.Drawing.Size(79, 34);
            this.labelAddSubtaskDescription.TabIndex = 17;
            this.labelAddSubtaskDescription.Text = "Subtask \r\nDescription";
            // 
            // labelAddSubtaskName
            // 
            this.labelAddSubtaskName.AutoSize = true;
            this.labelAddSubtaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubtaskName.Location = new System.Drawing.Point(60, 110);
            this.labelAddSubtaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddSubtaskName.Name = "labelAddSubtaskName";
            this.labelAddSubtaskName.Size = new System.Drawing.Size(100, 17);
            this.labelAddSubtaskName.TabIndex = 16;
            this.labelAddSubtaskName.Text = "Subtask Name";
            // 
            // textBoxSubtaskDesc
            // 
            this.textBoxSubtaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtaskDesc.Location = new System.Drawing.Point(195, 168);
            this.textBoxSubtaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubtaskDesc.Multiline = true;
            this.textBoxSubtaskDesc.Name = "textBoxSubtaskDesc";
            this.textBoxSubtaskDesc.Size = new System.Drawing.Size(390, 182);
            this.textBoxSubtaskDesc.TabIndex = 14;
            // 
            // textBoxSubtaskName
            // 
            this.textBoxSubtaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtaskName.Location = new System.Drawing.Point(195, 107);
            this.textBoxSubtaskName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubtaskName.Name = "textBoxSubtaskName";
            this.textBoxSubtaskName.Size = new System.Drawing.Size(390, 23);
            this.textBoxSubtaskName.TabIndex = 13;
            // 
            // AddSubtaskDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSubtask);
            this.Controls.Add(this.labelAddSubtaskHeader);
            this.Controls.Add(this.labelAddSubtaskDescription);
            this.Controls.Add(this.labelAddSubtaskName);
            this.Controls.Add(this.textBoxSubtaskDesc);
            this.Controls.Add(this.textBoxSubtaskName);
            this.Name = "AddSubtaskDialogControl";
            this.Size = new System.Drawing.Size(664, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddSubtask;
        private System.Windows.Forms.Label labelAddSubtaskHeader;
        private System.Windows.Forms.Label labelAddSubtaskDescription;
        private System.Windows.Forms.Label labelAddSubtaskName;
        private System.Windows.Forms.TextBox textBoxSubtaskDesc;
        private System.Windows.Forms.TextBox textBoxSubtaskName;
    }
}
