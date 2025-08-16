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
    public partial class frmAccessCode : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();
        frmMain main = new frmMain();

        int tries = 3;
        public bool addStudent = false, addTeacher = false, Enroll = false, Bill = false, SOA = false;
        public bool manageUsers = false;
        string uID, loginID;

        public frmAccessCode(string ID, string logID)
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            uID = ID;
            loginID = logID;
        }

        private void frmAccessCode_Load(object sender, EventArgs e)
        {
            main.auditrail(uID, "Showed access code form");
        }

        private void txtAccess_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccess_KeyDown(object sender, KeyEventArgs e)
        {
            main.auditrail(uID, "Encode the access code into the textbox");
            if (e.KeyCode == Keys.Enter) 
            {
                if (tries == 1) 
                {
                    MessageBox.Show("Sorry, you don't have a privilege to access", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    main.auditrail(uID, "Encoded incorrect access code 3 times, failed to enter desired form");
                    this.Hide();
                    return;
                }
                string sql = "select * from tbl_user where privilege like 'admin' and accesscode like '" + txtAccess.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Access Granted. Welcome " + dr.GetValue(3).ToString() + "!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectToLoad();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Incorrect access code", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    main.auditrail(uID, "Incorrect access code");
                    tries--;
                }
                    
                dr.Close();
            }
        }

        void selectToLoad()
        {
            if (manageUsers == true)
            {
                frmManagement users = new frmManagement();
                this.Hide();
                users.ShowDialog();
                main.auditrail(uID, "Display manage users form");
            }
            else if(addStudent == true)
            {
                fillUpForm addStud = new fillUpForm();
                this.Hide();
                addStud.ShowDialog();
                main.auditrail(uID, "The add student form was display");
            }
            else if (addTeacher == true)
            {
                frmAddTeacher teacher = new frmAddTeacher();
                this.Hide();
                teacher.ShowDialog();
                main.auditrail(uID, "The add teacher form was display");
            }
            else if (Enroll == true)
            {
                frmEnrollment enrolled = new frmEnrollment();
                this.Hide();
                enrolled.ShowDialog();
                main.auditrail(uID, "The enrollment form was display");
            }
            else if (Bill == true)
            {
                frmBilling bills = new frmBilling();
                this.Hide();
                bills.ShowDialog();
                main.auditrail(uID, "The Billing form was display");
            }
            else if (SOA == true)
            {
                StatementOFAccount state = new StatementOFAccount();
                this.Hide();
                state.ShowDialog();
                main.auditrail(uID, "The statement of account form was display");
            }
        }
    }
}
