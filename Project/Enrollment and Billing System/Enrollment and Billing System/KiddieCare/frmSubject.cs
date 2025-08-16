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
    public partial class frmSubject : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;

        public ListViewItem list = new ListViewItem();

        frmLogin connection = new frmLogin();

        public frmSubject()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();

        }

        void getGradeLvl()
        {
            string sql = "select * from tbl_gradeLvl";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbGradeLvl.Items.Add(dr.GetValue(1).ToString());
                cmbFilterSub.Items.Add(dr.GetValue(1).ToString());

               
            }
            dr.Close();

        }
        void viewList()
        {

            listSubject.Items.Clear();
            string sql = "select * from tbl_subject where GradeLevel like '" + cmbFilterSub.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list = listSubject.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                
                
            }
            dr.Close();
        }





        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_subject where subject like '" + txtSubject.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Subject is successfully deleted to " + cmbGradeLvl.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cm.Dispose();
            txtSubject.Text = "";
            listSubject.Items.Clear();
            viewList();
            btnDel.Enabled = false;
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            getGradeLvl();
            btnDel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbGradeLvl.Text == "" || txtSubject.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_subject where subject like '" + txtSubject.Text + "'";
                cm = new SqlCommand(sql,cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("The "+ txtSubject.Text + " is already added to " + cmbGradeLvl.Text + "","Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSubject.Text = "";
                    dr.Close();
                    return;
                }
                dr.Close();


                sql = "insert into tbl_subject(GradeLevel,subject) values('" + cmbGradeLvl.Text + "','" + txtSubject.Text + "')";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Subject is successfully assigned to " + cmbGradeLvl.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm.Dispose();
                txtSubject.Text = "";
                btnDel.Enabled = false;

            }
        }

        private void cmbFilterSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewList();
        }

        private void listSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSubject.Text = listSubject.FocusedItem.SubItems[1].Text;
            cmbGradeLvl.Text = listSubject.FocusedItem.SubItems[2].Text;
            btnDel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbGradeLvl.Text == "" || txtSubject.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_subject where subject like '" + txtSubject.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("The " + txtSubject.Text + " is already added to " + cmbGradeLvl.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSubject.Text = "";
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "update tbl_subject set subject = '" + txtSubject.Text + "' where id like '" + listSubject.FocusedItem.Text + "'";
                cm = new SqlCommand(sql,cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Subject is successfully updated to " + cmbGradeLvl.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm.Dispose();
                txtSubject.Text = "";
                listSubject.Items.Clear();
                viewList();
                btnDel.Enabled = false;
            }
        }
    }
}
