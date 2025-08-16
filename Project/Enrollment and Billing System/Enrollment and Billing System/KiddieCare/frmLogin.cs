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
    public partial class frmLogin : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

       // public string constring = @"Data Source=DESKTOP-2LLV29I\MSSQLSERVER01;Initial Catalog=kiddieCareDb;Integrated Security=True";
        public string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kiddieCareDb;Integrated Security=True";

        string username, password, uID, logindate;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from tbl_user where username like '" + txtUser.Text + "' and password like '"
                    + txtPass.Text + "' and privilege like 'regular user' and status like 'online'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This account is currently online, you forgot to logout. Please approach administrator for help. Thank you", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                dr.Close();
                frmMain main = new frmMain();
                username = txtUser.Text;
                password = txtPass.Text;
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tbl_user where username like '" + txtUser.Text + "' and password like '" + txtPass.Text + "'";
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr[4].ToString() == "regular user")
                    {
                        main.accesscodeform = true;
                        main.btnAddSecurity.Enabled = false;
                        main.btnAddLvl.Enabled = false;
                        main.btnAddRoom.Enabled = false;
                        main.btnAddSection.Enabled = false;
                        main.btnAddSecurity.Enabled = false;
                        main.btnAddSubject.Enabled = false;
                        main.btnAddYear.Enabled = false;
                        main.btnFee.Enabled = false;
                        main.btnTime.Enabled = false;
                        main.toolDiscount.Enabled = false;
                        main.toolDownpay.Enabled = false;
                        main.btnLogtrail.Enabled = false;
                        main.btnAudit.Enabled = false;

                    }
                    MessageBox.Show("\tWelcome " + dr.GetValue(3).ToString() + " \n Time&Date Login : " + DateTime.Now.ToString() + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                    getuID();
                    insertToLogTrail();
                    updateStatus();
                    main.auditrail(uID, "Logged in successfully");
                    clear();
                    this.Hide();

                    main.dawat(uID, logindate);
                    main.Show();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Access Denied!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void getuID()
        {
            string sql = "Select * from tbl_user where username like '" + username + "' and password like '" + password + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                uID = dr.GetValue(0).ToString();
            }
            dr.Close();
        }

        public void getLoginDate()
        {
            string sql = "select * from tbl_logtrail where uID like '" + uID + "' and username like '" + txtUser.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                logindate = dr.GetValue(3).ToString();
            }
            dr.Close();
        }

        public void updateStatus()
        {
            string sql = "update tbl_user set status = 'online' where username like '" + txtUser.Text + "' and password like '" + txtPass.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        public void insertToLogTrail()
        {
            logindate = Convert.ToString(DateTime.Now);
            string sql = "insert into tbl_logtrail(uID,username,logindate) values('" + uID + "','" + txtUser.Text + "','" + logindate + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(constring);
            cn.Open();
            timer1.Start();
            txtUser.Text = "Username";
            txtPass.Text = "Password";
            txtPass.PasswordChar = '\0';
            txtUser.ForeColor = Color.Gainsboro;
            txtPass.ForeColor = Color.Gainsboro;

           
        }

        public void clear()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {

            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void frmLogin_Move(object sender, EventArgs e)
        {

        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {

                Environment.Exit(0);
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.2;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getuID();
            frmAccessCode access = new frmAccessCode(uID, "");
            access.manageUsers = true;
            access.ShowDialog();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '•';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.Gray;
            }
        }
    }
}
