namespace Project.Controls
{
    partial class ProfileContentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileContentControl));
            this.pictureBoxProfileImg = new System.Windows.Forms.PictureBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelTasksDone = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxTasksDone = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTasksAssigned = new System.Windows.Forms.Label();
            this.dataGridViewEmployeeTasks = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfileImg
            // 
            this.pictureBoxProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfileImg.Image")));
            this.pictureBoxProfileImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfileImg.InitialImage")));
            this.pictureBoxProfileImg.Location = new System.Drawing.Point(60, 36);
            this.pictureBoxProfileImg.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProfileImg.Name = "pictureBoxProfileImg";
            this.pictureBoxProfileImg.Size = new System.Drawing.Size(190, 156);
            this.pictureBoxProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfileImg.TabIndex = 2;
            this.pictureBoxProfileImg.TabStop = false;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(365, 36);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(360, 35);
            this.textBoxEmployeeName.TabIndex = 3;
            this.textBoxEmployeeName.Text = "<name>";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(361, 99);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(361, 132);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(361, 166);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(115, 20);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "phone number";
            // 
            // labelTasksDone
            // 
            this.labelTasksDone.AutoSize = true;
            this.labelTasksDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasksDone.Location = new System.Drawing.Point(361, 195);
            this.labelTasksDone.Name = "labelTasksDone";
            this.labelTasksDone.Size = new System.Drawing.Size(90, 20);
            this.labelTasksDone.TabIndex = 8;
            this.labelTasksDone.Text = "tasks done";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(475, 99);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(206, 19);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.Text = "<username>";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTasksDone
            // 
            this.textBoxTasksDone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTasksDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTasksDone.Location = new System.Drawing.Point(475, 196);
            this.textBoxTasksDone.Name = "textBoxTasksDone";
            this.textBoxTasksDone.ReadOnly = true;
            this.textBoxTasksDone.Size = new System.Drawing.Size(206, 19);
            this.textBoxTasksDone.TabIndex = 10;
            this.textBoxTasksDone.Text = "<tasks-done>";
            this.textBoxTasksDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(475, 166);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(206, 19);
            this.textBoxPhone.TabIndex = 11;
            this.textBoxPhone.Text = "<phone-nr>";
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(475, 132);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(206, 19);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.Text = "<email>";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTasksAssigned
            // 
            this.labelTasksAssigned.AutoSize = true;
            this.labelTasksAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasksAssigned.Location = new System.Drawing.Point(55, 240);
            this.labelTasksAssigned.Name = "labelTasksAssigned";
            this.labelTasksAssigned.Size = new System.Drawing.Size(184, 29);
            this.labelTasksAssigned.TabIndex = 13;
            this.labelTasksAssigned.Text = "Assigned Tasks";
            // 
            // dataGridViewEmployeeTasks
            // 
            this.dataGridViewEmployeeTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeTasks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewEmployeeTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeTasks.Location = new System.Drawing.Point(60, 297);
            this.dataGridViewEmployeeTasks.Name = "dataGridViewEmployeeTasks";
            this.dataGridViewEmployeeTasks.ReadOnly = true;
            this.dataGridViewEmployeeTasks.RowHeadersWidth = 51;
            this.dataGridViewEmployeeTasks.RowTemplate.Height = 24;
            this.dataGridViewEmployeeTasks.Size = new System.Drawing.Size(860, 306);
            this.dataGridViewEmployeeTasks.TabIndex = 0;
            this.dataGridViewEmployeeTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeTasks_CellClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(820, 36);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 36);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(710, 36);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 36);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ProfileContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewEmployeeTasks);
            this.Controls.Add(this.labelTasksAssigned);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxTasksDone);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelTasksDone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.pictureBoxProfileImg);
            this.Name = "ProfileContentControl";
            this.Size = new System.Drawing.Size(991, 646);
            this.Load += new System.EventHandler(this.ProfileContentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfileImg;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTasksDone;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxTasksDone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTasksAssigned;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeTasks;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
