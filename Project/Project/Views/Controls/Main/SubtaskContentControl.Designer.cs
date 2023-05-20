﻿
namespace Project.Controls
{
    partial class SubtaskContentControl
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
            this.components = new System.ComponentModel.Container();
            this.labelAssignedTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.textBoxSubtaskDescription = new System.Windows.Forms.TextBox();
            this.labelSubtaskName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssignedTo
            // 
            this.labelAssignedTo.AutoSize = true;
            this.labelAssignedTo.Location = new System.Drawing.Point(521, 190);
            this.labelAssignedTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssignedTo.Name = "labelAssignedTo";
            this.labelAssignedTo.Size = new System.Drawing.Size(161, 13);
            this.labelAssignedTo.TabIndex = 17;
            this.labelAssignedTo.Text = "Assigned To - <employee name>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Comments";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(583, 422);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(99, 31);
            this.buttonAddComment.TabIndex = 15;
            this.buttonAddComment.Text = "Add Comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(15, 263);
            this.dataGridViewComments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersWidth = 51;
            this.dataGridViewComments.RowTemplate.Height = 24;
            this.dataGridViewComments.Size = new System.Drawing.Size(667, 137);
            this.dataGridViewComments.TabIndex = 14;
            // 
            // textBoxSubtaskDescription
            // 
            this.textBoxSubtaskDescription.Location = new System.Drawing.Point(15, 96);
            this.textBoxSubtaskDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSubtaskDescription.Multiline = true;
            this.textBoxSubtaskDescription.Name = "textBoxSubtaskDescription";
            this.textBoxSubtaskDescription.ReadOnly = true;
            this.textBoxSubtaskDescription.Size = new System.Drawing.Size(667, 78);
            this.textBoxSubtaskDescription.TabIndex = 13;
            this.textBoxSubtaskDescription.Text = "subtask description........";
            // 
            // labelSubtaskName
            // 
            this.labelSubtaskName.AutoSize = true;
            this.labelSubtaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtaskName.Location = new System.Drawing.Point(9, 8);
            this.labelSubtaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtaskName.Name = "labelSubtaskName";
            this.labelSubtaskName.Size = new System.Drawing.Size(279, 31);
            this.labelSubtaskName.TabIndex = 12;
            this.labelSubtaskName.Text = "Subtask <task-name>";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 60);
            this.button2.TabIndex = 21;
            this.button2.Text = "toSubtask";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "toDo",
            "inProgress",
            "done"});
            this.comboBoxStatus.Location = new System.Drawing.Point(606, 53);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(76, 21);
            this.comboBoxStatus.TabIndex = 23;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(606, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 29);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(524, 10);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 29);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // SubtaskContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelAssignedTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.dataGridViewComments);
            this.Controls.Add(this.textBoxSubtaskDescription);
            this.Controls.Add(this.labelSubtaskName);
            this.Controls.Add(this.button2);
            this.Name = "SubtaskContentControl";
            this.Size = new System.Drawing.Size(700, 477);
            this.Load += new System.EventHandler(this.SubtaskContentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAssignedTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.TextBox textBoxSubtaskDescription;
        private System.Windows.Forms.Label labelSubtaskName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
