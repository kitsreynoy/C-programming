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
    public partial class maintenance : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        public maintenance()
        {
            InitializeComponent();

        }

        private void listNursery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelRooms_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_room where Room like '" + txtRoom.Text + "'";
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfuly Delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listRoom.Items.Clear();
            listRoom.Columns.Clear();
            ListRooms();
            cm.Dispose();
            txtRoom.Text = "";

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtRoom.Text == listRoom.FocusedItem.Text)
            {
                MessageBox.Show("The room name is already declaire", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoom.Text = "";
                return;
                
            }
            else
            {
                string sql = "Insert into tbl_room(Room) values('" + txtRoom.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successfuly Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listRoom.Items.Clear();
                listRoom.Columns.Clear();
                ListRooms();
                cm.Dispose();
                txtRoom.Text = "";

            }
        }

        private void txtTuition_TextChanged(object sender, EventArgs e)
        {
            if (txtTuition.Text == "")
            {
                txtTuition.Text = "0";
            }

            txtDown.Text = (Convert.ToDouble(txtTuition.Text) * 0.181818).ToString("#0.00");
            compute();
        }

        void compute()
        {
            txtSecond.Text = ((Convert.ToDouble(txtTuition.Text) - Convert.ToDouble(txtDown.Text)) / 4).ToString("#0.00");
            txtThird.Text = txtSecond.Text;
            txtFourth.Text = txtSecond.Text;
            txtFifth.Text = txtSecond.Text;
        }

        private void btnSaveMainten_Click(object sender, EventArgs e)
        {

            string sql = "Update tbl_Payment set Amount = '" + txtDown.Text + "' where Particular like 'downpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtSecond.Text + "' where Particular like 'secondpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtThird.Text + "' where Particular like 'thirdpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtFourth.Text + "' where Particular like 'fourthpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            sql = "";
            sql = "Update tbl_Payment set Amount = '" + txtFifth.Text + "' where particular like 'fifthpayment'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();

            MessageBox.Show("Successfully Save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        void getTime() 
        {
            cboTime.Items.Clear();
            string sql = "select * from tbl_time";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                cboTime.Items.Add(dr[1].ToString());
            }
            dr.Close();
        }

        private void maintenance_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection.constring);
            cn.Open();
            ListRooms();
            ListGradeLvl();
            timeSched();
            //getTime();
        }

        private void btnUpdateMainten_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtDown.Text = "";
            txtTuition.Text = "";
            txtSecond.Text = "";
            txtFourth.Text = "";
            txtThird.Text = "";
            txtFifth.Text = "";
        }

        private void btnAddLvl_Click(object sender, EventArgs e)
        {
            if (txtGradeLvl.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtGradeLvl.Text == listGradeLvl.FocusedItem.Text)
            {
                MessageBox.Show("The Grade level name is already declaire", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGradeLvl.Text = "";
                return;

            }
            else
            {
                string sql = "insert into tbl_gradeLvl(GradeLvl) values('" + txtGradeLvl.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successfuly Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listGradeLvl.Items.Clear();
                listGradeLvl.Columns.Clear();
                ListGradeLvl();
                cm.Dispose();
                txtGradeLvl.Text = "";

            }

        }

        void ListGradeLvl()
        {
            listGradeLvl.Columns.Add("Grade level", 500);

            string sql = "Select * from tbl_gradeLvl";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                listGradeLvl.Items.Add(dr.GetValue(1).ToString());
                cmbGradeLevel.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        void ListRooms() 
        {
            
            listRoom.Columns.Add("Room", 500);

            string sql = "Select * from tbl_room";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                listRoom.Items.Add(dr.GetValue(1).ToString());

            }
            dr.Close();

            string sql2 = "Select * from tbl_room";
            cm = new SqlCommand(sql2, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                cmbRoom.Items.Add(dr.GetValue(0).ToString());

            }
            dr.Close();
        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.Text = listRoom.FocusedItem.Text;
        }

        private void listGradeLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGradeLvl.Text = listGradeLvl.FocusedItem.Text;
        }

        private void btnTsched_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_schedule where time like '" + cboTime.Text + "' and sessiontype like '" + cmbSession.Text + "' and room like '" 
                + cmbRoom.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows) 
            {
                MessageBox.Show("This schedule is already assigned by " + dr[5].ToString() + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                return;
            }
            dr.Close();
            //if (cmbSession.SelectedItem == "Morning")
            //{
            //    string sql = "insert into tbl_sMorning(Morning) values('" + txtAM.Text + "-" + txtPM.Text + "')";
            //    cm = new SqlCommand(sql, cn);
            //    cm.ExecuteNonQuery();
            //    MessageBox.Show("Successfuly Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cm.Dispose();
            //    timeSched();
            //    listAM.Items.Clear();
            //    listAM.Columns.Clear();
            //    timeSched();
            //    txtPM.Text = "0:00 PM";
            //    txtAM.Text = "0.00 AM";
            //}
            //else if (cmbSession.SelectedItem == "Afternoon")
            //{
            //    string sql = "insert into tbl_sAfternun(Afternoon) values('" + txtAM.Text + "-" + txtPM.Text + "')";
            //    cm = new SqlCommand(sql, cn);
            //    cm.ExecuteNonQuery();
            //    MessageBox.Show("Successfuly Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cm.Dispose();
            //    timeSched();
            //    listPM.Items.Clear();
            //    listPM.Columns.Clear();
                
            //    txtPM.Text = "0:00 PM";
            //    txtAM.Text = "0.00 AM";

            //}
            //else
            //{

            //}
            sql = "insert into tbl_schedule(time,sessiontype,room,capacity,gradelevel) values('" + cboTime.Text + "','" + cmbSession.Text + "','" 
                + cmbRoom.Text + "','" + txtCapacity.Text + "','" + cmbGradeLevel.Text + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            MessageBox.Show("Successfuly Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        void timeSched()
        {
            listPM.Columns.Add("Afternoon Session", 250);
            listAM.Columns.Add("Morning Session", 250);


                string sql = "Select * from tbl_sMorning";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                   
                    listAM.Items.Add(dr.GetValue(0).ToString());

                }
                dr.Close();

                 sql = "Select * from tbl_sAfternun";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    
                    listPM.Items.Add(dr.GetValue(0).ToString());

                }
                dr.Close();
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbl_time(time,dayPart) values('" + (txtFrom.Text + "-" + txtTo.Text) + "','" + cmbDayPart.Text + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            getTime();
            MessageBox.Show("Successfuly Save!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_Payment set dueDate = '" + dateTimePicker1.Text + "' where Particular like '" + cmbParticular.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            MessageBox.Show("Successfuly Save!", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void cmbParticular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
