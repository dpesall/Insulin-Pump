﻿namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insulinLevelCurrent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastDoseTime = new System.Windows.Forms.Label();
            this.slideToLockButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.levelLabel1 = new System.Windows.Forms.TextBox();
            this.levelLabel4 = new System.Windows.Forms.TextBox();
            this.levelLabel3 = new System.Windows.Forms.TextBox();
            this.levelLabel2 = new System.Windows.Forms.TextBox();
            this.levelLabel5 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.updateButton = new System.Windows.Forms.Button();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.timeLabel4 = new System.Windows.Forms.Label();
            this.timeLabel3 = new System.Windows.Forms.Label();
            this.timeLabel5 = new System.Windows.Forms.Label();
            this.unitsLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeAM_PM = new System.Windows.Forms.Label();
            this.amountBoxLabel = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.manualInject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Blood Sugar Level:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insulinLevelCurrent
            // 
            this.insulinLevelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insulinLevelCurrent.Location = new System.Drawing.Point(370, 178);
            this.insulinLevelCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insulinLevelCurrent.Name = "insulinLevelCurrent";
            this.insulinLevelCurrent.Size = new System.Drawing.Size(81, 45);
            this.insulinLevelCurrent.TabIndex = 8;
            this.insulinLevelCurrent.Text = "7";
            this.insulinLevelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insulinLevelCurrent.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Dose:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastDoseTime
            // 
            this.lastDoseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDoseTime.Location = new System.Drawing.Point(379, 108);
            this.lastDoseTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastDoseTime.Name = "lastDoseTime";
            this.lastDoseTime.Size = new System.Drawing.Size(111, 22);
            this.lastDoseTime.TabIndex = 10;
            this.lastDoseTime.Text = "5:26pm";
            // 
            // slideToLockButton
            // 
            this.slideToLockButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.slideToLockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideToLockButton.ForeColor = System.Drawing.Color.White;
            this.slideToLockButton.Location = new System.Drawing.Point(12, 629);
            this.slideToLockButton.Name = "slideToLockButton";
            this.slideToLockButton.Size = new System.Drawing.Size(230, 95);
            this.slideToLockButton.TabIndex = 13;
            this.slideToLockButton.Text = "Lock";
            this.slideToLockButton.UseVisualStyleBackColor = false;
            this.slideToLockButton.Click += new System.EventHandler(this.slideToLockButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(12, 512);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(230, 95);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // levelLabel1
            // 
            this.levelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel1.Location = new System.Drawing.Point(330, 498);
            this.levelLabel1.Name = "levelLabel1";
            this.levelLabel1.ReadOnly = true;
            this.levelLabel1.Size = new System.Drawing.Size(200, 49);
            this.levelLabel1.TabIndex = 32;
            this.levelLabel1.Text = "1";
            this.levelLabel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelLabel4
            // 
            this.levelLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel4.Location = new System.Drawing.Point(330, 641);
            this.levelLabel4.Name = "levelLabel4";
            this.levelLabel4.ReadOnly = true;
            this.levelLabel4.Size = new System.Drawing.Size(200, 49);
            this.levelLabel4.TabIndex = 33;
            this.levelLabel4.Text = "1";
            this.levelLabel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelLabel3
            // 
            this.levelLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel3.Location = new System.Drawing.Point(330, 594);
            this.levelLabel3.Name = "levelLabel3";
            this.levelLabel3.ReadOnly = true;
            this.levelLabel3.Size = new System.Drawing.Size(200, 49);
            this.levelLabel3.TabIndex = 34;
            this.levelLabel3.Text = "1";
            this.levelLabel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelLabel2
            // 
            this.levelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel2.Location = new System.Drawing.Point(330, 546);
            this.levelLabel2.Name = "levelLabel2";
            this.levelLabel2.ReadOnly = true;
            this.levelLabel2.Size = new System.Drawing.Size(200, 49);
            this.levelLabel2.TabIndex = 35;
            this.levelLabel2.Text = "1";
            this.levelLabel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelLabel5
            // 
            this.levelLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel5.Location = new System.Drawing.Point(330, 689);
            this.levelLabel5.Name = "levelLabel5";
            this.levelLabel5.ReadOnly = true;
            this.levelLabel5.Size = new System.Drawing.Size(200, 49);
            this.levelLabel5.TabIndex = 36;
            this.levelLabel5.Text = "1";
            this.levelLabel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chart1
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.Maximum = 110D;
            chartArea2.AxisY.Minimum = 10D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(12, 86);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.Black;
            series2.LabelBorderColor = System.Drawing.Color.Black;
            series2.Name = "insulinLevels";
            series2.ShadowColor = System.Drawing.Color.Gray;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(353, 383);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(426, 421);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 33);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "+10 minutes";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // timeLabel1
            // 
            this.timeLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel1.Location = new System.Drawing.Point(336, 502);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(73, 41);
            this.timeLabel1.TabIndex = 39;
            this.timeLabel1.Text = "time";
            this.timeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel2
            // 
            this.timeLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel2.Location = new System.Drawing.Point(336, 550);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(73, 41);
            this.timeLabel2.TabIndex = 40;
            this.timeLabel2.Text = "time";
            this.timeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel4
            // 
            this.timeLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel4.Location = new System.Drawing.Point(336, 645);
            this.timeLabel4.Name = "timeLabel4";
            this.timeLabel4.Size = new System.Drawing.Size(73, 41);
            this.timeLabel4.TabIndex = 42;
            this.timeLabel4.Text = "time";
            this.timeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel3
            // 
            this.timeLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel3.Location = new System.Drawing.Point(336, 597);
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(73, 41);
            this.timeLabel3.TabIndex = 41;
            this.timeLabel3.Text = "time";
            this.timeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel5
            // 
            this.timeLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel5.Location = new System.Drawing.Point(336, 693);
            this.timeLabel5.Name = "timeLabel5";
            this.timeLabel5.Size = new System.Drawing.Size(73, 41);
            this.timeLabel5.TabIndex = 43;
            this.timeLabel5.Text = "time";
            this.timeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitsLabel1
            // 
            this.unitsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel1.Location = new System.Drawing.Point(444, 196);
            this.unitsLabel1.Name = "unitsLabel1";
            this.unitsLabel1.Size = new System.Drawing.Size(58, 23);
            this.unitsLabel1.TabIndex = 44;
            this.unitsLabel1.Text = "mg/dL";
            this.unitsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsLabel1.Click += new System.EventHandler(this.unitsLabel1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "mg/dL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "mg/dL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "mg/dL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "mg/dL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "mg/dL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeAM_PM
            // 
            this.timeAM_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeAM_PM.Location = new System.Drawing.Point(336, 473);
            this.timeAM_PM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeAM_PM.Name = "timeAM_PM";
            this.timeAM_PM.Size = new System.Drawing.Size(93, 22);
            this.timeAM_PM.TabIndex = 51;
            this.timeAM_PM.Text = "Time: ";
            // 
            // amountBoxLabel
            // 
            this.amountBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBoxLabel.Location = new System.Drawing.Point(463, 473);
            this.amountBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountBoxLabel.Name = "amountBoxLabel";
            this.amountBoxLabel.Size = new System.Drawing.Size(93, 22);
            this.amountBoxLabel.TabIndex = 52;
            this.amountBoxLabel.Text = "Amount:";
            // 
            // timeDisplay
            // 
            this.timeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timeDisplay.Location = new System.Drawing.Point(191, 11);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDisplay.MaximumSize = new System.Drawing.Size(250, 260);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(216, 70);
            this.timeDisplay.TabIndex = 53;
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
            this.dateLabel.TabIndex = 54;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualInject
            // 
            this.manualInject.BackColor = System.Drawing.Color.RoyalBlue;
            this.manualInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInject.ForeColor = System.Drawing.Color.White;
            this.manualInject.Location = new System.Drawing.Point(384, 320);
            this.manualInject.Margin = new System.Windows.Forms.Padding(2);
            this.manualInject.Name = "manualInject";
            this.manualInject.Size = new System.Drawing.Size(198, 81);
            this.manualInject.TabIndex = 55;
            this.manualInject.Text = "Inject";
            this.manualInject.UseVisualStyleBackColor = false;
            this.manualInject.Click += new System.EventHandler(this.manualInject_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 748);
            this.ControlBox = false;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.amountBoxLabel);
            this.Controls.Add(this.timeAM_PM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitsLabel1);
            this.Controls.Add(this.timeLabel5);
            this.Controls.Add(this.timeLabel4);
            this.Controls.Add(this.timeLabel3);
            this.Controls.Add(this.timeLabel2);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.levelLabel5);
            this.Controls.Add(this.levelLabel2);
            this.Controls.Add(this.levelLabel3);
            this.Controls.Add(this.levelLabel4);
            this.Controls.Add(this.levelLabel1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.slideToLockButton);
            this.Controls.Add(this.lastDoseTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insulinLevelCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.manualInject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insulinLevelCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastDoseTime;
        private System.Windows.Forms.Button slideToLockButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox levelLabel1;
        private System.Windows.Forms.TextBox levelLabel4;
        private System.Windows.Forms.TextBox levelLabel3;
        private System.Windows.Forms.TextBox levelLabel2;
        private System.Windows.Forms.TextBox levelLabel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.Label timeLabel4;
        private System.Windows.Forms.Label timeLabel3;
        private System.Windows.Forms.Label timeLabel5;
        private System.Windows.Forms.Label unitsLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeAM_PM;
        private System.Windows.Forms.Label amountBoxLabel;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button manualInject;
    }
}