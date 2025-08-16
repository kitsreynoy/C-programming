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
    public partial class frmAddTeacher : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        string uID, loginID;
        frmLogin connection = new frmLogin();

        String x = "";
        Random rand = new Random();

        public frmAddTeacher()
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

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    btnSave.Enabled = false;
        //    btnDelete.Enabled = true;
        //    enable();
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            enable();

            txtIDno.Text = teaacherList.FocusedItem.Text;
            txtName.Text = teaacherList.FocusedItem.SubItems[1].Text;
            txtMI.Text = teaacherList.FocusedItem.SubItems[2].Text;
            txtLastName.Text = teaacherList.FocusedItem.SubItems[3].Text;
            cmbStatus.Text = teaacherList.FocusedItem.SubItems[4].Text;
            dateTimePicker1.Text = teaacherList.FocusedItem.SubItems[5].Text; ;
            txtAge.Text = teaacherList.FocusedItem.SubItems[6].Text;
            txtTelephone.Text = teaacherList.FocusedItem.SubItems[7].Text;
            cmbGender.Text = teaacherList.FocusedItem.SubItems[8].Text;
            txtPBirth.Text = teaacherList.FocusedItem.SubItems[9].Text;
            txtHAddress.Text = teaacherList.FocusedItem.SubItems[10].Text;
            txtCAddress.Text = teaacherList.FocusedItem.SubItems[11].Text;
            
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           // generateCode();

            if (txtIDno.Text == "")
            {
                generateCode();
            }
        }

        void generateCode()
        {
            string z = Convert.ToString(DateTime.Now.Year);

            for (int y = 1; y <= 2; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 2)
                {
                    x += "TC-";
                }

            }

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
            }


            txtIDno.Text = z + "-" + x;
            if (txtIDno.Text == x)
            {
                x = null;
            }

        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender,e);
            disable();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }
    

        void enable()
        {
            txtName.Enabled = true;
            txtMI.Enabled = true;
            txtLastName.Enabled = true;
            cmbStatus.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtAge.Enabled = true;
            txtTelephone.Enabled = true;
            cmbGender.Enabled = true;
            txtHAddress.Enabled = true;
            txtCAddress.Enabled = true;
            txtPBirth.Enabled = true;
        }

        void disable()
        {
            txtName.Enabled = false;
            txtMI.Enabled = false;
            txtLastName.Enabled = false;
            cmbStatus.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtAge.Enabled = false;
            txtTelephone.Enabled = false;
            cmbGender.Enabled = false;
            txtHAddress.Enabled = false;
            txtCAddress.Enabled = false;
            txtPBirth.Enabled = false;
        }

        void clear()
        {
            txtName.Text = "";
            txtMI.Text = "";
            txtLastName.Text = "";
            cmbStatus.Text = "";
            dateTimePicker1.Text = "";
            txtAge.Text = "";
            txtTelephone.Text = "";
            cmbGender.Text = "";
            txtHAddress.Text = "";
            txtCAddress.Text = "";
            txtPBirth.Text = "";
            txtIDno.Text = "";
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIDno.Text == "" || txtName.Text == "" || txtMI.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string sql = "insert into tbl_teacher(teacherID,fname,mi,lname,status,bDate,age,telNo,gender,pBirth,hAddress,cAddress,date) values('" + txtIDno.Text + "','" + txtName.Text + "','" + txtMI.Text + "','" + txtLastName.Text + "','" + cmbStatus.Text +
                               "','" + dateTimePicker1.Text + "','" + txtAge.Text + "','" + txtTelephone.Text + "','" + cmbGender.Text + "','" + txtPBirth.Text + "','" + txtHAddress.Text + "','" + txtCAddress.Text + "','" + DateTime.Now.ToString() + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Mr/Ms " + txtName.Text + " is successfully save", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "] was successfully added to the teacher list");

                teaacherList.Items.Clear();
                txtSearch_TextChanged(sender,e);
                clear();
                disable();
                x = null;
                cm.Dispose();
                btnSave.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            teaacherList.Items.Clear();
            string sql = "Select * from tbl_teacher where fname like '" + txtSearch.Text + "%' order by fname";
                 cm = new SqlCommand(sql, cn);
                 dr = cm.ExecuteReader();
                 while (dr.Read())
                 {
                    
                     list = teaacherList.Items.Add(dr.GetValue(0).ToString());
                     list.SubItems.Add(dr.GetValue(1).ToString());
                     list.SubItems.Add(dr.GetValue(2).ToString());
                     list.SubItems.Add(dr.GetValue(3).ToString());
                     list.SubItems.Add(dr.GetValue(4).ToString());
                     list.SubItems.Add(dr.GetValue(5).ToString());
                     list.SubItems.Add(dr.GetValue(6).ToString());
                     list.SubItems.Add(dr.GetValue(7).ToString());
                     list.SubItems.Add(dr.GetValue(8).ToString());
                     list.SubItems.Add(dr.GetValue(9).ToString());
                     list.SubItems.Add(dr.GetValue(10).ToString());
                     list.SubItems.Add(dr.GetValue(11).ToString());
                 }
                 dr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            x = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enable();
            btnSave.Enabled = true;
            txtIDno.Text = "";
            txtName.Text = "";
            txtMI.Text = "";
            txtLastName.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDno.Text == "" || txtName.Text == "" || txtMI.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "update tbl_teacher set fname = '" + txtName.Text + "',mi = '" + txtMI.Text + "',lname = '" + txtLastName.Text + "',status = '" + cmbStatus.Text + "',bDate = '" + dateTimePicker1.Text + "',age = '" + txtAge.Text + "',telNo = '" + txtTelephone.Text + "',gender = '" + cmbGender.Text + "',pBirth = '" + txtPBirth.Text + "',hAddress = '" + txtHAddress.Text + "',cAddress = '" + txtCAddress.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Mr/Ms " + txtName.Text + " is successfully update", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "] was successfully updated to the teacher list");

                teaacherList.Items.Clear();
                txtSearch_TextChanged(sender, e);
                clear();
                disable();
                x = null;
                cm.Dispose();
                btnUpdate.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Convert.ToString(Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dateTimePicker1.Value.Year));
        }



    }
}
