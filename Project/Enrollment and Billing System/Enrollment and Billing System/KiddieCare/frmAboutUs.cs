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
    public partial class frmAboutUs : Form
    {
        string uID, loginID;

        public frmAboutUs()
        {
            InitializeComponent();
        }
        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }


        private void frmAboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
