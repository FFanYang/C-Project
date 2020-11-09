using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDigitalClock
{
    public partial class Clock : Form
    {
        Timer t = new Timer(); //create timer
       
        public Clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Clock_Load(object sender, EventArgs e) //start timer
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e) // evet handlingPrivate means e can only be accessed from within
        {                                              // void which I don't want to return anything. Tich is name

            //create a valueables
            int hours = DateTime.Now.Hour; // retrieve the time from local computer
            int mins = DateTime.Now.Minute;
            int Second = DateTime.Now.Second;
            //CREATE Item time 
            string time = "";
            if (hours < 10)
            {
                time += "0" + hours;
            }
            else
            {
                time += hours;
            }
            time += ":";

            if (mins < 10)
            {
                time += "0" + mins;
            }
            else
            {
                time += mins;
            }
            time += ":";

            if ( Second< 10)
            {
                time += "0" + Second;
            }
            else
            {
                time += Second;
            }
            time += ":";

            lblClock.Text = time;


        }
    }
}
