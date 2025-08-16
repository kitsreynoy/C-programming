using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KiddieCare
{
    public partial class frmAccessAdjustTime : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();
        int tries = 3;

        public frmAccessAdjustTime()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void txtAccess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tries == 1)
                {
                    MessageBox.Show("You inputed an incorrect information for 3 consecutive times. \nTermination on process. . .", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }


                string sql = "select * from tbl_user where privilege like 'admin' and accesscode like '" + txtAccess.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Access Granted. Welcome " + dr.GetValue(3).ToString() + "!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    //frmCheckdate time = new frmCheckdate();

                    frmAdjustTime time = new frmAdjustTime();
                    time.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect access code! \nYou have " + tries +" remaining tries", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAccess.Text = "";
                    tries--;
                }

                dr.Close();
            }
        }

        private void txtAccess_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAccessAdjustTime_Load(object sender, EventArgs e)
        {
        }
    }
}
