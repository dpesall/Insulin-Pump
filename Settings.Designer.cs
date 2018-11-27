namespace WindowsFormsApp1
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSound = new System.Windows.Forms.Button();
            this.buttonVibrate = new System.Windows.Forms.Button();
            this.buttonBoth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sleepValueUp = new System.Windows.Forms.Button();
            this.sleepValueDown = new System.Windows.Forms.Button();
            this.sleepTimerDisplay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.autoManualLabel = new System.Windows.Forms.Label();
            this.autoButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.ForeColor = System.Drawing.Color.White;
            this.mainMenuButton.Location = new System.Drawing.Point(151, 81);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(297, 103);
            this.mainMenuButton.TabIndex = 10;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alert Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSound
            // 
            this.buttonSound.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSound.ForeColor = System.Drawing.Color.White;
            this.buttonSound.Location = new System.Drawing.Point(74, 259);
            this.buttonSound.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(135, 66);
            this.buttonSound.TabIndex = 12;
            this.buttonSound.Text = "Sound";
            this.buttonSound.UseVisualStyleBackColor = false;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // buttonVibrate
            // 
            this.buttonVibrate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVibrate.ForeColor = System.Drawing.Color.White;
            this.buttonVibrate.Location = new System.Drawing.Point(232, 259);
            this.buttonVibrate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVibrate.Name = "buttonVibrate";
            this.buttonVibrate.Size = new System.Drawing.Size(135, 66);
            this.buttonVibrate.TabIndex = 13;
            this.buttonVibrate.Text = "Vibrate";
            this.buttonVibrate.UseVisualStyleBackColor = false;
            this.buttonVibrate.Click += new System.EventHandler(this.buttonVibrate_Click);
            // 
            // buttonBoth
            // 
            this.buttonBoth.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoth.ForeColor = System.Drawing.Color.White;
            this.buttonBoth.Location = new System.Drawing.Point(390, 260);
            this.buttonBoth.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBoth.Name = "buttonBoth";
            this.buttonBoth.Size = new System.Drawing.Size(135, 66);
            this.buttonBoth.TabIndex = 14;
            this.buttonBoth.Text = "Both";
            this.buttonBoth.UseVisualStyleBackColor = false;
            this.buttonBoth.Click += new System.EventHandler(this.buttonBoth_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Volume";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 529);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Auto Lock Timer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Theme";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(137, 622);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(55, 55);
            this.buttonRed.TabIndex = 19;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBlue.Location = new System.Drawing.Point(229, 622);
            this.buttonBlue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(55, 55);
            this.buttonBlue.TabIndex = 20;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(321, 622);
            this.buttonGreen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(55, 55);
            this.buttonGreen.TabIndex = 21;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBlack.Location = new System.Drawing.Point(413, 622);
            this.buttonBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(55, 55);
            this.buttonBlack.TabIndex = 22;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 679);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Red";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 679);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Blue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 679);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Green";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 679);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Black";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sleepValueUp
            // 
            this.sleepValueUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.sleepValueUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepValueUp.ForeColor = System.Drawing.Color.White;
            this.sleepValueUp.Location = new System.Drawing.Point(366, 497);
            this.sleepValueUp.Name = "sleepValueUp";
            this.sleepValueUp.Size = new System.Drawing.Size(44, 46);
            this.sleepValueUp.TabIndex = 28;
            this.sleepValueUp.Text = "+";
            this.sleepValueUp.UseVisualStyleBackColor = false;
            this.sleepValueUp.Click += new System.EventHandler(this.sleepValueUp_Click);
            // 
            // sleepValueDown
            // 
            this.sleepValueDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.sleepValueDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepValueDown.ForeColor = System.Drawing.Color.White;
            this.sleepValueDown.Location = new System.Drawing.Point(366, 549);
            this.sleepValueDown.Name = "sleepValueDown";
            this.sleepValueDown.Size = new System.Drawing.Size(44, 46);
            this.sleepValueDown.TabIndex = 29;
            this.sleepValueDown.Text = "-";
            this.sleepValueDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sleepValueDown.UseVisualStyleBackColor = false;
            this.sleepValueDown.Click += new System.EventHandler(this.sleepValueDown_Click);
            // 
            // sleepTimerDisplay
            // 
            this.sleepTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepTimerDisplay.Location = new System.Drawing.Point(287, 520);
            this.sleepTimerDisplay.Name = "sleepTimerDisplay";
            this.sleepTimerDisplay.ReadOnly = true;
            this.sleepTimerDisplay.Size = new System.Drawing.Size(68, 49);
            this.sleepTimerDisplay.TabIndex = 31;
            this.sleepTimerDisplay.Text = "1";
            this.sleepTimerDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sleepTimerDisplay.TextChanged += new System.EventHandler(this.sleepTimerDisplay_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Minutes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(242, 451);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(203, 49);
            this.trackBar1.TabIndex = 35;
            // 
            // autoManualLabel
            // 
            this.autoManualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoManualLabel.Location = new System.Drawing.Point(58, 347);
            this.autoManualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoManualLabel.Name = "autoManualLabel";
            this.autoManualLabel.Size = new System.Drawing.Size(134, 67);
            this.autoManualLabel.TabIndex = 36;
            this.autoManualLabel.Text = "Insulin Injection:";
            this.autoManualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoButton
            // 
            this.autoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.autoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoButton.ForeColor = System.Drawing.Color.White;
            this.autoButton.Location = new System.Drawing.Point(188, 347);
            this.autoButton.Margin = new System.Windows.Forms.Padding(2);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(167, 65);
            this.autoButton.TabIndex = 39;
            this.autoButton.Text = "Auto";
            this.autoButton.UseVisualStyleBackColor = false;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.manualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.ForeColor = System.Drawing.Color.White;
            this.manualButton.Location = new System.Drawing.Point(375, 347);
            this.manualButton.Margin = new System.Windows.Forms.Padding(2);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(167, 65);
            this.manualButton.TabIndex = 40;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = false;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // timeDisplay
            // 
            this.timeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timeDisplay.Location = new System.Drawing.Point(191, 9);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDisplay.MaximumSize = new System.Drawing.Size(250, 260);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(216, 70);
            this.timeDisplay.TabIndex = 54;
            this.timeDisplay.Text = "HH:MM";
            this.timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateLabel.Location = new System.Drawing.Point(478, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.MaximumSize = new System.Drawing.Size(250, 260);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(109, 57);
            this.dateLabel.TabIndex = 55;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 748);
            this.ControlBox = false;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.autoManualLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sleepTimerDisplay);
            this.Controls.Add(this.sleepValueDown);
            this.Controls.Add(this.sleepValueUp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBoth);
            this.Controls.Add(this.buttonVibrate);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Button buttonVibrate;
        private System.Windows.Forms.Button buttonBoth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sleepValueUp;
        private System.Windows.Forms.Button sleepValueDown;
        private System.Windows.Forms.TextBox sleepTimerDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label autoManualLabel;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label dateLabel;
    }
}