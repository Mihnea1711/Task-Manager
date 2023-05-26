namespace View
{
    partial class UsersContentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersContentControl));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.pictureBoxPageLogo = new System.Windows.Forms.PictureBox();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPageLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
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
            this.panelNavBar.TabIndex = 5;
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
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.textBoxSearchBar.Text = "search user";
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
            this.labelPageTitle.Size = new System.Drawing.Size(198, 33);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Page Name Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "This is the users page";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(15, 139);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(953, 476);
            this.dataGridViewEmployees.TabIndex = 6;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            // 
            // UsersContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.label1);
            this.Name = "UsersContentControl";
            this.Size = new System.Drawing.Size(985, 639);
            this.Load += new System.EventHandler(this.UsersContentControl_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPageLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.PictureBox pictureBoxPageLogo;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
    }
}
