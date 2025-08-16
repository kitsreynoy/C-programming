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
    public partial class frmDownpayment : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();
        double dp;
        public frmDownpayment()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void frmDownpayment_Load(object sender, EventArgs e)
        {
            getDown();
        }

        void getDown()
        {

            string sql = "select * from tbl_downpayment";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listDown.Items.Add(dr[0].ToString());
                dp = Convert.ToDouble(dr[1].ToString());
                list.SubItems.Add(dp.ToString("#,##0.0"));
            }
            dr.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtDown.Text == string.Empty)
            {
                MessageBox.Show("Please input the amount", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "update tbl_downpayment set downpayment = '" + txtDown.Text + "'";
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Downpayment is successfully save", "Christian Kiddie Star Academy", MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtDown.Text = "";
            listDown.Items.Clear();
            getDown();
        }

        private void txtDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

