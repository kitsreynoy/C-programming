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

    public partial class frmYearMaintenance : Form
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();

        string uID, loginID;

        public frmYearMaintenance()
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

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text == "")
            {
                txtFrom.Text = "";
                txtTo.Text = "";
                btnActivate.Enabled = false;
               // btnDelete.Enabled = false;
                return;

            }
          
            txtTo.Text = Convert.ToString(Convert.ToInt32(txtFrom.Text) + 1);
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sql = "select * from tbl_sy where yrFrom like '" + txtFrom.Text + "' and yrTo like '" + txtTo.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This year " + dr[1].ToString() + " to " + dr[2].ToString() + " is already added", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "insert into tbl_sy(yrFrom,yrTo,sy,yrStatus) values('" + txtFrom.Text + "','" + txtTo.Text + "','" + txtFrom.Text + "-" + txtTo.Text + "','Inactive')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Year is successfull save", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "School Year is added");
                listYear.Items.Clear();
                txtFrom.Text = "";
                txtTo.Text = "";
                year();
            }
        }


        void year()
        {
            string sql = "select * from tbl_sy order by sy";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                list = listYear.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
            }
            dr.Close();
        }

        private void frmYearMaintenance_Load(object sender, EventArgs e)
        {
            year();
            btnActivate.Enabled = false;
            //btnDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //if (txtFrom.Text == "" || txtTo.Text == "")
            //{
            //    MessageBox.Show("Please select year to be deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //string sql = "delete from tbl_sy where yrID like '" + listYear.FocusedItem.Text +"'";
            //cm = new SqlCommand(sql,cn);
            //cm.ExecuteNonQuery();
            //MessageBox.Show("Year is successfully deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listYear.Items.Clear();
            //year();
            //cm.Dispose();
            //btnErase_Click(sender,e);
            //btnActivate.Enabled = false;
            //btnDelete.Enabled = false;
        }

        private void listYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrom.Text = listYear.FocusedItem.SubItems[1].Text;
            txtTo.Text = listYear.FocusedItem.SubItems[2].Text;
            btnActivate.Enabled = true;
          //  btnDelete.Enabled = true;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_sy set yrStatus = 'Active' where yrID like '" + listYear.FocusedItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            auditrail(uID, "The " + listYear.FocusedItem.Text + " is now Active");

            sql = "update tbl_sy set yrStatus = 'Inactive' where yrID <> '" + listYear.FocusedItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            MessageBox.Show("Year is Active", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listYear.Items.Clear();
            year();
            cm.Dispose();
            btnErase_Click(sender, e);
            btnActivate.Enabled = false;
          //  btnDelete.Enabled = false;


            
        }

    }
}
