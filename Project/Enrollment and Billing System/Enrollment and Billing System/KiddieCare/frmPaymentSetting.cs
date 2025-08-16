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
    public partial class frmPaymentSetting : Form
    {
       
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        public frmPaymentSetting()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            string sql = "Update tbl_Payment set Amount = '" + txtDown.Text + "' where Particular like 'downpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtSecond.Text + "' where Particular like 'secondpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtThird.Text + "' where Particular like 'thirdpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtFourth.Text + "' where Particular like 'fourthpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtFifth.Text + "' where particular like 'fifthpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            MessageBox.Show("Successfully Save!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtDown.Text = "";
            txtTuition.Text = "";
            txtSecond.Text = "";
            txtThird.Text = "";
            txtFourth.Text = "";
            txtFifth.Text = "";
          
        }
    }
}
