
namespace View
{
    partial class AddCommentDialogControl
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
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.labelAddCommentHeader = new System.Windows.Forms.Label();
            this.labelAddCommentDescription = new System.Windows.Forms.Label();
            this.labelAddCommentTitle = new System.Windows.Forms.Label();
            this.textBoxCommentDesc = new System.Windows.Forms.TextBox();
            this.textBoxCommentTitle = new System.Windows.Forms.TextBox();
            this.labelReportedTime = new System.Windows.Forms.Label();
            this.textBoxReportedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComment.Location = new System.Drawing.Point(400, 399);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(165, 43);
            this.buttonAddComment.TabIndex = 31;
            this.buttonAddComment.Text = "Add Comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            // 
            // labelAddCommentHeader
            // 
            this.labelAddCommentHeader.AutoSize = true;
            this.labelAddCommentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCommentHeader.Location = new System.Drawing.Point(214, 19);
            this.labelAddCommentHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddCommentHeader.Name = "labelAddCommentHeader";
            this.labelAddCommentHeader.Size = new System.Drawing.Size(238, 26);
            this.labelAddCommentHeader.TabIndex = 30;
            this.labelAddCommentHeader.Text = "Create a new comment";
            // 
            // labelAddCommentDescription
            // 
            this.labelAddCommentDescription.AutoSize = true;
            this.labelAddCommentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCommentDescription.Location = new System.Drawing.Point(61, 161);
            this.labelAddCommentDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddCommentDescription.Name = "labelAddCommentDescription";
            this.labelAddCommentDescription.Size = new System.Drawing.Size(79, 34);
            this.labelAddCommentDescription.TabIndex = 27;
            this.labelAddCommentDescription.Text = "Comment \r\nDescription";
            // 
            // labelAddCommentTitle
            // 
            this.labelAddCommentTitle.AutoSize = true;
            this.labelAddCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCommentTitle.Location = new System.Drawing.Point(40, 103);
            this.labelAddCommentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddCommentTitle.Name = "labelAddCommentTitle";
            this.labelAddCommentTitle.Size = new System.Drawing.Size(98, 17);
            this.labelAddCommentTitle.TabIndex = 26;
            this.labelAddCommentTitle.Text = "Comment Title";
            // 
            // textBoxCommentDesc
            // 
            this.textBoxCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommentDesc.Location = new System.Drawing.Point(175, 161);
            this.textBoxCommentDesc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommentDesc.Multiline = true;
            this.textBoxCommentDesc.Name = "textBoxCommentDesc";
            this.textBoxCommentDesc.Size = new System.Drawing.Size(390, 182);
            this.textBoxCommentDesc.TabIndex = 24;
            // 
            // textBoxCommentTitle
            // 
            this.textBoxCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommentTitle.Location = new System.Drawing.Point(175, 100);
            this.textBoxCommentTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommentTitle.Name = "textBoxCommentTitle";
            this.textBoxCommentTitle.Size = new System.Drawing.Size(390, 23);
            this.textBoxCommentTitle.TabIndex = 23;
            // 
            // labelReportedTime
            // 
            this.labelReportedTime.AutoSize = true;
            this.labelReportedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportedTime.Location = new System.Drawing.Point(40, 402);
            this.labelReportedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReportedTime.Name = "labelReportedTime";
            this.labelReportedTime.Size = new System.Drawing.Size(109, 17);
            this.labelReportedTime.TabIndex = 33;
            this.labelReportedTime.Text = "Reported Hours";
            // 
            // textBoxReportedTime
            // 
            this.textBoxReportedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReportedTime.Location = new System.Drawing.Point(175, 399);
            this.textBoxReportedTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReportedTime.Name = "textBoxReportedTime";
            this.textBoxReportedTime.Size = new System.Drawing.Size(90, 23);
            this.textBoxReportedTime.TabIndex = 32;
            // 
            // AddCommentDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelReportedTime);
            this.Controls.Add(this.textBoxReportedTime);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.labelAddCommentHeader);
            this.Controls.Add(this.labelAddCommentDescription);
            this.Controls.Add(this.labelAddCommentTitle);
            this.Controls.Add(this.textBoxCommentDesc);
            this.Controls.Add(this.textBoxCommentTitle);
            this.Name = "AddCommentDialogControl";
            this.Size = new System.Drawing.Size(657, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Label labelAddCommentHeader;
        private System.Windows.Forms.Label labelAddCommentDescription;
        private System.Windows.Forms.Label labelAddCommentTitle;
        private System.Windows.Forms.TextBox textBoxCommentDesc;
        private System.Windows.Forms.TextBox textBoxCommentTitle;
        private System.Windows.Forms.Label labelReportedTime;
        private System.Windows.Forms.TextBox textBoxReportedTime;
    }
}
