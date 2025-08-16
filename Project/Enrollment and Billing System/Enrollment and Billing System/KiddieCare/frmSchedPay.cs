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
    public partial class frmSchedPay : Form
    {
        
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        public frmSchedPay()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void btnSaveSchedPay_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_Payment set dueDate = '" + dateTimePicker1.Text + "' where Particular like '" + cmbParticular.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            MessageBox.Show("Successfuly Save!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
