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
    public partial class frmPrintList : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        string uID, loginID;
        frmLogin connection = new frmLogin();

        public frmPrintList()
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
            //cmbSection.Items.Clear();
            //string sql = "select * from tbl_section where gradeLevel like '" + cmbGrdelvl.Text + "'";
            //cm = new SqlCommand(sql, cn);
            //dr = cm.ExecuteReader();
            //while (dr.Read())
            //{
            //    cmbSection.Items.Add(dr.GetValue(2).ToString());
            //}
            //dr.Close();
        }

        void getSY()
        {
            string sql = "select * from tbl_sy order by sy";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbSy.Items.Add(dr.GetValue(1).ToString() + "-" + dr.GetValue(2).ToString());
            }
            dr.Close();
        }

        private void frmPrintList_Load(object sender, EventArgs e)
        {
            getSY();
            //getGlvl();
        }

        //void getGlvl()
        //{
        //    string sql = "select * from tbl_gradeLvl";
        //    cm = new SqlCommand(sql, cn);
        //    dr = cm.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        cmbGrdelvl.Items.Add(dr.GetValue(1).ToString());
        //    }
        //    dr.Close();
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getList();
            frmReport report = new frmReport();
            report.LoadRecord1("select * from enrolleesList where sy like '" + cmbSy.Text + "' order by completeName");
            report.ShowDialog();
        }

        void getList()
        {
            string sql = "select * from enrolleesList where sy like '" + cmbSy.Text + "' order by completeName";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dr.GetValue(0).ToString();
                dr.GetValue(1).ToString();
            }
            dr.Close();
        }

     
    }
}
