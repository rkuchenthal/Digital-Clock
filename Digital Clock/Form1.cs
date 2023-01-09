using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class clock : Form
    {
        
        Timer t = new Timer();
        
        public clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clock_Load(object sender, EventArgs e)
        {
            t.Interval= 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute; 
            int ss = DateTime.Now.Second;

            string time = "";

            //hour 
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":"; //colon between hh:mm
            //minutes
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":"; //colon between mm:ss
            //seconds
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time;

        }
    }
}
