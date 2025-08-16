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
    public partial class frmUserSetting : Form
    {
        string currentName = "";
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        string uID, loginID;
        frmLogin connection = new frmLogin();

        public frmUserSetting()
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

        private void lblChangeName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblChangeName.Text == "Save")
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Invalid input!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //---------------------------
                //string sql = "Select * from tblUsers where name like '" + txtName.Text + "'";
                //cm = new SqlCommand(sql, cn);
                //dr = cm.ExecuteReader();

                //if (dr.HasRows)
                //{
                //    MessageBox.Show("Name you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtName.Text = "";
                //    txtName.Focus();
                //    dr.Close();
                //    return;
                //}
                //dr.Close();
                //----------------------------------
                string sql1 = "update tbl_user set name = '" + txtName.Text + "' where uID like '" + uID + "'";
                cm = new SqlCommand(sql1, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Name successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUser();
                lblChangeName.Text = "Change";
                txtName.ReadOnly = true;
            }
            else
            {
                lblChangeName.Text = "Save";
                txtName.ReadOnly = false;
                currentName = txtName.Text;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void lblChangeUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblChangeUser.Text == "Save")
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Invalid input!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //------------------------------------
                string sql = "Select * from tbl_user where username like '" + txtUser.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Username you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtUser.Focus();
                    dr.Close();
                    return;
                }
                dr.Close();
                //-----------------------------------------
                string sql1 = "update tbl_user set username = '" + txtUser.Text + "' where uID like '" + uID + "'";
                cm = new SqlCommand(sql1, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Username successfully change", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUser();
                lblChangeUser.Text = "Change";
                txtUser.ReadOnly = true;
            }
            else
            {
                lblChangeUser.Text = "Save";
                txtUser.ReadOnly = false;
                currentName = txtUser.Text;
                txtUser.Text = "";
                txtUser.Focus();
            }
        }

        public void getUser()
        {
            string sql = "Select * from tbl_user where uID like '" + uID + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                uID = dr.GetValue(0).ToString();
                txtUser.Text = dr.GetValue(1).ToString();
                txtPass.Text = dr.GetValue(2).ToString();
                txtName.Text = dr.GetValue(3).ToString();
            }
            dr.Close();
        }

        private void lblChangepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  this.Width = 933;
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Width = 478;
            //timer2.Start();
            timer1.Stop();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtPassNew.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("The old and new password inputted didn't matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassNew.Text == txtPassConfirm.Text && txtPassNew.TextLength < 4)
            {
                MessageBox.Show("Password must be atleast 4 characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sql = "update tbl_user set password = '" + txtPassConfirm.Text + "' where uID like '" + uID + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Password successfully change", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancel_Click(sender, e);
            txtPassOld.Text = "";
            txtPassNew.Text = "";
            txtPassConfirm.Text = "";
        }

        private void frmUserSetting_Load(object sender, EventArgs e)
        {
            getUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // this.Width = 933;
            this.Width += 7;
            if (this.Width == 933)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          //  this.Width = 479;
            this.Width += 6;
            if (this.Width == 479)
            {
                timer1.Stop();
            }
        }
    }
}
