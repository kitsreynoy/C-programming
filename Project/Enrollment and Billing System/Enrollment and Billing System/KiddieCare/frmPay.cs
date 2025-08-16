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
    public partial class frmPay : Form
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        double amountPay, urMoney, total, tAmount, tBook, tTotal;
        double Bal = 0;
        bool session;
        string yr,sessiontype="";

        public frmPay()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            Room();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmList list = new frmList();
            //list.Show();
        }

        public void studPay(string pID, string pName, string pMi, string pLast)
        {
            txtIDSearch.Text = pID;
            txtName.Text = pName;
            txtMI.Text = pMi;
            txtLastname.Text = pLast;
        }

        private void rbMorning_CheckedChanged(object sender, EventArgs e)
        {
            sessiontype = "Morning";
            //cmbTimeSched.Items.Add("8:00am - 10:00am");
            //cmbTimeSched.Items.Add("10:00am - 12:00nn");
            session = true;
            cmbTimeSched.Text = "";
            cmbTimeSched.Items.Clear();
            string sql = "select * from tbl_schedule where sessiontype like 'Morning' and capacity != 0 and gradelevel like '" + cmbGradeLvl.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                cmbTimeSched.Items.Add(dr[1].ToString());
                //txtRoom.Text = dr[3].ToString();
                //txtSlots.Text = dr[4].ToString();
            }
            dr.Close();
            
        }

        private void rbAfternun_CheckedChanged(object sender, EventArgs e)
        {
            //cmbTimeSched.Items.Clear();
            //cmbTimeSched.Items.Add("1:00pm - 3:00pm");
            //cmbTimeSched.Items.Add("3:00pm - 5:00pm");
            //session = false;
            sessiontype = "Afternoon";
            cmbTimeSched.Text = "";
            string sql = "select * from tbl_schedule where sessiontype like 'Afternoon' and capacity != 0 and gradelevel like '" + cmbGradeLvl.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbTimeSched.Items.Add(dr[1].ToString());
                //txtRoom.Text = dr[3].ToString();
                //txtSlots.Text = dr[4].ToString();
            }
            dr.Close();
        }

        void Room()
        {
            string sql = "Select * from tbl_room";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();

            while(dr.Read())
            {
                cmbRoom.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();
        }

        private void txtSy1_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            SchoolYear();
            grdlvl();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Downpayment")
            {
                updateDownpayment();
            }
            else if(comboBox1.Text == "2ndPayment")
            {
                update2ndPayment();
            }
            else if(comboBox1.Text == "3rdPayment")
            {
                update3rdPayment();
            }
            else if (comboBox1.Text == "4thPayment")
            {
                update4thpayment();
            }
            else if (comboBox1.Text == "5thPayment")
            {
                update5thpayment();
            }


        }

        void updateDownpayment()
        {
            string sql = "update tbl_Down set AmtPaid = '" + txtAmtTendered.Text + "',balance = '" + txtBalance.Text + "' where Particular like 'Downpayment' and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void update2ndPayment()
        {
            string sql = "update tbl_Down set AmtPaid = '" + txtAmtTendered.Text + "',balance = '" + txtBalance.Text + "' where Particular like '2ndPayment' and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void update3rdPayment()
        {
            string sql = "update tbl_Down set AmtPaid = '" + txtAmtTendered.Text + "',balance = '" + txtBalance.Text + "' where Particular like '3rdPayment' and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void update4thpayment()
        {
            string sql = "update tbl_Down set AmtPaid = '" + txtAmtTendered.Text + "',balance = '" + txtBalance.Text + "' where Particular like '4thPayment' and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void update5thpayment()
        {
            string sql = "update tbl_Down set AmtPaid = '" + txtAmtTendered.Text + "',balance = '" + txtBalance.Text + "' where Particular like '5thPayment' and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }


        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from tbl_Down where AmtPaid like 0 and studID like '" + txtIDSearch.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(1).ToString());

            }
            dr.Close();


            sql = "select sum(AmtDue) from tbl_Down where studID like '" + txtIDSearch.Text + "' and AmtPaid like 0";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Bal = Convert.ToDouble(dr.GetValue(0).ToString());
                // dr.GetValue(0);
            }
            dr.Close();

            txtTotBal.Text = Convert.ToString(Bal);

            sql = "select sum(Amount) from tbl_Payment";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtTutionFee.Text = (dr.GetValue(0).ToString());
                // dr.GetValue(0);
            }
            dr.Close();

            txtTotBal.Text = Convert.ToString(Bal);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Downpayment")
            {
              
                string sql = "select * from tbl_Down where Particular like '" + comboBox1.Text + "' and studID like '" + txtIDSearch.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtAmtDue.Text = dr.GetValue(2).ToString();
                }
                dr.Close();
            }

            else
            {
              
                string sql = "select * from tbl_Down where Particular like '" + comboBox1.Text + "' and studID like '" + txtIDSearch.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtAmtDue.Text = dr.GetValue(6).ToString();
                }
                dr.Close();
            }
        }

        private void txtAmtTendered_TextChanged(object sender, EventArgs e)
        {
            if (txtAmtTendered.Text == "")
            {
                txtAmtTendered.Text = "";
                txtBalance.Text = "0";
            }
            else
            {
                txtBalance.Text = Convert.ToString(Convert.ToDouble(txtAmtDue.Text) - Convert.ToDouble(txtAmtTendered.Text));
            }
        }

        private void cmbTimeSched_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from tbl_schedule where sessiontype like '" + sessiontype + "' and capacity != 0 and gradelevel like '" + cmbGradeLvl.Text + "' and time like '" + cmbTimeSched.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows) 
            {
                txtRoom.Text = dr[3].ToString();
                txtSlots.Text = dr[4].ToString();
            }
            dr.Close();
        }

        private void cmbYr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void SchoolYear()
        {
            string sql = "select * from tbl_sy where yrStatus like 'Active'";
          //  string sql = "Select * from tbl_sy";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cmbYr.Items.Add(dr.GetValue(1).ToString() + "-" + dr.GetValue(2).ToString());
            }
            dr.Close();
        }

        void grdlvl()
        {
            string sql = "Select * from tbl_gradeLvl";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cmbGradeLvl.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void cmbGradeLvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
