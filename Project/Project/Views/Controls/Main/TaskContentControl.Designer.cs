namespace Project.Controls
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewSubtasks = new System.Windows.Forms.DataGridView();
            this.buttonAddSubtask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAssignedEmployee = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.progressBarProgress = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonToSubtask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(11, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(298, 39);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Task <task-name>";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(19, 142);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(888, 94);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Text = "task description........";
            // 
            // dataGridViewSubtasks
            // 
            this.dataGridViewSubtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubtasks.Location = new System.Drawing.Point(19, 327);
            this.dataGridViewSubtasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSubtasks.Name = "dataGridViewSubtasks";
            this.dataGridViewSubtasks.RowHeadersWidth = 51;
            this.dataGridViewSubtasks.RowTemplate.Height = 24;
            this.dataGridViewSubtasks.Size = new System.Drawing.Size(889, 169);
            this.dataGridViewSubtasks.TabIndex = 4;
            // 
            // buttonAddSubtask
            // 
            this.buttonAddSubtask.Location = new System.Drawing.Point(767, 528);
            this.buttonAddSubtask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSubtask.Name = "buttonAddSubtask";
            this.buttonAddSubtask.Size = new System.Drawing.Size(141, 38);
            this.buttonAddSubtask.TabIndex = 5;
            this.buttonAddSubtask.Text = "Add Subtask";
            this.buttonAddSubtask.UseVisualStyleBackColor = true;
            this.buttonAddSubtask.Click += new System.EventHandler(this.buttonAddSubtask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtasks";
            // 
            // labelAssignedEmployee
            // 
            this.labelAssignedEmployee.AutoSize = true;
            this.labelAssignedEmployee.Location = new System.Drawing.Point(693, 239);
            this.labelAssignedEmployee.Name = "labelAssignedEmployee";
            this.labelAssignedEmployee.Size = new System.Drawing.Size(206, 16);
            this.labelAssignedEmployee.TabIndex = 7;
            this.labelAssignedEmployee.Text = "Assigned To - <employee name>";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(15, 96);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(107, 16);
            this.labelDeadline.TabIndex = 8;
            this.labelDeadline.Text = "Time left - hh:mm";
            // 
            // progressBarProgress
            // 
            this.progressBarProgress.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBarProgress.Location = new System.Drawing.Point(776, 44);
            this.progressBarProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarProgress.Name = "progressBarProgress";
            this.progressBarProgress.Size = new System.Drawing.Size(100, 23);
            this.progressBarProgress.TabIndex = 9;
            this.progressBarProgress.Value = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(881, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // buttonToSubtask
            // 
            this.buttonToSubtask.Location = new System.Drawing.Point(249, 359);
            this.buttonToSubtask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToSubtask.Name = "buttonToSubtask";
            this.buttonToSubtask.Size = new System.Drawing.Size(213, 74);
            this.buttonToSubtask.TabIndex = 11;
            this.buttonToSubtask.Text = "toSubtask";
            this.buttonToSubtask.UseVisualStyleBackColor = true;
            this.buttonToSubtask.Click += new System.EventHandler(this.buttonToSubtask_Click);
            // 
            // TaskContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonToSubtask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarProgress);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelAssignedEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddSubtask);
            this.Controls.Add(this.dataGridViewSubtasks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskContentControl";
            this.Size = new System.Drawing.Size(933, 580);
            this.Load += new System.EventHandler(this.TaskContentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonToSubtask;
    }
}
