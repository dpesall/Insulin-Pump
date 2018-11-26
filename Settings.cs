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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private int[] createButtonArray(String buttonString)
        {
            String[] buttonTempArr = buttonString.Split('/');
            int temp1 = 0;
            int temp2 = 0;
            Int32.TryParse(buttonTempArr[0], out temp1);
            Int32.TryParse(buttonTempArr[1], out temp2);

            int[] arr = { temp1, temp2 };
            return arr;

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string themeString = System.IO.File.ReadAllText("themes.txt");
            string buttonString = System.IO.File.ReadAllText("buttons.txt");

            int theme = 0;
            Int32.TryParse(themeString, out theme);

            int[] buttonArr = createButtonArray(buttonString);

            if(buttonArr[1] == 1)
            {
                autoButton.Font = new Font(buttonSound.Font.FontFamily, 20);
                manualButton.Font = new Font(buttonSound.Font.FontFamily, 10);
            } else
            {
                autoButton.Font = new Font(buttonSound.Font.FontFamily, 10);
                manualButton.Font = new Font(buttonSound.Font.FontFamily, 20);
            }
            int soundSet = buttonArr[0];
            switch(soundSet)
            {
                case 1:
                    buttonSound.Font = new Font(buttonSound.Font.FontFamily, 14);
                    buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 10);
                    buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 10);
                    break;
                case 2:
                    buttonSound.Font = new Font(buttonSound.Font.FontFamily, 10);
                    buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 14);
                    buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 10);
                    break;
                case 3:
                    buttonSound.Font = new Font(buttonSound.Font.FontFamily, 10);
                    buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 10);
                    buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 14);
                    break;
            }
            

            switch (theme)
            {
                case 1:
                    mainMenuButton.BackColor = Color.Firebrick;
                    buttonSound.BackColor = Color.Firebrick;
                    buttonVibrate.BackColor = Color.Firebrick;
                    buttonBoth.BackColor = Color.Firebrick;
                    sleepValueUp.BackColor = Color.Firebrick;
                    sleepValueDown.BackColor = Color.Firebrick;
                    autoButton.BackColor = Color.Firebrick;
                    manualButton.BackColor = Color.Firebrick;
                    this.BackColor = Color.IndianRed;
                    break;
                case 2:
                    mainMenuButton.BackColor = Color.RoyalBlue;
                    buttonSound.BackColor = Color.RoyalBlue;
                    buttonVibrate.BackColor = Color.RoyalBlue;
                    buttonBoth.BackColor = Color.RoyalBlue;
                    sleepValueUp.BackColor = Color.RoyalBlue;
                    sleepValueDown.BackColor = Color.RoyalBlue;
                    autoButton.BackColor = Color.RoyalBlue;
                    manualButton.BackColor = Color.RoyalBlue;
                    this.BackColor = SystemColors.ActiveCaption;
                    break;
                case 3:
                    mainMenuButton.BackColor = Color.ForestGreen;
                    buttonSound.BackColor = Color.ForestGreen;
                    buttonVibrate.BackColor = Color.ForestGreen;
                    buttonBoth.BackColor = Color.ForestGreen;
                    sleepValueUp.BackColor = Color.ForestGreen;
                    sleepValueDown.BackColor = Color.ForestGreen;
                    autoButton.BackColor = Color.ForestGreen;
                    manualButton.BackColor = Color.ForestGreen;
                    this.BackColor = Color.DarkSeaGreen;
                    break;
                case 4:
                    mainMenuButton.BackColor = Color.FromArgb(57, 57, 57);
                    buttonSound.BackColor = Color.FromArgb(57, 57, 57);
                    buttonVibrate.BackColor = Color.FromArgb(57, 57, 57);
                    buttonBoth.BackColor = Color.FromArgb(57, 57, 57);
                    sleepValueUp.BackColor = Color.FromArgb(57, 57, 57);
                    sleepValueDown.BackColor = Color.FromArgb(57, 57, 57);
                    autoButton.BackColor = Color.FromArgb(57, 57, 57);
                    manualButton.BackColor = Color.FromArgb(57, 57, 57);
                    this.BackColor = Color.FromArgb(89, 89, 89);
                    break;
            }

            // DATE
            dateLabel.Text = "Nov. " + DateTime.Now.Day.ToString();

            // These lines check to see whether it's AM or PM
            String checkTime = DateTime.Now.ToString("HH");
            int hours = Convert.ToInt32(checkTime);
            String afterTwelve = hours >= 12 ? "PM" : "AM";
            // Displays the time with AM or PM
            timeDisplay.Text = DateTime.Now.ToString("hh:mm") + " " + afterTwelve;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var secondForm = new MainMenu();
            this.Hide();
            secondForm.Show();

        }

        private void sleepValueUp_Click(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(sleepTimerDisplay.Text) + 1;

            if (newValue != 31) {
                sleepTimerDisplay.Text = newValue.ToString();
            }
        }

        private void sleepValueDown_Click(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(sleepTimerDisplay.Text) - 1;

            if (newValue != 0)
            {
                sleepTimerDisplay.Text = newValue.ToString();
            }
        }

        private void sleepTimerDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("themes.txt", "1");
            mainMenuButton.BackColor = Color.Firebrick;
            buttonSound.BackColor = Color.Firebrick;
            buttonVibrate.BackColor = Color.Firebrick;
            buttonBoth.BackColor = Color.Firebrick;
            sleepValueUp.BackColor = Color.Firebrick;
            sleepValueDown.BackColor = Color.Firebrick;
            autoButton.BackColor = Color.Firebrick;
            manualButton.BackColor = Color.Firebrick;
            this.BackColor = Color.IndianRed;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("themes.txt", "2");
            mainMenuButton.BackColor = Color.RoyalBlue;
            buttonSound.BackColor = Color.RoyalBlue;
            buttonVibrate.BackColor = Color.RoyalBlue;
            buttonBoth.BackColor = Color.RoyalBlue;
            sleepValueUp.BackColor = Color.RoyalBlue;
            sleepValueDown.BackColor = Color.RoyalBlue;
            autoButton.BackColor = Color.RoyalBlue;
            manualButton.BackColor = Color.RoyalBlue;
            this.BackColor = SystemColors.ActiveCaption;
            
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("themes.txt", "3");
            mainMenuButton.BackColor = Color.ForestGreen;
            buttonSound.BackColor = Color.ForestGreen;
            buttonVibrate.BackColor = Color.ForestGreen;
            buttonBoth.BackColor = Color.ForestGreen;
            sleepValueUp.BackColor = Color.ForestGreen;
            sleepValueDown.BackColor = Color.ForestGreen;
            autoButton.BackColor = Color.ForestGreen;
            manualButton.BackColor = Color.ForestGreen;
            this.BackColor = Color.DarkSeaGreen;
           
        }

        private void buttonBlack_Click_1(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("themes.txt", "4");
            mainMenuButton.BackColor = Color.FromArgb(57, 57, 57);
            buttonSound.BackColor = Color.FromArgb(57, 57, 57);
            buttonVibrate.BackColor = Color.FromArgb(57, 57, 57);
            buttonBoth.BackColor = Color.FromArgb(57, 57, 57);
            sleepValueUp.BackColor = Color.FromArgb(57, 57, 57);
            sleepValueDown.BackColor = Color.FromArgb(57, 57, 57);
            autoButton.BackColor = Color.FromArgb(57, 57, 57);
            manualButton.BackColor = Color.FromArgb(57, 57, 57);
            this.BackColor = Color.FromArgb(89, 89, 89);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("themes.txt", "4");
            mainMenuButton.BackColor = Color.FromArgb(57, 57, 57);
            buttonSound.BackColor = Color.FromArgb(57, 57, 57);
            buttonVibrate.BackColor = Color.FromArgb(57, 57, 57);
            buttonBoth.BackColor = Color.FromArgb(57, 57, 57);
            sleepValueUp.BackColor = Color.FromArgb(57, 57, 57);
            sleepValueDown.BackColor = Color.FromArgb(57, 57, 57);
            autoButton.BackColor = Color.FromArgb(57, 57, 57);
            manualButton.BackColor = Color.FromArgb(57, 57, 57);
            this.BackColor = Color.FromArgb(89, 89, 89);
        }

        private void timeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);
            System.IO.File.WriteAllText("buttons.txt", "1" + "/" + buttonArr[0].ToString());

            buttonSound.Font = new Font(buttonSound.Font.FontFamily, 14);
            buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 10);
            buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 10);
        }

        private void buttonVibrate_Click(object sender, EventArgs e)
        {
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);
            System.IO.File.WriteAllText("buttons.txt", "2" + "/" + buttonArr[0].ToString());

            buttonSound.Font = new Font(buttonSound.Font.FontFamily, 10);
            buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 14);
            buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 10);
        }

        private void buttonBoth_Click(object sender, EventArgs e)
        {
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);
            System.IO.File.WriteAllText("buttons.txt", "3" + "/" + buttonArr[0].ToString());

            buttonSound.Font = new Font(buttonSound.Font.FontFamily, 10);
            buttonVibrate.Font = new Font(buttonSound.Font.FontFamily, 10);
            buttonBoth.Font = new Font(buttonSound.Font.FontFamily, 14);
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);
            System.IO.File.WriteAllText("buttons.txt", buttonArr[0].ToString() + "/" + "1");

            autoButton.Font = new Font(buttonSound.Font.FontFamily, 20);
            manualButton.Font = new Font(buttonSound.Font.FontFamily, 10);
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            string buttonString = System.IO.File.ReadAllText("buttons.txt");
            int[] buttonArr = createButtonArray(buttonString);
            System.IO.File.WriteAllText("buttons.txt", buttonArr[0].ToString() + "/" + "2");

            autoButton.Font = new Font(buttonSound.Font.FontFamily, 10);
           manualButton.Font = new Font(buttonSound.Font.FontFamily, 20);
        }
    }
}
