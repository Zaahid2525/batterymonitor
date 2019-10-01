using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void Button1_Click_1(object sender, EventArgs e)
        {
            PowerStatus status = SystemInformation.PowerStatus;
            label2.Text = status.BatteryLifePercent.ToString("P0");
        }
    }
}
