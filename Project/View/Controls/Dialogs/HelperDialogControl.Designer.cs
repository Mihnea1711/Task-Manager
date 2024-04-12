namespace View
{
    partial class HelperDialogControl
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTimeStarted = new System.Windows.Forms.Label();
            this.labelTimeStopped = new System.Windows.Forms.Label();
            this.textBoxStarted = new System.Windows.Forms.TextBox();
            this.textBoxStopped = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(46, 406);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(128, 48);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(223, 406);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(171, 48);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "PAUSE";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(230, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(121, 36);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Counter";
            // 
            // labelTimeStarted
            // 
            this.labelTimeStarted.AutoSize = true;
            this.labelTimeStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeStarted.Location = new System.Drawing.Point(29, 103);
            this.labelTimeStarted.Name = "labelTimeStarted";
            this.labelTimeStarted.Size = new System.Drawing.Size(132, 31);
            this.labelTimeStarted.TabIndex = 3;
            this.labelTimeStarted.Text = "Started at";
            // 
            // labelTimeStopped
            // 
            this.labelTimeStopped.AutoSize = true;
            this.labelTimeStopped.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeStopped.Location = new System.Drawing.Point(29, 156);
            this.labelTimeStopped.Name = "labelTimeStopped";
            this.labelTimeStopped.Size = new System.Drawing.Size(145, 31);
            this.labelTimeStopped.TabIndex = 4;
            this.labelTimeStopped.Text = "Stopped at";
            // 
            // textBoxStarted
            // 
            this.textBoxStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStarted.Location = new System.Drawing.Point(192, 100);
            this.textBoxStarted.Name = "textBoxStarted";
            this.textBoxStarted.ReadOnly = true;
            this.textBoxStarted.Size = new System.Drawing.Size(380, 38);
            this.textBoxStarted.TabIndex = 5;
            // 
            // textBoxStopped
            // 
            this.textBoxStopped.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStopped.Location = new System.Drawing.Point(192, 153);
            this.textBoxStopped.Name = "textBoxStopped";
            this.textBoxStopped.ReadOnly = true;
            this.textBoxStopped.Size = new System.Drawing.Size(380, 38);
            this.textBoxStopped.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTime.Location = new System.Drawing.Point(46, 268);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 26);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.Visible = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(425, 406);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 48);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // HelperDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxStopped);
            this.Controls.Add(this.textBoxStarted);
            this.Controls.Add(this.labelTimeStopped);
            this.Controls.Add(this.labelTimeStarted);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Name = "HelperDialogControl";
            this.Size = new System.Drawing.Size(614, 516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonRun;
        public System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Label labelTimeStarted;
        public System.Windows.Forms.Label labelTimeStopped;
        public System.Windows.Forms.TextBox textBoxStarted;
        public System.Windows.Forms.TextBox textBoxStopped;
        public System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Button buttonReset;
    }
}
