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
    public partial class frmTime : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        string uID, loginID;
        frmLogin connection = new frmLogin();

        public frmTime()
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

        void getSession()
        {
            string sql = "select * from tbl_time";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listTime.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
            }
            dr.Close();
        }

        void clear()
        {
            cmbSession.Text = "";
            txtFrom.Text = "";
            txtTime.Text = "";
            txtTo.Text = "";
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "" || cmbSession.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_time where time like '" + txtTime.Text + "' and dayPart like '" + cmbSession.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("The schedule is already added", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    txtFrom.Text = "00:00AM";
                    txtTo.Text = "00:00PM";
                    dr.Close();
                    return;
                    
                }
                dr.Close();

                sql = "insert into tbl_time(time,dayPart) values('" + txtFrom.Text + "-" + txtTo.Text + "','" + cmbSession.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("The " + txtFrom.Text + " to " + txtTo.Text + " is successfully save", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Time schedule is successfully added");
                cm.Dispose();
                listTime.Items.Clear();
                getSession();
                clear();
                txtFrom.Text = "00:00AM";
                txtTo.Text = "00:00PM";

            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string sql = "delete tbl_time where timeID like '" + listTime.FocusedItem.Text + "'";
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("The " + txtTime.Text +" is successfully deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            auditrail(uID, "Time schedule is successfully deleted");
            cm.Dispose();
            listTime.Items.Clear();
            getSession();
            clear();
            txtFrom.Text = "00:00AM";
            txtTo.Text = "00:00PM";
            btnDel.Enabled = false;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "" || cmbSession.Text == "")
            {
                MessageBox.Show("Please select the time you want to update", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
            {
                string sql = "update tbl_time set time = '" + txtFrom.Text + "-" + txtTo.Text + "',dayPart = '" + cmbSession.Text +"' where timeID like '" + listTime.FocusedItem.Text + "'";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("The " + txtFrom.Text + " to " + txtTo.Text + " is successfully updated", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Time schedule is successfully updated");
                cm.Dispose();
                listTime.Items.Clear();
                getSession();
                clear();
                txtFrom.Text = "00:00AM";
                txtTo.Text = "00:00PM";
                btnUpdate.Enabled = false;

            }
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            getSession();
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void listTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTime.Text = listTime.FocusedItem.SubItems[1].Text;
            cmbSession.Text = listTime.FocusedItem.SubItems[2].Text;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;

        }
    }
}
