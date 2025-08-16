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
    public partial class frmFill : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        string gender = "";
        string bmonth, bday, byear;
        string dispID, dispName, dispMI, dispLname;
        int selectedMonth = 1;

        String x = "";
        Random rand = new Random();

        public frmFill()
        {
            InitializeComponent();
        }

        private void frmFill_Load(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            cn = new SqlConnection(connection.constring);
            cn.Open();
            txtSearch_TextChanged(sender, e);
            disable();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtIDno.Text == "")
                        {
                            generateCode();
                        }
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


            txtIDno.Text = x;
            if (txtIDno.Text == x)
            {
                x = null;
            }

        }


        public void clear()
        {
            txtIDno.Text = "";
            txtName.Text = "";
            txtMI.Text = "";
            txtHomeAddress.Text = "";
            txtFathersName.Text = "";
            txtPrevSchool.Text = "";
            txtTelephone.Text = "";
            txtContactPerson.Text = "";
            txtMader.Text = "";
            txtOccupFader.Text = "";
            txtOccupMader.Text = "";
            txtReligion.Text = "";
            txtPersonBring.Text = "";
            txtNickname.Text = "";
            txtLastName.Text = "";
            //cmbGender.SelectedItem = String.Empty;
            dateTimePicker1.Text = "01/01/2000";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtIDno.Text == "" || txtName.Text == "" || txtMI.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please input the empty fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cm = cn.CreateCommand();

                cm.CommandText = "EXECUTE sp_Add @ID,@Name,@MI,@Lname,@Nickname,@Gender,@BirthDate,@HAddress,@Telephone,@PrevSchool,@Father,@OccupFa,@Mother,@OccupMa,@Religion,@ContactPerson,@PersonBring,@Dates";
                cm.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = txtIDno.Text;
                cm.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = txtName.Text;
                cm.Parameters.Add("@MI", SqlDbType.VarChar, 50).Value = txtMI.Text;
                cm.Parameters.Add("@Lname", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                cm.Parameters.Add("@Nickname", SqlDbType.VarChar, 50).Value = txtNickname.Text;
                cm.Parameters.Add("@Gender", SqlDbType.VarChar, 50).Value = cmbGender.Text;
                cm.Parameters.Add("@BirthDate", SqlDbType.VarChar, 50).Value = dateTimePicker1.Text;
                cm.Parameters.Add("@HAddress", SqlDbType.VarChar, 100).Value = txtHomeAddress.Text;
                cm.Parameters.Add("@Telephone", SqlDbType.VarChar, 50).Value = txtTelephone.Text;
                cm.Parameters.Add("@PrevSchool", SqlDbType.VarChar, 50).Value = txtPrevSchool.Text;
                cm.Parameters.Add("@Father", SqlDbType.VarChar, 50).Value = txtFathersName.Text;
                cm.Parameters.Add("@OccupFa", SqlDbType.VarChar, 50).Value = txtOccupFader.Text;
                cm.Parameters.Add("@Mother", SqlDbType.VarChar, 50).Value = txtMader.Text;
                cm.Parameters.Add("@OccupMa", SqlDbType.VarChar, 50).Value = txtOccupMader.Text;
                cm.Parameters.Add("@Religion", SqlDbType.VarChar, 50).Value = txtReligion.Text;
                cm.Parameters.Add("@ContactPerson", SqlDbType.VarChar, 50).Value = txtContactPerson.Text;
                cm.Parameters.Add("@PersonBring", SqlDbType.VarChar, 50).Value = txtPersonBring.Text;
                cm.Parameters.Add("@Dates", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString();


                cm.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm.Dispose();
                clear();
                frmFill_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
          
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            enable();


            txtIDno.Text = studentList.FocusedItem.Text;
            txtName.Text = studentList.FocusedItem.SubItems[1].Text;
            txtMI.Text = studentList.FocusedItem.SubItems[2].Text;
            txtLastName.Text = studentList.FocusedItem.SubItems[3].Text;
            txtNickname.Text = studentList.FocusedItem.SubItems[4].Text;
            cmbGender.Text = studentList.FocusedItem.SubItems[5].Text;
            dateTimePicker1.Text = studentList.FocusedItem.SubItems[6].Text;
            //getBdate1();
            //cboMonth.Text = bmonth;
            //cboDate.Text = bday;
            //cboYear.Text = byear;
            txtHomeAddress.Text = studentList.FocusedItem.SubItems[7].Text;
            txtTelephone.Text = studentList.FocusedItem.SubItems[8].Text;
            txtPrevSchool.Text = studentList.FocusedItem.SubItems[9].Text;
            txtFathersName.Text = studentList.FocusedItem.SubItems[10].Text;
            txtOccupFader.Text = studentList.FocusedItem.SubItems[11].Text;
            txtMader.Text = studentList.FocusedItem.SubItems[12].Text;
            txtOccupMader.Text = studentList.FocusedItem.SubItems[13].Text;
            txtReligion.Text = studentList.FocusedItem.SubItems[14].Text;
            txtContactPerson.Text = studentList.FocusedItem.SubItems[15].Text;
            txtPersonBring.Text = studentList.FocusedItem.SubItems[16].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            try
            {
                DialogResult del = MessageBox.Show("Are you sure you want to Delete this from the list?", "Delete Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (del == DialogResult.Yes)
                {

                    cm = cn.CreateCommand();
                    cm.CommandText = "EXECUTE sp_delStud @StudID";
                    cm.Parameters.Add("@StudID", SqlDbType.VarChar, 50).Value = studentList.FocusedItem.Text;
                    cm.ExecuteNonQuery();
                    frmFill_Load(sender, e);
                    clear();
                    MessageBox.Show("Record Successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Dispose();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //    DialogResult del = MessageBox.Show("Are you sure you want to Delete this from the list?", "Delete Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (del == DialogResult.Yes)
            //    {
            //        string sql = "delete from tbl_Student where ID like '" + txtIDno.Text + "'";
            //        cm = new SqlCommand(sql, cn);
            //        cm.ExecuteNonQuery();
            //        frmFill_Load(sender, e);
            //        clear();

            //        MessageBox.Show("Student Record has successfully deleted to the list", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }

            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

               // getBdate();
                studentList.Items.Clear();
                studentList.Columns.Clear();
                studentList.Columns.Add("ID Number", 200);
                studentList.Columns.Add("First Name", 200);
                studentList.Columns.Add("Middle Name", 200);
                studentList.Columns.Add("Last Name", 200);
                studentList.Columns.Add("Nickname", 200);
                studentList.Columns.Add("Gender", 200);
                studentList.Columns.Add("Birth Date", 200);
                studentList.Columns.Add("Home Address", 300);
                studentList.Columns.Add("Telephone Number", 200);
                studentList.Columns.Add("Previous school", 200);
                studentList.Columns.Add("Father's Name", 200);
                studentList.Columns.Add("Father's Occupation", 200);
                studentList.Columns.Add("Mother's Name", 200);
                studentList.Columns.Add("Mother's Occupation", 200);
                studentList.Columns.Add("Religion", 200);
                studentList.Columns.Add("Contact person in case of emergency", 300);
                studentList.Columns.Add("Person who will regularly bring/fetch the child in school", 400);


                string sql = "Select * from tbl_Student where Name like '" + txtSearch.Text + "%'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //studentList.Items.Clear();
                    //studentList.Columns.Clear();
                    list = studentList.Items.Add(dr.GetValue(0).ToString());
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
                    list.SubItems.Add(dr.GetValue(12).ToString());
                    list.SubItems.Add(dr.GetValue(13).ToString());
                    list.SubItems.Add(dr.GetValue(14).ToString());
                    list.SubItems.Add(dr.GetValue(15).ToString());
                    list.SubItems.Add(dr.GetValue(16).ToString());

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnNew.Enabled = true;


            if (txtLastName.Text == "" || txtName.Text == "" || txtMI.Text == "")
            {
                MessageBox.Show("Missing Required Field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {

                string sql = "Update tbl_StudentInfo set Name = '" + txtName.Text + "',MI = '" + txtMI.Text + "',Lname = '" + txtLastName.Text + "',Nickname = '" + txtNickname.Text + "',Gender = '" + cmbGender.Text + "',BirthDate = '" + dateTimePicker1.Text 
                                                                   + "',Address = '" + txtHomeAddress.Text + "',Telephone = '" + txtTelephone.Text + "',PrevSchool = '" + txtPrevSchool.Text + "',Father = '" + txtFathersName.Text + "',OccupFa = '" + txtOccupFader.Text
                                                                   + "', Mother = '" + txtMader.Text + "',OccupMa = '" + txtOccupMader.Text + "',Religion = '" + txtReligion.Text + "',ContactPerson = '" + txtContactPerson.Text + "',PersonBring = '" + txtPersonBring.Text + "' where ID like '" + txtIDno.Text + "'";

                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record are successfuly saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                frmFill_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = true;
            btnSave.Enabled = true;
            enable();
            clear();
        }

        void enable()
        {
            dateTimePicker1.Enabled = true;
            // txtIDno.Enabled = true;
            txtName.Enabled = true;
            txtMI.Enabled = true;
            txtLastName.Enabled = true;
            txtHomeAddress.Enabled = true;
            txtFathersName.Enabled = true;
            txtMader.Enabled = true;
            txtOccupFader.Enabled = true;
            txtOccupMader.Enabled = true;
            txtPersonBring.Enabled = true;
            txtPrevSchool.Enabled = true;
            txtReligion.Enabled = true;
            txtNickname.Enabled = true;
            cmbGender.Enabled = true;
            
            txtTelephone.Enabled = true;
            txtContactPerson.Enabled = true;
        }

        void disable()
        {


            txtIDno.Enabled = false;
            txtName.Enabled = false;
            txtMI.Enabled = false;
            txtLastName.Enabled = false;
            txtHomeAddress.Enabled = false;
            txtFathersName.Enabled = false;
            txtMader.Enabled = false;
            txtOccupFader.Enabled = false;
            txtOccupMader.Enabled = false;
            txtPersonBring.Enabled = false;
            txtPrevSchool.Enabled = false;
            txtReligion.Enabled = false;
            txtNickname.Enabled = false;
            cmbGender.Enabled = false;
            
            txtTelephone.Enabled = false;
            txtContactPerson.Enabled = false;
            dateTimePicker1.Enabled = false;


        }


    }
}
