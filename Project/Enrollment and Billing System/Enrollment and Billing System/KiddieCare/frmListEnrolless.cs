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
    public partial class frmListEnrolless : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        frmLogin connection = new frmLogin();
        string uID, loginID;
        public frmListEnrolless()
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

        private void cmbGrdelvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            string sql = "select * from tbl_section where gradeLevel like '" + cmbGrdelvl.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbSection.Items.Add(dr.GetValue(2).ToString());
            }
            dr.Close();
        }

        private void frmListEnrolless_Load(object sender, EventArgs e)
        {
            getGlvl();
            getSY();
        }

        void getGlvl()
        {
            string sql = "select * from tbl_gradeLvl";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbGrdelvl.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
        }

        void getSY()
        {
            string sql = "select * from tbl_sy where yrStatus like 'active'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbSy.Items.Add(dr.GetValue(1).ToString() + "-" + dr.GetValue(2).ToString());
            }
            dr.Close();
        }


        void getEnrolleesList()
        {
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            enrolleesList.Items.Clear();
            btnSearch_TextChanged(sender,e);
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            enrolleesList.Items.Clear();
            string sql = "select * from enrolleesList where sy like '" + cmbSy.Text + "' and gradeLevel like '" + cmbGrdelvl.Text + "' and section like '" + cmbSection.Text + "' and completeName like '" + btnSearch.Text + "%'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = enrolleesList.Items.Add(dr.GetValue(2).ToString()); // bill id
                list.SubItems.Add(dr.GetValue(1).ToString()); // id
                list.SubItems.Add(dr.GetValue(0).ToString()); // name
                list.SubItems.Add(dr.GetValue(10).ToString()); // time
                list.SubItems.Add(dr.GetValue(6).ToString()); // room
                list.SubItems.Add(dr.GetValue(5).ToString()); // teacher
                list.SubItems.Add(dr.GetValue(8).ToString()); // date enrolled
            }
            dr.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbGrdelvl.Text == "" || cmbSy.Text == "" || cmbSection.Text == "")
            {
                MessageBox.Show("Please select school year, grade level and section", "Christian kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmReport report = new frmReport();
                report.LoadRecord("select * from enrolleesList where sy like '" + cmbSy.Text + "' and gradeLevel like '" + cmbGrdelvl.Text + "' and section like '" + cmbSection.Text + "' and completeName like '" + btnSearch.Text + "%'");
                report.ShowDialog();
            }
            
        }

        private void cmbSy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
