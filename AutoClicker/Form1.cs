using AutoClicker.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private Clicker clicker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betweenClickMin.Text = Settings.Default.BetweenClickMin.ToString();
            betweenClickMax.Text = Settings.Default.BetweenClickMax.ToString();
            holdDownMin.Text = Settings.Default.HoldDownMin.ToString();
            holdDownMax.Text = Settings.Default.HoldDownMax.ToString();
            activationKey.Text = Settings.Default.ActivationKey.ToString();

            clicker = new Clicker(Settings.Default.BetweenClickMin, Settings.Default.BetweenClickMax, Settings.Default.HoldDownMin,
                Settings.Default.HoldDownMax, Settings.Default.ActivationKey);
        }

        private void betweenClickMin_Leave(object sender, EventArgs e)
        {
            SetBetweenClickTimes();
        }

        private void betweenClickMax_Leave(object sender, EventArgs e)
        {
            SetBetweenClickTimes();
        }

        private void holdDownMin_Leave(object sender, EventArgs e)
        {
            SetHoldDownTimes();
        }

        private void holdDownMax_Leave(object sender, EventArgs e)
        {
            SetHoldDownTimes();
        }

        private void SetHoldDownTimes()
        {
            int holdDownMin;
            int holdDownMax;

            if (int.TryParse(this.holdDownMin.Text, out holdDownMin) && int.TryParse(this.holdDownMax.Text, out holdDownMax) && 
                holdDownMin <= holdDownMax && holdDownMax >= holdDownMin)
            {
                this.holdDownMin.BackColor = Color.White;
                this.holdDownMax.BackColor = Color.White;
                Clicker.HoldDownMin = holdDownMin;
                Clicker.HoldDownMax = holdDownMax;
                Settings.Default.HoldDownMin = holdDownMin;
                Settings.Default.HoldDownMax = holdDownMax;
                Settings.Default.Save();
            }
            else
            {
                this.holdDownMin.BackColor = Color.Red;
                this.holdDownMax.BackColor = Color.Red;
            }
        }

        private void SetBetweenClickTimes()
        {
            int betweenClickMin;
            int betweenClickMax;

            if(int.TryParse(this.betweenClickMin.Text, out betweenClickMin) && int.TryParse(this.betweenClickMax.Text, out betweenClickMax) &&
                betweenClickMin <= betweenClickMax && betweenClickMax >= betweenClickMin)
            {
                this.betweenClickMin.BackColor = Color.White;
                this.betweenClickMax.BackColor = Color.White;
                Clicker.BetweenClickMax = betweenClickMin;
                Clicker.BetweenClickMax = betweenClickMax;
                Settings.Default.BetweenClickMin = betweenClickMin;
                Settings.Default.BetweenClickMax = betweenClickMax;
                Settings.Default.Save();
            }
            else
            {
                this.betweenClickMin.BackColor = Color.Red;
                this.betweenClickMax.BackColor = Color.Red;
            }
        }

        private void activationKey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            activationKey.Text = e.KeyCode.ToString();
            Clicker.ActivationKey = e.KeyCode;
            Settings.Default.ActivationKey = e.KeyCode;
            Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clicker.Dispose();
            Application.Exit();
        }
    }
}
