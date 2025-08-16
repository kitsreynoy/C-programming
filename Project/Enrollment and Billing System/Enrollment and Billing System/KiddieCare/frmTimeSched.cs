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
    public partial class frmTimeSched : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        public frmTimeSched()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void btnTsched_Click(object sender, EventArgs e)
        {
            if (cmbSession.Text == "" || cboTime.Text == "" || txtCapacity.Text == "" || cmbRoom.Text == "" || cmbGradeLevel.Text == "")
            {
                MessageBox.Show("Please input the empty fields!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "select * from tbl_schedule where time like '" + cboTime.Text + "' and sessiontype like '" + cmbSession.Text + "' and room like '"
                                + cmbRoom.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This schedule is already assigned by " + dr[5].ToString() + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                dr.Close();


                sql = "insert into tbl_schedule(time,sessiontype,room,capacity,gradelevel) values('" + cboTime.Text + "','" + cmbSession.Text + "','"
                    + cmbRoom.Text + "','" + txtCapacity.Text + "','" + cmbGradeLevel.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successfuly Save!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                schedList.Items.Clear();
                schedule();
                cm.Dispose();

            }
            
            
        }

        private void schedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTime.Text = schedList.FocusedItem.SubItems[1].Text;
            cmbSession.Text = schedList.FocusedItem.SubItems[2].Text;
            cmbRoom.Text = schedList.FocusedItem.SubItems[3].Text;
            txtCapacity.Text = schedList.FocusedItem.SubItems[4].Text;
            cmbGradeLevel.Text = schedList.FocusedItem.SubItems[5].Text;
            
        }

        private void frmTimeSched_Load(object sender, EventArgs e)
        {
            schedule();
            ListRooms();
            ListGradeLvl();
        }

        void ListRooms()
        {
            string sql = "Select * from tbl_room";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbRoom.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        void ListGradeLvl()
        {
            
            string sql = "Select * from tbl_gradeLvl";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbGradeLevel.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        void schedule()
        {
            string sql = "Select * from tbl_schedule";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = schedList.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(5).ToString());
            }
            dr.Close();
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSession.SelectedIndex == 0)
            {
                cboTime.Items.Clear();
                string sql = "select * from tbl_time where dayPart like '" + cmbSession.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cboTime.Items.Add(dr[1].ToString());
                }
                dr.Close();
            }
            else if (cmbSession.SelectedIndex == 1)
            {
                cboTime.Items.Clear();
                string sql = "select * from tbl_time where dayPart like '" + cmbSession.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cboTime.Items.Add(dr[1].ToString());
                }
                dr.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbSession.Text == "" || cboTime.Text == "" || txtCapacity.Text == "" || cmbRoom.Text == "" || cmbGradeLevel.Text == "")
            {
                MessageBox.Show("Please select schedule", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "Update tbl_schedule set time = '" + cboTime.Text + "',sessionType = '" + cmbSession.Text + "',room = '" + cmbRoom.Text + "',capacity = '" + txtCapacity.Text + "',gradelevel = '" + cmbGradeLevel.Text + "' where schedID like '" + schedList.FocusedItem.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Schedule is successfuly update", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                schedList.Items.Clear();
                schedule();
                cm.Dispose();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
