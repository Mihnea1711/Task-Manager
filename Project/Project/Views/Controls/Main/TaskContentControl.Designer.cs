﻿namespace Project.Controls
{
    partial class TaskContentControl
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewSubtasks = new System.Windows.Forms.DataGridView();
            this.buttonAddSubtask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAssignedEmployee = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.progressBarProgress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAssignToMe = new System.Windows.Forms.Button();
            this.buttonUnassign = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtasks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 22);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(240, 31);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Task <task-name>";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(14, 115);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(667, 77);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Text = "task description........";
            // 
            // dataGridViewSubtasks
            // 
            this.dataGridViewSubtasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubtasks.Location = new System.Drawing.Point(14, 280);
            this.dataGridViewSubtasks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSubtasks.Name = "dataGridViewSubtasks";
            this.dataGridViewSubtasks.RowHeadersWidth = 51;
            this.dataGridViewSubtasks.RowTemplate.Height = 24;
            this.dataGridViewSubtasks.Size = new System.Drawing.Size(667, 137);
            this.dataGridViewSubtasks.TabIndex = 4;
            this.dataGridViewSubtasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubtasks_CellClick);
            // 
            // buttonAddSubtask
            // 
            this.buttonAddSubtask.Location = new System.Drawing.Point(575, 429);
            this.buttonAddSubtask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSubtask.Name = "buttonAddSubtask";
            this.buttonAddSubtask.Size = new System.Drawing.Size(106, 31);
            this.buttonAddSubtask.TabIndex = 5;
            this.buttonAddSubtask.Text = "Add Subtask";
            this.buttonAddSubtask.UseVisualStyleBackColor = true;
            this.buttonAddSubtask.Click += new System.EventHandler(this.buttonAddSubtask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtasks";
            // 
            // labelAssignedEmployee
            // 
            this.labelAssignedEmployee.AutoSize = true;
            this.labelAssignedEmployee.Location = new System.Drawing.Point(520, 194);
            this.labelAssignedEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssignedEmployee.Name = "labelAssignedEmployee";
            this.labelAssignedEmployee.Size = new System.Drawing.Size(161, 13);
            this.labelAssignedEmployee.TabIndex = 7;
            this.labelAssignedEmployee.Text = "Assigned To - <employee name>";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(11, 78);
            this.labelDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(87, 13);
            this.labelDeadline.TabIndex = 8;
            this.labelDeadline.Text = "Time left - hh:mm";
            // 
            // progressBarProgress
            // 
            this.progressBarProgress.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarProgress.Location = new System.Drawing.Point(272, 31);
            this.progressBarProgress.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarProgress.Name = "progressBarProgress";
            this.progressBarProgress.Size = new System.Drawing.Size(75, 19);
            this.progressBarProgress.TabIndex = 9;
            this.progressBarProgress.Value = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // buttonAssignToMe
            // 
            this.buttonAssignToMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignToMe.Location = new System.Drawing.Point(505, 210);
            this.buttonAssignToMe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAssignToMe.Name = "buttonAssignToMe";
            this.buttonAssignToMe.Size = new System.Drawing.Size(85, 24);
            this.buttonAssignToMe.TabIndex = 12;
            this.buttonAssignToMe.Text = "Assign To Me";
            this.buttonAssignToMe.UseVisualStyleBackColor = true;
            this.buttonAssignToMe.Visible = false;
            this.buttonAssignToMe.Click += new System.EventHandler(this.buttonAssignToMe_Click);
            // 
            // buttonUnassign
            // 
            this.buttonUnassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnassign.Location = new System.Drawing.Point(594, 210);
            this.buttonUnassign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnassign.Name = "buttonUnassign";
            this.buttonUnassign.Size = new System.Drawing.Size(85, 24);
            this.buttonUnassign.TabIndex = 13;
            this.buttonUnassign.Text = "Unassign";
            this.buttonUnassign.UseVisualStyleBackColor = true;
            this.buttonUnassign.Visible = false;
            this.buttonUnassign.Click += new System.EventHandler(this.buttonUnassign_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(522, 20);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 29);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(604, 20);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 29);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TaskContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonUnassign);
            this.Controls.Add(this.buttonAssignToMe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarProgress);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelAssignedEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddSubtask);
            this.Controls.Add(this.dataGridViewSubtasks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskContentControl";
            this.Size = new System.Drawing.Size(700, 471);
            this.Load += new System.EventHandler(this.TaskContentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridViewSubtasks;
        private System.Windows.Forms.Button buttonAddSubtask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAssignedEmployee;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.ProgressBar progressBarProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAssignToMe;
        private System.Windows.Forms.Button buttonUnassign;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
