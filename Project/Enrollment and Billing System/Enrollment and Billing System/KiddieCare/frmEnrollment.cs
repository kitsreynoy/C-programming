using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace KiddieCare
{
    public partial class frmEnrollment : Form
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();
        String x = "";
        Random rand = new Random();
        string sectionID = "", uID, loginID;

        public frmEnrollment()
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

        private void frmEnrollment_Load(object sender, EventArgs e)
        {
            generateCode();

        }

        public void generateCode()
        {

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 3)
                {
                    x += "-";
                }
            }

            for (int y = 1; y <= 4; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 4)
                {
                    x += "-";
                }

            }

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
            }


            lblORNo.Text = x;
            if (lblORNo.Text == x)
            {
                x = null;
            }

        }

        void getYr()
        {
            try
            {
                string sql = "select * from tbl_sy where yrStatus like 'Active'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtSy.Text = dr.GetValue(1).ToString() + "-" + dr.GetValue(2).ToString();
                }
                dr.Close();
            }
            catch (Exception ee) { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmReadyEnroll ready = new frmReadyEnroll(this);
            ready.ShowDialog();
            cmbTime.Items.Clear();
            cmbSection.Items.Clear();
            txtGlvl_TextChanged(sender,e);
        }

        public void readyToEnroll(string id, string name, string lvl, string bill, string sy, string status)
        {
            txtBillID.Text = bill;
            lblID.Text = id;
            lblName.Text = name;
            txtSy.Text = sy;
            txtGlvl.Text = lvl;
            lblStatus.Text = status;

            if (lblStatus.Text == "Enrolled")
            {
                clear(); 
                btnSave.Enabled = false;
                txtBillID.Text = bill;
                lblID.Text = id;
                lblName.Text = name;
                lblStatus.Text = status;

                txtSy.Enabled = false;
                txtRoom.Enabled = false;
                cmbSection.Enabled = false;
                cmbTime.Enabled = false;
                txtGlvl.Enabled = false;
                txtAdviser.Enabled = false;

            }
            else if (lblStatus.Text == "Not yet Enrolled") 
            {
                btnSave.Enabled = true;
                txtSy.Enabled = true;
                txtRoom.Enabled = true;
                cmbSection.Enabled = true;
                cmbTime.Enabled = true;
                txtGlvl.Enabled = true;
                txtAdviser.Enabled = true;
            
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGlvl_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from tbl_section where gradeLevel like '" + txtGlvl.Text + "' ";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbSection.Items.Add(dr.GetValue(2).ToString());
                txtAdviser.Text = dr.GetValue(3).ToString();
                txtRoom.Text = dr.GetValue(4).ToString();
                cmbTime.Items.Add(dr.GetValue(5).ToString());
            }
            dr.Close();

            

            //if (lblStatus.Text == "Not yet Enrolled")
            //{

            //}
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from tbl_section where section like '" + cmbSection.Text+ "' ";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                sectionID = dr.GetValue(0).ToString();
            }
            dr.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show("Please search student to be enroll", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string sql = "insert into tbl_enroll(enrollID,sy,ID,secID,dateEnroll,time) values('" + lblORNo.Text + "','" + txtSy.Text + "','" + lblID.Text + "','" + sectionID + "','" + DateTime.Now.ToString() + "','" + cmbTime.Text + "')";
                    cm = new SqlCommand(sql,cn);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Mr/Ms " + lblName.Text + " is successfully enrolled", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    auditrail(uID, "Mr/Ms " + lblName.Text + " is successfully enrolled");

                    cm.Dispose();
                    clear();
                }
                catch (Exception ee)
                {
                }
            }
            
        }

        void clear()
        {
            txtBillID.Text = "";
            lblName.Text = "";
            lblStatus.Text = "";
            lblID.Text = "";
            txtSy.Text = "";
            txtRoom.Text = "";
            cmbSection.Text = "";
            cmbTime.Text = "";
            txtGlvl.Text = "";
            txtAdviser.Text = "";
        }

        void alreadyEnroll()
        {
            
        }

        private void txtBillID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void lblStatus_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from pPupil where ID like '" + lblID.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                byte[] img = (byte[])(dr.GetValue(3));
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            dr.Close();

        }
    }
}
