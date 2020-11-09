using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClockMins.Text = DateTime.Now.ToString("HH:mm");
            lblS.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblWeekday.Text = DateTime.Now.ToString("dddd"); //get datetime object. get time in to string covert the value to date time object 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start the above code 
            timer1.Start();
        }
    }
}
