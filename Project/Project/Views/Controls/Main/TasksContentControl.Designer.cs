namespace Project.Controls
{
    partial class TasksContentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksContentControl));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.pictureBoxPageLogo = new System.Windows.Forms.PictureBox();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.LightGray;
            this.panelNavBar.Controls.Add(this.buttonSearch);
            this.panelNavBar.Controls.Add(this.textBoxSearchBar);
            this.panelNavBar.Controls.Add(this.pictureBoxPageLogo);
            this.panelNavBar.Controls.Add(this.labelPageTitle);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(985, 69);
            this.panelNavBar.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(793, 23);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchBar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBar.Location = new System.Drawing.Point(345, 23);
            this.textBoxSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(448, 30);
            this.textBoxSearchBar.TabIndex = 0;
            this.textBoxSearchBar.Text = "search tasks";
            this.textBoxSearchBar.WordWrap = false;
            // 
            // pictureBoxPageLogo
            // 
            this.pictureBoxPageLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPageLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPageLogo.Image")));
            this.pictureBoxPageLogo.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxPageLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPageLogo.Name = "pictureBoxPageLogo";
            this.pictureBoxPageLogo.Size = new System.Drawing.Size(45, 46);
            this.pictureBoxPageLogo.TabIndex = 1;
            this.pictureBoxPageLogo.TabStop = false;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.Location = new System.Drawing.Point(72, 20);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(77, 33);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Tasks";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddTask.Location = new System.Drawing.Point(842, 595);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(116, 34);
            this.buttonAddTask.TabIndex = 3;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(29, 93);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTasks.Size = new System.Drawing.Size(929, 483);
            this.dataGridViewTasks.TabIndex = 4;
            this.dataGridViewTasks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellContentDoubleClick);
            // 
            // TasksContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.panelNavBar);
            this.Name = "TasksContentControl";
            this.Size = new System.Drawing.Size(985, 655);
            this.Load += new System.EventHandler(this.TasksContentControl_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.PictureBox pictureBoxPageLogo;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
