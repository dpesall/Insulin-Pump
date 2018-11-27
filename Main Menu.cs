using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        int count = 1;
        int insulinAmountCurrent = 25;
        bool isAutoEnabled = true;
        public MainMenu()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int[] createButtonArray(String buttonString)
        {
            String[] buttonTempArr = buttonString.Split('/');
            int temp1 = 0;
            int temp2 = 0;
            Int32.TryParse(buttonTempArr[0], out temp1);
            Int32.TryParse(buttonTempArr[1], out temp2);

            if(temp2 == 1)
            {

            }

            int[] arr = { temp1, temp2 };
            return arr;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string themeString = System.IO.File.ReadAllText("themes.txt");
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);

            if (buttonArr[1] == 1)
            {
                isAutoEnabled = true;
                manualInject.Text = "Auto: On";
                manualInject.Enabled = false; ;
            }
            else
            {
                isAutoEnabled = false;
                manualInject.Enabled = true;
            }

            int theme = 0;
            Int32.TryParse(themeString, out theme);
            Random rnd = new Random();
            switch (theme)
            {
                case 1:
                    settingsButton.BackColor = Color.Firebrick;
                    slideToLockButton.BackColor = Color.Firebrick;
                    updateButton.BackColor = Color.Firebrick;
                    manualInject.BackColor = Color.Firebrick;
                    this.BackColor = Color.IndianRed;
                    break;
                case 2:
                    settingsButton.BackColor = Color.RoyalBlue;
                    slideToLockButton.BackColor = Color.RoyalBlue;
                    updateButton.BackColor = Color.RoyalBlue;
                    manualInject.BackColor = Color.RoyalBlue;
                    this.BackColor = SystemColors.ActiveCaption;
                    break;
                case 3:
                    settingsButton.BackColor = Color.ForestGreen;
                    slideToLockButton.BackColor = Color.ForestGreen;
                    updateButton.BackColor = Color.ForestGreen;
                    manualInject.BackColor = Color.ForestGreen;
                    this.BackColor = Color.DarkSeaGreen;
                    break;
                case 4:
                    settingsButton.BackColor = Color.FromArgb(57, 57, 57);
                    slideToLockButton.BackColor = Color.FromArgb(57, 57, 57);
                    updateButton.BackColor = Color.FromArgb(57, 57, 57);
                    manualInject.BackColor = Color.FromArgb(57, 57, 57);
                    this.BackColor = Color.FromArgb(89, 89, 89);
                    break;
            }

            loadGraph(sender, e, rnd);

            // DATE
            dateLabel.Text = "Nov. " + DateTime.Now.Day.ToString();

            // These lines check to see whether it's AM or PM
            String checkTime = DateTime.Now.ToString("HH");
            int hours = Convert.ToInt32(checkTime);
            String afterTwelve = hours >= 12 ? "PM" : "AM";
            // Displays the time with AM or PM
            timeDisplay.Text = DateTime.Now.ToString("hh:mm") + " " + afterTwelve;
        }

        private void updateGraph(object sender, EventArgs e, Random rnd, int count) {
            foreach (var series in chart1.Series){
                series.Points.Clear();
            }
            String timeNow = DateTime.Now.ToString("hh:mm");
            String[] newTime = timeNow.Split(':');
            int newTimeMinutes = 0;
            int newTimeHours = 0;
            Int32.TryParse(newTime[0], out newTimeHours);
            Int32.TryParse(newTime[1], out newTimeMinutes);
            newTimeMinutes += (10 * count);
            // Don't ask me why, but each of these if statements refuse to execute more than once at runtime,
            // so I have 10 of them just in case they hit the update graph button a bunch of times.
            if (newTimeMinutes >= 60) {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeHours > 12)
            {
                newTimeHours = 1;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeMinutes >= 60)
            {
                newTimeMinutes -= 60;
                newTimeHours++;
            }
            if (newTimeHours > 12)
            {
                newTimeHours = 1;
            }

            timeNow = newTimeHours + ":" + newTimeMinutes;

            int minutes = 0;
            int hour = 0;
            String[] arrayTimes = { "", "", "", "", "", };
            for (int i = 0; i < 5; i++)
            {

                String[] arr = timeNow.Split(':');
                String strTemp = arr[0];
                Int32.TryParse(arr[1], out minutes);
                if (i != 0)
                {
                    minutes -= 10;
                }

                if (minutes < 0)
                {
                    minutes += 60;
                    Int32.TryParse(strTemp, out hour);
                    hour--;
                    if (hour == 0)
                    {
                        hour = 12;
                    }
                    if (hour > 9)
                    {
                        arr[0] = hour.ToString();
                    }
                    else
                    {
                        arr[0] = "0" + hour.ToString();
                    }
                    
                } else
                {
                    // Makes sure to put a '0' in front of the hour when it's a single digit hour
                    Int32.TryParse(strTemp, out hour);
                    if (hour > 9)
                    {
                        arr[0] = hour.ToString();
                    }
                    else
                    {
                        arr[0] = "0" + hour.ToString();
                    }
                }

                if (minutes < 10)
                    // Same thing as previous comment, but for minutes
                {
                    arr[1] = "0" + minutes.ToString();
                }
                else
                {
                    arr[1] = minutes.ToString();
                }

                timeNow = arr[0] + ":" + arr[1];
                arrayTimes[4 - i] = timeNow;

            }

            insulinAmountCurrent += rnd.Next(4, 16);
            if (insulinAmountCurrent > 100 && isAutoEnabled)
            {
                var error2Form = new Form2();
                error2Form.Show();
                insulinAmountCurrent = 20;
            }
            insulinLevelCurrent.Text = insulinAmountCurrent.ToString();

            int dataLevel = 0;

            // Updates the 5 rows of previous insulin levels
            for (int k = 0; k < 5; k++)
            {
                switch (k)
                {
                    case 4:
                        levelLabel1.Text = insulinAmountCurrent.ToString();
                        timeLabel1.Text = arrayTimes[4];

                        this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", insulinAmountCurrent);
                        break;
                    case 3:
                        levelLabel2.Text = levelLabel1.Text;
                        timeLabel2.Text = arrayTimes[3];
                        Int32.TryParse(levelLabel1.Text, out dataLevel);
                        this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", dataLevel);
                        break;
                    case 2:
                        levelLabel3.Text = levelLabel2.Text;
                        timeLabel3.Text = arrayTimes[2];
                        Int32.TryParse(levelLabel2.Text, out dataLevel);
                        this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", dataLevel);
                        break;
                    case 1:
                        levelLabel4.Text = levelLabel3.Text;
                        timeLabel4.Text = arrayTimes[1];
                        Int32.TryParse(levelLabel3.Text, out dataLevel);
                        this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", dataLevel);
                        break;
                    case 0:
                        levelLabel5.Text = levelLabel4.Text;
                        timeLabel5.Text = arrayTimes[0];
                        Int32.TryParse(levelLabel4.Text, out dataLevel);
                        this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", dataLevel);
                        break;
                }
            }
        }

        // Loads the graph, only runs once
        private void loadGraph(object sender, EventArgs e, Random rnd) {
            chart1.Series["insulinLevels"].BorderWidth = 2;
            String timeNow = DateTime.Now.ToString("hh:mm");
            int minutes = 0;
            int hour = 0;
            String[] arrayTimes = { "", "", "", "", "", };
            for (int i = 0; i < 5; i++)
            {

                String[] arr = timeNow.Split(':');
                String strTemp = arr[0];
                Int32.TryParse(arr[1], out minutes);
                if(i != 0)
                {
                    minutes -= 10;
                }

                if (minutes < 0)
                {
                    minutes += 60;
                    Int32.TryParse(arr[0], out hour);
                    hour--;
                    if (hour == 0) {
                        hour = 12;
                    }
                    if (hour >= 10)
                    {
                        arr[0] = hour.ToString();
                    }
                    else {
                        arr[0] = "0" + hour.ToString();
                    }
                }
                if (minutes < 10)
                {
                    arr[1] = "0" + minutes.ToString();
                }
                else
                {
                    arr[1] = minutes.ToString();
                }
                timeNow = arr[0] + ":" + arr[1];
                arrayTimes[4 - i] = timeNow;

            }

            for (int k = 0; k < 5; k++)
            {
                this.chart1.Series["insulinLevels"].Points.AddXY(arrayTimes[k] + "  ", insulinAmountCurrent);
                switch (k)
                {
                    case 4:
                        levelLabel1.Text = insulinAmountCurrent.ToString();
                        timeLabel1.Text = arrayTimes[4];
                        break;
                    case 3:
                        levelLabel2.Text = insulinAmountCurrent.ToString();
                        timeLabel2.Text = arrayTimes[3];
                        break;
                    case 2:
                        levelLabel3.Text = insulinAmountCurrent.ToString();
                        timeLabel3.Text = arrayTimes[2];
                        break;
                    case 1:
                        levelLabel4.Text = insulinAmountCurrent.ToString();
                        timeLabel4.Text = arrayTimes[1];
                        break;
                    case 0:
                        levelLabel5.Text = insulinAmountCurrent.ToString();
                        timeLabel5.Text = arrayTimes[0];
                        break;
                }
                insulinLevelCurrent.Text = insulinAmountCurrent.ToString();
                insulinAmountCurrent += rnd.Next(4, 16);
                if (insulinAmountCurrent > 100 && isAutoEnabled) {
                    insulinAmountCurrent = 30;
                }
            }
        }

        private void slideToLockButton_Click(object sender, EventArgs e)
        {
            var firstForm = new LockScreen();
            this.Hide();
            firstForm.Show();
        }

        private void slideToLockButton_Hold(object sender, EventArgs e) {
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var thirdForm = new Settings();
            this.Hide();
            thirdForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            updateGraph(sender, e, rnd, count);
            count++;
            if(!isAutoEnabled)
            {
                if (insulinAmountCurrent < 55)
                {
                    manualInject.Text = "At Safe Level";
                    manualInject.Font = new Font(manualInject.Font.FontFamily, 18);
                    manualInject.Enabled = false;
                }
                else
                {
                    manualInject.Text = "Inject";
                    manualInject.Font = new Font(manualInject.Font.FontFamily, 24);
                    manualInject.Enabled = true;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void unitsLabel1_Click(object sender, EventArgs e)
        {

        }

        private void manualInject_Click(object sender, EventArgs e)
        {
            insulinAmountCurrent = 20;
            Random rnd = new Random();
            updateGraph(sender, e, rnd, count);
            count++;

            if (insulinAmountCurrent < 55)
            {
                manualInject.Text = "At Safe Level";
                manualInject.Font = new Font(manualInject.Font.FontFamily, 18);
                manualInject.Enabled = false;
            }
            else
            {
                manualInject.Text = "Inject";
                manualInject.Font = new Font(manualInject.Font.FontFamily, 24);
                manualInject.Enabled = true;
            }
        }
    }
}
