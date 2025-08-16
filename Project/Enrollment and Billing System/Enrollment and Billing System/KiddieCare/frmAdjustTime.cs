using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiddieCare
{
    public partial class frmAdjustTime : Form
    {
        public frmAdjustTime()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frmAdjustTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("timedate.cpl");
        }
    }
}
