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
    public partial class frmDiscount : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();
        double discnt = 0, getTotFinal = 0, tot=0;
        public frmDiscount()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            getDis();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_discount set Discount = '" + txtPercent.Text + "',discAmount = '" + txtDiscount.Text +"'";
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();

            MessageBox.Show("Discount is successfully update","Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDis.Text = "";
            listDis.Items.Clear();
            getDis();
        }

        void getDis()
        {
            getTotTuition();
            string sql = "select * from tbl_discount";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
              //  discnt = Convert.ToDouble(txtDis.Text) * 100;
                list = listDis.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());

                //discnt = Convert.ToDouble(dr.GetValue(1).ToString()) * 100;
                list.SubItems.Add(getTotFinal.ToString("#,##0.0"));
                list.SubItems.Add(dr.GetValue(2).ToString());
            }
            dr.Close();
        }

        void getTotTuition()
        {
            try
            {
                string sql = "select sum(amount) from tbl_tuition";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    getTotFinal = Convert.ToDouble(dr.GetValue(0).ToString());
                    tot = Convert.ToDouble(dr.GetValue(0).ToString());
                     txtTuition.Text = tot.ToString("#,##0.0");
                }
                dr.Close();
            }
            catch (Exception ee) { }
        }

        private void listDis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDis_TextChanged(object sender, EventArgs e)
        {
            double amt, amtTot;


            try
            {
                txtPercent.Text = Convert.ToString(Convert.ToDouble(txtDis.Text) * 100);
                amt = Convert.ToDouble(txtDis.Text) * Convert.ToDouble(txtTuition.Text);
                amtTot = Convert.ToDouble(txtTuition.Text) - amt;
                txtDiscount.Text = amtTot.ToString("#,##0.0");
            }
            catch (Exception ee)
            {
                txtDiscount.Text = "0";
                txtPercent.Text = "0";
            }
            
        }

        private void txtDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
