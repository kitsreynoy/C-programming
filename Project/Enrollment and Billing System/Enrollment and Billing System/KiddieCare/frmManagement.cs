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
    public partial class frmManagement : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        frmLogin connection = new frmLogin();
        ListViewItem lst;
        string uID, text, loginID, passchar = "";

        public frmManagement()
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

        private void frmManagement_Load(object sender, EventArgs e)
        {
            cboPrivilege.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
          //  cboSearchBy.SelectedIndex = 0;
            txtSearch_TextChanged(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pictureBox1.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            cboPrivilege.Enabled = true;
            cboStatus.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnNewSave.Enabled = false;

            txtName.Text = listView1.FocusedItem.SubItems[1].Text;
            txtUser.Text = listView1.FocusedItem.SubItems[2].Text;
            string sql = "select * from tbl_user where uID like '" + listView1.FocusedItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtPass.Text = dr[2].ToString();
            }
            dr.Close();

            cboPrivilege.Text = listView1.FocusedItem.SubItems[4].Text;
            cboStatus.Text = listView1.FocusedItem.SubItems[5].Text;
        }

        public void clear()
        {
            txtName.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";

        }

        void viewRecord()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("uID", 0);
            listView1.Columns.Add("Account Name", 200);
            listView1.Columns.Add("Username", 200);
            listView1.Columns.Add("Password", 200);
            listView1.Columns.Add("Privilege", 200);
            listView1.Columns.Add("Status", 200);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            viewRecord();
            passchar = "";
            
                string sql = "select * from tbl_user where username like '" + txtSearch.Text + "%'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read()) 
                {
                    lst = listView1.Items.Add(dr.GetValue(0).ToString());
                    lst.SubItems.Add(dr.GetValue(3).ToString());
                    lst.SubItems.Add(dr.GetValue(1).ToString());
                    text = dr.GetValue(2).ToString();


                    for (int x = 0; x < text.Length; x++)
                    {
                        passchar += "•";
                    }


                    lst.SubItems.Add(passchar);
                    lst.SubItems.Add(dr.GetValue(4).ToString());
                    lst.SubItems.Add(dr.GetValue(6).ToString());
                    passchar = "";
                }
                dr.Close();
        }

        bool validation()
        {
            bool condition = true;
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.LemonChiffon;
                txtName.Focus();
                condition = false;
            }
            else if (txtUser.Text == "")
            {
                txtUser.BackColor = Color.LemonChiffon;
                txtUser.Focus();
                condition = false;
            }
            else if (txtPass.Text == "")
            {
                txtPass.BackColor = Color.LemonChiffon;
                txtPass.Focus();
                condition = false;
            }
            return condition;
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            if (btnNewSave.Text == "Save")
            {
                if (validation() == false)
                {
                    MessageBox.Show("Missing required field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "Select * from tbl_user where username like '" + txtUser.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Username you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = "";
                    txtUser.Focus();
                    dr.Close();
                    return;
                }

                dr.Close();

                sql = "insert into tbl_user(username,password,name,privilege,status) values('" + txtUser.Text + "','" + txtPass.Text + "','" + txtName.Text
                    + "','" + cboPrivilege.Text + "','" + cboStatus.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("New user has been successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm.Dispose();
                txtSearch_TextChanged(sender, e);
                btnCancel_Click(sender, e);
            }
            else
            {
                btnNewSave.Text = "Save";
                txtName.Enabled = true;
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                cboPrivilege.Enabled = true;
                cboStatus.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewSave.Text = "New";
            txtName.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            cboPrivilege.Enabled = false;
            cboStatus.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnNewSave.Enabled = true;
            panel3.Visible = false;
            btnEdit.Enabled = false;
            pictureBox1.Visible = true;
            txtName.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == false)
            {
                MessageBox.Show("Missing required field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "update tbl_user set username = '" + txtUser.Text + "',password = '" + txtPass.Text + "',name = '" + txtName.Text
                + "',privilege = '" + cboPrivilege.Text + "',status = '" + cboStatus.Text + "' where uID like '" + listView1.FocusedItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Account settings has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSearch_TextChanged(sender, e);
            btnCancel_Click(sender, e);
            cm.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove this account/user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "delete from tbl_user where uID like '" + listView1.FocusedItem.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch_TextChanged(sender, e);
                btnCancel_Click(sender, e);
            }
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
            panel3.Visible = false;
            pictureBox1.Visible = true;
        }

        private void cboPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
