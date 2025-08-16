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
    public partial class frmReadyEnroll : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();
        frmEnrollment enroll = null;

        string id, name, lvl, bill, sy, status, sy_1;

        public frmReadyEnroll(frmEnrollment enroll)
        {
            InitializeComponent();
            this.enroll = enroll;
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getSy();
            readyList.Items.Clear();
            readyList.Columns.Clear();
            readyList.Columns.Add("Student ID", 150);
            readyList.Columns.Add("Student Name", 200);

            string sql = "SELECT DISTINCT ID, completeName FROM pPupil where completeName like '" + txtSearch.Text + "%' and sy like '" + sy_1 + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = readyList.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());

            }
            dr.Close();
        }

        private void frmReadyEnroll_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender,e);
        }

        private void readyList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        void getSy()
        {
            string sql = "Select * from tbl_sy where yrStatus like 'active'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                sy_1 = dr.GetValue(3).ToString();
            }
            dr.Close();
        }

        private void readyList_DoubleClick(object sender, EventArgs e)
        {
            string oGradeLevel, sGradeLevel;
            getSy();

            string sql = "Select * from pPupil where ID like '" + readyList.FocusedItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                id = dr.GetValue(0).ToString();
                name = dr.GetValue(1).ToString();
                lvl = dr.GetValue(2).ToString();
                bill = dr.GetValue(4).ToString();
                sy = dr.GetValue(6).ToString();
            }
            dr.Close();


            //sql = "Select * from enrolleesList where ID like '" + readyList.FocusedItem.Text + "'";
            //cm = new SqlCommand(sql, cn);
            //dr = cm.ExecuteReader();
            //dr.Read();
            //if (dr.HasRows)
            //{
            //    lvl = dr.GetValue(8).ToString();
            //    sy = dr.GetValue(3).ToString();

            //    if (lvl == "Nursery")
            //    {
            //        if (MessageBox.Show("Move to the next level?", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            oGradeLevel = "Kinder I";
            //        }
            //        else
            //        {
            //            oGradeLevel = "Nursery";
            //        }
            //    }

            //    if (lvl == "Kinder I")
            //    {
            //        if (MessageBox.Show("Move to the next level?", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            oGradeLevel = "Kinder II";
            //        }
            //        else
            //        {
            //            oGradeLevel = "Kinder I";
            //        }
            //    }

            //    if (lvl == "Kinder II")
            //    {
            //        if (sy == sy_1)
            //        {
            //            status = "Enrolled";
            //        }
            //        else
            //        {
            //            status = "Not yet Enrolled";
            //        }
            //    }


            //    //dr.Close();
            //    //frmEnrollment inday = new frmEnrollment();

            //    //sql = "Select * from tbl_billing where ID like '" + readyList.FocusedItem.Text + "'";
            //    //cm = new SqlCommand(sql, cn);
            //    //dr = cm.ExecuteReader();
            //    //dr.Read();
            //    //if (dr.HasRows)
            //    //{
            //    //    do
            //    //    {

            //    //        inday.lblBalance.Text = dr.GetValue(8).ToString();

            //    //    } while (dr.Read());
            //    //}
            //    //else
            //    //{
            //    //    inday.lblBalance.Text = "0.00";
            //    //}
               
            //}
            

            
            //dr.Close();


            //oGradeLevel = lvl;

            

            sql = "Select * from tbl_enroll where ID like '" + readyList.FocusedItem.Text + "' and sy like '" + sy + "' ";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                status = "Enrolled";
            }
            else
            {
                status = "Not yet Enrolled";
            }

            enroll.readyToEnroll(id, name, lvl, bill, sy, status);
            this.Close();
        }

        private void readyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
