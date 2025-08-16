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
    public partial class frmFee : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();

        frmLogin connection = new frmLogin();
        string uID, loginID;
        double month = 0, tuition = 0;

        public frmFee()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        private void frmFee_Load(object sender, EventArgs e)
        {
            getFeeType();
            compute();
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
        }

        void compute()
        {

            string sql = "select sum(monthly) from tbl_tuition";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtMonthly.Text = String.Format("{0:#,#0.00}", Convert.ToDouble(dr.GetValue(0).ToString()));
            }
            dr.Close();

            sql = "select sum(amount) from tbl_tuition";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtFull.Text = String.Format("{0:#,#0.00}", Convert.ToDouble(dr.GetValue(0).ToString()));
            }
            dr.Close();

            //sql = "select sum(amount) from tbl_tuition";
            //cm = new SqlCommand(sql, cn);
            //dr = cm.ExecuteReader();
            //while (dr.Read())

            //{
            //    try
            //    {
            //        tuition = Convert.ToDouble(dr.GetValue(0).ToString());
            //    }
            //    catch (Exception e)
            //    {
            //    }
                
            //}
            //dr.Close();

        }


        void getFeeType()
        {
            string sql = "select * from tbl_feeTypes";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbFeeType.Items.Add(dr.GetValue(1).ToString());
                
            }
            dr.Close();

            sql = "select * from tbl_tuition";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listFee.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(String.Format("{0:#,#0.00}", Convert.ToDouble(dr.GetValue(3).ToString())));
                list.SubItems.Add(String.Format("{0:#,#0.00}", Convert.ToDouble(dr.GetValue(4).ToString())));

            
            
            }
            dr.Close();
            
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbFeeType.Text == "" || txtAmount.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_tuition where title like '" + txtTitle.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("The " + txtTitle.Text + " are already added to " + cmbFeeType.Text + " type", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    dr.Close();
                    clear();
                    return;
                }
                dr.Close();

                string level = "All";

                double amt = Convert.ToDouble(txtAmount.Text);
                sql = "insert into tbl_tuition(feetype,title,amount,monthly,lvlType) values('" + cmbFeeType.Text + "','" + txtTitle.Text + "','" + amt +"','" + month + "','" + level + "')";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Tuition fee is successfully save","Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Tuition fee is added");
                cm.Dispose();
                cmbFeeType.Items.Clear();
                listFee.Items.Clear();
                getFeeType();
                clear();
                txtMonthly.Text = null;
                compute();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                txtAmount.Text = "";
            }
            else
            {
                month = Convert.ToDouble(txtAmount.Text) / 10;
            }
        }

        void clear()
        {
            cmbFeeType.Text = "";
            txtAmount.Text = "";
            txtTitle.Text = "";
        }

        private void listFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFeeType.Text = listFee.FocusedItem.SubItems[1].Text;
            txtTitle.Text = listFee.FocusedItem.SubItems[2].Text;
            txtAmount.Text = listFee.FocusedItem.SubItems[3].Text;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || cmbFeeType.Text == "")
            {

            }
            else
            {
                double amt = Convert.ToDouble(txtAmount.Text);
                string sql = "update tbl_tuition set title = '" + txtTitle.Text + "',amount = '" + amt.ToString("#,##0.00") + "',monthly = '" + month + "' where idTuition like '" + listFee.FocusedItem.Text + "'";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteReader();
                MessageBox.Show("Tuition fee is successfully updated", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Tuition fee is updated");
                dr.Close();
                cm.Dispose();
                cmbFeeType.Items.Clear();
                listFee.Items.Clear();
                getFeeType();
                clear();
                txtMonthly.Text = null;
                compute();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql = "delete tbl_tuition where idTuition like '" + listFee.FocusedItem.Text + "'";
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Tuition fee is successfully deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            auditrail(uID, "Tuition fee is deleted");
            cm.Dispose();
            cmbFeeType.Items.Clear();
            listFee.Items.Clear();
            getFeeType();
            clear();
            txtMonthly.Text = null;
            compute();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
