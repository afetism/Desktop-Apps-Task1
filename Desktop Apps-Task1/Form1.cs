using System;
using System.Reflection;

namespace Desktop_Apps_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer3.Tick+= Baku_Timer_Tick;
            timer3.Start();
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Desktop_Apps_Task1.Properties.Resources._5014;
           
            timer3.Tick+= Baku_Timer_Tick;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Desktop_Apps_Task1.Properties.Resources.istockphoto_1347665170_612x612;
            timer3.Tick+= London_Timer_Tick;
           

        }
      

        private void London_Timer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.UtcNow.ToString("HH:mm:ss tt");
        }

        private void Baku_Timer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void time_tick(object sender, EventArgs e)
        {

        }
    }
}
