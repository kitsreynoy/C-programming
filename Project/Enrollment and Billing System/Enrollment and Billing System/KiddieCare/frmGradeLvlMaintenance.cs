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
    public partial class frmGradeLvlMaintenance : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();

        string uID, loginID;

        public frmGradeLvlMaintenance()
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

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnAddLvl_Click(object sender, EventArgs e)
        {
            if (txtGradeLvl.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            {
                string sql = "select * from tbl_gradeLvl where GradeLvl like '" + txtGradeLvl.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This " + dr[1].ToString() + " grade level is already added", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                dr.Close();

                 sql = "insert into tbl_gradeLvl(GradeLvl) values('" + txtGradeLvl.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Grade level is successfully save", "christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Grade level [" + txtGradeLvl.Text + "] is added");
                listGradeLvl.Items.Clear();
                ListGradeLvl();
                cm.Dispose();
                txtGradeLvl.Text = "";
            }
        }

        void ListGradeLvl()
        {
            string sql = "Select * from tbl_gradeLvl";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listGradeLvl.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
        }

        private void listGradeLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            btnAddLvl.Enabled = false;
            txtGradeLvl.Text = listGradeLvl.FocusedItem.SubItems[1].Text;
        }

        private void frmGradeLvlMaintenance_Load(object sender, EventArgs e)
        {
            ListGradeLvl();
            //btnDel.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtGradeLvl.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "update tbl_gradeLvl set GradeLvl = '" + txtGradeLvl.Text + "' where gradeLvlID like '" + listGradeLvl.FocusedItem.Text + "'";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Grade level is successfully updated", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Grade level [" + txtGradeLvl.Text + "] is updated");
                listGradeLvl.Items.Clear();
                ListGradeLvl();
                cm.Dispose();
                txtGradeLvl.Text = "";
                btnAddLvl.Enabled = true;
                btnDel.Enabled = false;

                //string sql = "delete from tbl_gradeLvl where gradeLvlID like '" + listGradeLvl .FocusedItem.Text + "'";
                //cm = new SqlCommand(sql, cn);
                //cm.ExecuteNonQuery();
                //MessageBox.Show("Year is successfully deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listGradeLvl.Items.Clear();
                //ListGradeLvl();
                //cm.Dispose();
                //txtGradeLvl.Text = "";
            }

        }

        private void txtGradeLvl_TextChanged(object sender, EventArgs e)
        {
            if(txtGradeLvl.Text == "")
            {
               // btnDel.Enabled = false;
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtGradeLvl.Text = "";
        }
    }
}
