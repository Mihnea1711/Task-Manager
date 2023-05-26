namespace View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonBacklog = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.panelPageContent = new System.Windows.Forms.Panel();
            this.buttonHelper = new System.Windows.Forms.Button();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.DarkGray;
            this.panelSideBar.Controls.Add(this.buttonHelper);
            this.panelSideBar.Controls.Add(this.buttonLogout);
            this.panelSideBar.Controls.Add(this.labelName);
            this.panelSideBar.Controls.Add(this.buttonProfile);
            this.panelSideBar.Controls.Add(this.buttonAbout);
            this.panelSideBar.Controls.Add(this.buttonUsers);
            this.panelSideBar.Controls.Add(this.buttonBacklog);
            this.panelSideBar.Controls.Add(this.labelUsername);
            this.panelSideBar.Controls.Add(this.pictureBoxLogo);
            this.panelSideBar.Controls.Add(this.buttonTasks);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(295, 682);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(57, 607);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(175, 39);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(168, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 22);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Fullname";
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(172, 91);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(108, 35);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "See Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(57, 408);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(175, 41);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(57, 338);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(175, 41);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonBacklog
            // 
            this.buttonBacklog.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBacklog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBacklog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBacklog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBacklog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacklog.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBacklog.Location = new System.Drawing.Point(57, 270);
            this.buttonBacklog.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBacklog.Name = "buttonBacklog";
            this.buttonBacklog.Size = new System.Drawing.Size(175, 41);
            this.buttonBacklog.TabIndex = 3;
            this.buttonBacklog.Text = "Backlog";
            this.buttonBacklog.UseVisualStyleBackColor = false;
            this.buttonBacklog.Click += new System.EventHandler(this.buttonBacklog_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(168, 56);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(78, 19);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(129, 108);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonTasks
            // 
            this.buttonTasks.BackColor = System.Drawing.Color.DarkGray;
            this.buttonTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTasks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTasks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTasks.Location = new System.Drawing.Point(57, 197);
            this.buttonTasks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(175, 41);
            this.buttonTasks.TabIndex = 2;
            this.buttonTasks.Text = "Tasks";
            this.buttonTasks.UseVisualStyleBackColor = false;
            this.buttonTasks.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DarkGray;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFooter.Location = new System.Drawing.Point(0, 646);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1279, 36);
            this.panelFooter.TabIndex = 3;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.Location = new System.Drawing.Point(600, 8);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(115, 17);
            this.labelFooter.TabIndex = 4;
            this.labelFooter.Text = "@ Copyright 2023";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPageContent
            // 
            this.panelPageContent.Location = new System.Drawing.Point(295, 0);
            this.panelPageContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelPageContent.Name = "panelPageContent";
            this.panelPageContent.Size = new System.Drawing.Size(984, 646);
            this.panelPageContent.TabIndex = 4;
            // 
            // buttonHelper
            // 
            this.buttonHelper.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHelper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonHelper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHelper.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelper.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelper.Location = new System.Drawing.Point(57, 481);
            this.buttonHelper.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelper.Name = "buttonHelper";
            this.buttonHelper.Size = new System.Drawing.Size(175, 41);
            this.buttonHelper.TabIndex = 7;
            this.buttonHelper.Text = "IHelpU";
            this.buttonHelper.UseVisualStyleBackColor = false;
            this.buttonHelper.Click += new System.EventHandler(this.buttonHelper_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 682);
            this.Controls.Add(this.panelPageContent);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonBacklog;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Panel panelPageContent;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHelper;
    }
}

