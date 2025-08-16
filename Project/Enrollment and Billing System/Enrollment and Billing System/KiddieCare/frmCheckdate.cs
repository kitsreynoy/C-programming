using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace KiddieCare
{

    public partial class frmCheckdate : Form
    {
        public frmCheckdate()
        {
            InitializeComponent();
        }
        public struct SystemTime
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Millisecond;
        };

        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        public extern static void Win32GetSystemTime(ref SystemTime sysTime);

        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public extern static bool Win32SetSystemTime(ref SystemTime sysTime);

    

     

        private void button1_Click(object sender, EventArgs e)
        {

            // Set system date and time
            SystemTime updatedTime = new SystemTime();
            updatedTime.Year = (ushort)dtpDate.Value.Year;
            updatedTime.Month = (ushort)dtpDate.Value.Date.Month;
            updatedTime.Day = (ushort)dtpDate.Value.Day;
            // UTC time; it will be modified according to the regional settings of the target computer so the actual hour might differ
            updatedTime.Hour = (ushort)dtpTime.Value.Hour;
            updatedTime.Minute = (ushort)dtpTime.Value.Minute;
            updatedTime.Second = (ushort)dtpTime.Value.Second;
            // Call the unmanaged function that sets the new date and time instantly
            Win32SetSystemTime(ref updatedTime);

            //// Retrieve the current system date and time
            //SystemTime currTime = new SystemTime();
            //Win32GetSystemTime(ref currTime);
            //// You can now use the struct to retrieve the date and time
            //MessageBox.Show("It's " + currTime.Hour + " o'clock. Do you know where your C# code is?");

            //this.Hide();
            //frmLogin log = new frmLogin();
            //log.ShowDialog();
        }

        private void frmCheckdate_Load(object sender, EventArgs e)
        {
          //  timer1.Start();
            dtpDate.Enabled = false;
            dtpTime.Enabled = false;
            //dtpTime.Value = DateTime.Now;
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
            {
                dtpDate.Enabled = true;
            }
            else
            {
                dtpDate.Enabled = false;
            }
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTime.Checked == true)
            {
                dtpTime.Enabled = true;
            }
            else
            {
                dtpTime.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //DateTime.Now.ToString("hh:mm:ss tt");
          //  DateTimeOffset.Now.ToString("hh:mm:ss tt");
       
        }

   


    }
}
