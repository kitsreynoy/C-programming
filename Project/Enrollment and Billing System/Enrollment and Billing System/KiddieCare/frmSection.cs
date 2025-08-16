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
    public partial class frmSection : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;

        public ListViewItem list = new ListViewItem();

        frmLogin connection = new frmLogin();
        string uID, loginID;

        public frmSection()
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

        private void frmSection_Load(object sender, EventArgs e)
        {
            allList();
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
        }

        void allList()
        {
            string sql = "select * from tbl_gradeLvl";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbGradeLvl.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();

            sql = "select * from tbl_time";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbTime.Items.Add(dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString());
            }
            dr.Close();

            sql = "select * from tbl_teacher";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbAdviser.Items.Add(dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString() + " " + dr.GetValue(3).ToString());
            }
            dr.Close();

            sql = "select * from tbl_room";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbRoom.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();

            sql = "select * from tbl_section";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listSection.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(5).ToString());
            }
            dr.Close();
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSection.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_section where adviser like '" + cmbAdviser.Text + "' and room like '" + cmbRoom.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mr/Ms " + cmbAdviser.Text + " is already assigned to section " + txtSection.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "select * from tbl_section where section like '" + txtSection.Text + "'";
                cm = new SqlCommand(sql,cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This section is already added", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "select * from tbl_section where adviser like '" + cmbAdviser.Text + "' and time like '" + cmbTime.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mr/Ms " + cmbAdviser.Text + " is already assigned to " + cmbTime.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "insert into tbl_section(gradeLevel,section,adviser,room,time) values('" + cmbGradeLvl.Text + "','" + txtSection.Text + "','" + cmbAdviser.Text + "','" + cmbRoom.Text + "','" + cmbTime.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Section is successfully save", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "The section [" + txtSection.Text + "] is added");
                clear();
                listSection.Items.Clear();
                cmbGradeLvl.Items.Clear();
                cmbAdviser.Items.Clear();
                cmbRoom.Items.Clear();
                cmbTime.Items.Clear();
                allList();
                cm.Dispose();
            }
        }

        private void listSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            //cmbGradeLvl.Text = listSection.FocusedItem.Text;
            cmbGradeLvl.Text = listSection.FocusedItem.SubItems[1].Text;
            txtSection.Text = listSection.FocusedItem.SubItems[2].Text;
            cmbAdviser.Text = listSection.FocusedItem.SubItems[3].Text;
            cmbRoom.Text = listSection.FocusedItem.SubItems[4].Text;
            cmbTime.Text = listSection.FocusedItem.SubItems[5].Text;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSection.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "update tbl_section set gradeLevel = '" + cmbGradeLvl.Text + "',section = '" + txtSection.Text + "',adviser = '" + cmbAdviser.Text + "',room = '" + cmbRoom.Text + "',time = '" + cmbTime.Text + "' where secID like '" + listSection.FocusedItem.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Section is successfully updated", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "The section [" + txtSection.Text + "] is updated");
                listSection.Items.Clear();
                allList();
                cmbGradeLvl.Items.Clear();
                cmbAdviser.Items.Clear();
                cmbRoom.Items.Clear();
                cm.Dispose();
                clear();
                btnUpdate.Enabled = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtSection.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "delete from tbl_section where secID like '" + listSection.FocusedItem.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Section is successfully deleted", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "The section [" + txtSection.Text + "] is deleted");
                clear();
                listSection.Items.Clear();
                cmbGradeLvl.Items.Clear();
                cmbAdviser.Items.Clear();
                cmbRoom.Items.Clear();
                allList();
                cm.Dispose();
                btnDel.Enabled = false;
            }

        }

        void clear()
        {
            txtSection.Text = "";
            cmbAdviser.Text = "";
            cmbGradeLvl.Text = "";
            cmbRoom.Text = "";
            cmbTime.Text = "";
        }
    }
}
