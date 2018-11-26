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
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string themeString = System.IO.File.ReadAllText("themes.txt");
            int theme = 0;
            Int32.TryParse(themeString, out theme);

            switch (theme) {
                case 1:
                    slideToUnlockButton.BackColor = Color.Firebrick;

                    this.BackColor = Color.IndianRed;
                    break;
                case 2:
                    slideToUnlockButton.BackColor = Color.RoyalBlue;
                    this.BackColor = SystemColors.ActiveCaption;
                    break;
                case 3:
                    slideToUnlockButton.BackColor = Color.ForestGreen;
                    this.BackColor = Color.DarkSeaGreen;
                    break;
                case 4:
                    slideToUnlockButton.BackColor = Color.FromArgb(57, 57, 57);
                    this.BackColor = Color.FromArgb(89, 89, 89);
                    break;
            }

            // DATE
            dateLabel.Text = "Nov. " + DateTime.Now.Day.ToString();

            // TIME
            // These lines check to see whether it's AM or PM
            String checkTime = DateTime.Now.ToString("HH");
            int hours = Convert.ToInt32(checkTime);
            String afterTwelve = hours >= 12 ? "PM" : "AM";
            // Displays the time with AM or PM
            timeDisplay.Text = DateTime.Now.ToString("hh:mm") + " " + afterTwelve;
        }

        private void slideToUnlockButton_Click(object sender, EventArgs e)
        {

            var secondForm = new MainMenu();
            this.Hide();
            secondForm.Show();
            

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var error1Form = new Form1();
            error1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var error2Form = new Form2();
            error2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var error3Form = new Form3();
            error3Form.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var error4Form = new Form4();
            error4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var error5Form = new Form5();
            error5Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var error6Form = new Form6();
            error6Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var error7Form = new Form7();
            error7Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var error8Form = new Form8();
            error8Form.Show();
        }
    }
}
