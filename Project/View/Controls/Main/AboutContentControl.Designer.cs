namespace View
{
    partial class AboutContentControl
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDesc1 = new System.Windows.Forms.Label();
            this.labelDesc2 = new System.Windows.Forms.Label();
            this.buttonDocs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(329, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(351, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "This is the about page";
            // 
            // labelDesc1
            // 
            this.labelDesc1.AutoSize = true;
            this.labelDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc1.Location = new System.Drawing.Point(289, 159);
            this.labelDesc1.Name = "labelDesc1";
            this.labelDesc1.Size = new System.Drawing.Size(413, 29);
            this.labelDesc1.TabIndex = 1;
            this.labelDesc1.Text = "Check out this open source project @";
            // 
            // labelDesc2
            // 
            this.labelDesc2.AutoSize = true;
            this.labelDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc2.Location = new System.Drawing.Point(356, 210);
            this.labelDesc2.Name = "labelDesc2";
            this.labelDesc2.Size = new System.Drawing.Size(266, 24);
            this.labelDesc2.TabIndex = 2;
            this.labelDesc2.Text = "https://github.com/Mihnea1711";
            // 
            // buttonDocs
            // 
            this.buttonDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocs.Location = new System.Drawing.Point(360, 353);
            this.buttonDocs.Name = "buttonDocs";
            this.buttonDocs.Size = new System.Drawing.Size(213, 48);
            this.buttonDocs.TabIndex = 3;
            this.buttonDocs.Text = "Help";
            this.buttonDocs.UseVisualStyleBackColor = true;
            this.buttonDocs.Click += new System.EventHandler(this.buttonDocs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "https://github.com/cioocan";
            // 
            // AboutContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDocs);
            this.Controls.Add(this.labelDesc2);
            this.Controls.Add(this.labelDesc1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AboutContentControl";
            this.Size = new System.Drawing.Size(979, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDesc1;
        private System.Windows.Forms.Label labelDesc2;
        private System.Windows.Forms.Button buttonDocs;
        private System.Windows.Forms.Label label1;
    }
}
