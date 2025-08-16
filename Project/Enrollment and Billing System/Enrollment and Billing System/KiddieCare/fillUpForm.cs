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
    public partial class fillUpForm : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        string imgLoc = "";
        bool isCLicked = false;
        string uID, loginID;
        String x = "";
        Random rand = new Random();
        OpenFileDialog open = new OpenFileDialog();

        public fillUpForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtIDno.Text == "")
            {
                generateCode();
            }
        }

        public void dawat0(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }


         void generateCode()
        {
            string z = Convert.ToString(DateTime.Now.Year);

            for (int y = 1; y <= 2; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 2)
                {
                    x += "C-";
                }

            }

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
            }


            txtIDno.Text =  z + "-" + x;
            if (txtIDno.Text == x)
            {
                x = null;
            }

        }


         public void auditrail(string ID, string action)
         {
             string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
             cm = new SqlCommand(sql, cn);
             cm.ExecuteNonQuery();
         }


         private void btnSave_Click(object sender, EventArgs e)
         {
             byte[] img = null;
             FileStream fs;
             BinaryReader br;

             if (txtIDno.Text == "" || txtName.Text == "" || txtMI.Text == "" || txtLastName.Text == "")
             {
                 MessageBox.Show("Please input the empty fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

                 try
                 {

                     if (radioButton1.Checked == true)
                     {
                         if (isCLicked == false)
                         {
                             imgLoc = Environment.CurrentDirectory + @"\emptyProfile.jpg";
                             fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                             br = new BinaryReader(fs);
                             img = br.ReadBytes((int)fs.Length);
                         }
                         else
                         {
                             fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                             br = new BinaryReader(fs);
                             img = br.ReadBytes((int)fs.Length);
                         }

                         string sql = "insert into tbl_Student(ID,Name,MI,Lname,completeName,HAddress,DateBirth,Age,TellNum,Gender,Guardian,PAddress,Contact,Dates,studentStand,levelType) values('" + txtIDno.Text + "','" + txtName.Text + "','" + txtMI.Text + "','" + txtLastName.Text + "','" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text +
                                    "','" + txtHomeAddress.Text + "','" + dateTimePicker1.Text + "','" + txtAge.Text + "','" + txtTelephone.Text + "','" + cmbGender.Text + "','" + txtGuard.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + DateTime.Now.ToString() + "','" + radioButton1.Text + "','" + cmbLvlType.Text + "')";
                         cm = new SqlCommand(sql, cn);
                         cm.ExecuteNonQuery();
                         MessageBox.Show("Record Successfully Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         cm = cn.CreateCommand();
                         cm.CommandText = "EXECUTE sp_Add @ID,@pix";
                         cm.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = txtIDno.Text;
                         cm.Parameters.Add("@pix", SqlDbType.Image).Value = img;
                         cm.ExecuteNonQuery();
                         
                         cm.Dispose();
                         fillUpForm_Load(sender, e);

                         auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "] was successfully added to the student list");

                         x = null;
                         cmbLvlType.Items.Clear();
                         getLvl();
                         clear();
                         pictureBox1.Image = (System.Drawing.Image)(Properties.Resources.images);
                         return;
                     }

                     if (radioButton2.Checked == true)
                     {
                         if (isCLicked == false)
                         {
                             imgLoc = Environment.CurrentDirectory + @"\emptyProfile.jpg";
                             fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                             br = new BinaryReader(fs);
                             img = br.ReadBytes((int)fs.Length);
                         }
                         else
                         {
                             fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                             br = new BinaryReader(fs);
                             img = br.ReadBytes((int)fs.Length);
                         }

                         string sql = "insert into tbl_Student(ID,Name,MI,Lname,completeName,HAddress,DateBirth,Age,TellNum,Gender,Guardian,PAddress,Contact,Dates,studentStand,levelType) values('" + txtIDno.Text + "','" + txtName.Text + "','" + txtMI.Text + "','" + txtLastName.Text + "','" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text +
                                    "','" + txtHomeAddress.Text + "','" + dateTimePicker1.Text + "','" + txtAge.Text + "','" + txtTelephone.Text + "','" + cmbGender.Text + "','" + txtGuard.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + DateTime.Now.ToString() + "','" + radioButton2.Text + "','" + cmbLvlType.Text + "')";
                         cm = new SqlCommand(sql, cn);
                         cm.ExecuteNonQuery();
                         MessageBox.Show("Record Successfully Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                         cm = cn.CreateCommand();
                         cm.CommandText = "EXECUTE sp_Add @ID,@pix";
                         cm.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = txtIDno.Text;
                         cm.Parameters.Add("@pix", SqlDbType.Image).Value = img;
                         cm.ExecuteNonQuery();
                         
                         
                         cm.Dispose();
                         clear();
                         fillUpForm_Load(sender, e);
                         x = null;
                         cmbLvlType.Items.Clear();
                         getLvl();
                         pictureBox1.Image = (System.Drawing.Image)(Properties.Resources.images);
                        return;


                     }

                     //string sql = "insert into tbl_enroll(ID,Name,lvltype) values('" + txtIDno.Text + "','" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "','" + cmbLvlType.Text + "')";
                     //cm = new SqlCommand(sql, cn);
                     //cm.ExecuteNonQuery();
                     //cm.Dispose();
                     

                     //cm = cn.CreateCommand();
                     //cm.CommandText = "EXECUTE sp_Add @ID,@pix";
                     //cm.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = txtIDno.Text;
                     //cm.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = txtName.Text;
                     //cm.Parameters.Add("@MI", SqlDbType.VarChar, 50).Value = txtMI.Text;
                     //cm.Parameters.Add("@Lname", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                     //cm.Parameters.Add("@HAddress", SqlDbType.VarChar, 100).Value = txtHomeAddress.Text;
                     //cm.Parameters.Add("@DateBirth", SqlDbType.VarChar, 50).Value = dateTimePicker1.Text;
                     //cm.Parameters.Add("@Age", SqlDbType.VarChar, 50).Value = txtAge.Text;
                     //cm.Parameters.Add("@TellNum", SqlDbType.VarChar, 50).Value = txtTelephone.Text;
                     //cm.Parameters.Add("@Gender", SqlDbType.VarChar, 50).Value = cmbGender.Text;
                     //cm.Parameters.Add("@Guardian", SqlDbType.VarChar, 50).Value = txtGuard.Text;
                     //cm.Parameters.Add("@PAddress", SqlDbType.VarChar, 50).Value = txtAddress.Text;
                     //cm.Parameters.Add("@Contact", SqlDbType.VarChar, 50).Value = txtContact.Text;
                     //cm.Parameters.Add("@Dates", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 
            

            
            
         }

         private void btnNew_Click(object sender, EventArgs e)
         {
             btnGenerate.Enabled = true;
             btnSave.Enabled = true;
             enable();
             clear();
             btnNew.Enabled = false;
             x = null;
             btnUpdate.Enabled = false;
             btnDelete.Enabled = false;
             cmbLvlType.Items.Clear();
             getLvl();
         }

         private void fillUpForm_Load(object sender, EventArgs e)
         {
             cn = new SqlConnection(connection.constring);
             cn.Open();
             txtSearch_TextChanged(sender,e);
             btnSave.Enabled = false;
             btnUpdate.Enabled = false;
             btnDelete.Enabled = false;
             disable();
             txtIDno.Enabled = false;
             checkDisable();
             getLvl();
         }

         void getLvl()
         {
             string sql = "select * from tbl_gradeLvl";
             cm = new SqlCommand(sql,cn);
             dr = cm.ExecuteReader();
             while (dr.Read())
             {
                 cmbLvlType.Items.Add(dr.GetValue(1).ToString());
             }
             dr.Close();
         }

         void checkDisable()
         {
             cbBirthC.Enabled = false;
             cbBC.Enabled = false;
             cbTOR.Enabled = false;
         }

         private void studentList_SelectedIndexChanged(object sender, EventArgs e)
         {
             btnSave.Enabled = false;
             btnDelete.Enabled = true;
             btnUpdate.Enabled = true;
             enable();


             string sql = "select * from tbl_Student where ID like '" + studentList.FocusedItem.Text + "'";
             cm = new SqlCommand(sql, cn);
             dr = cm.ExecuteReader();
             dr.Read();
             if (dr.HasRows)
             {
                 byte[] img = (byte[])(dr.GetValue(18));
                 MemoryStream ms = new MemoryStream(img);
                 pictureBox1.Image = Image.FromStream(ms);
             }
             dr.Close();

             txtIDno.Text = studentList.FocusedItem.Text;
             txtName.Text = studentList.FocusedItem.SubItems[1].Text;
             txtMI.Text = studentList.FocusedItem.SubItems[2].Text;
             txtLastName.Text = studentList.FocusedItem.SubItems[3].Text;
             txtHomeAddress.Text = studentList.FocusedItem.SubItems[4].Text;
             dateTimePicker1.Text = studentList.FocusedItem.SubItems[5].Text; ;
             txtAge.Text = studentList.FocusedItem.SubItems[6].Text;
             txtTelephone.Text = studentList.FocusedItem.SubItems[7].Text;
             cmbGender.Text = studentList.FocusedItem.SubItems[8].Text;
             txtGuard.Text = studentList.FocusedItem.SubItems[9].Text;
             txtAddress.Text = studentList.FocusedItem.SubItems[10].Text;
             txtContact.Text = studentList.FocusedItem.SubItems[11].Text;
             cmbLvlType.Text = studentList.FocusedItem.SubItems[14].Text;
         }

         private void txtSearch_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 studentList.Items.Clear();
                 studentList.Columns.Clear();
                 studentList.Columns.Add("ID Number", 200);
                 studentList.Columns.Add("First Name", 200);
                 studentList.Columns.Add("Middle Name", 200);
                 studentList.Columns.Add("Lastname", 200);
                 studentList.Columns.Add("Home Address", 200);
                 studentList.Columns.Add("Date of Birth", 200);
                 studentList.Columns.Add("Age", 200);
                 studentList.Columns.Add("Tell/Cell number", 200);
                 studentList.Columns.Add("Gender", 200);
                 studentList.Columns.Add("Parent's or Guardian name", 200);
                 studentList.Columns.Add("Address", 200);
                 studentList.Columns.Add("Contact", 200);
                 studentList.Columns.Add("Date and time fill-up", 250);
                 studentList.Columns.Add("Student Standing", 200);
                 studentList.Columns.Add("Grade level", 200);
         


                 string sql = "Select * from tbl_Student where Name like '" + txtSearch.Text + "%' order by Name";
                 cm = new SqlCommand(sql, cn);
                 dr = cm.ExecuteReader();
                 while (dr.Read())
                 {
                     //studentList.Columns.Add("ID Number", 200);
                     //studentList.Columns.Add("First Name", 200);
                     //studentList.Columns.Add("Middle Name", 200);
                     //studentList.Columns.Add("Lastname", 200);

                     //studentList.Columns.Add("Home Address", 200);
                     //studentList.Columns.Add("Date of Birth", 200);
                     //studentList.Columns.Add("Age", 200);
                     //studentList.Columns.Add("Tell/Cell number", 200);
                     //studentList.Columns.Add("Gender", 200);
                     //studentList.Columns.Add("Parent's or Guardian name", 200);
                     //studentList.Columns.Add("Address", 200);
                     //studentList.Columns.Add("Contact", 200);
                     //studentList.Columns.Add("Date and time fill-up", 250);
                     //studentList.Columns.Add("Student Standing", 200);
                     //studentList.Columns.Add("Grade level", 200);

                     list = studentList.Items.Add(dr.GetValue(0).ToString());
                     list.SubItems.Add(dr.GetValue(1).ToString());
                     list.SubItems.Add(dr.GetValue(2).ToString());
                     list.SubItems.Add(dr.GetValue(3).ToString());
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
          
                 }
                 dr.Close();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }
        
        void clear()
         {
             txtIDno.Text = "";
             txtName.Text = "";
             txtMI.Text = "";
             txtLastName.Text = "";
             txtHomeAddress.Text = "";
             dateTimePicker1.Text = "01/01/2000";
             txtAge.Text = "";
             txtTelephone.Text = "";
             txtGuard.Text = "";
             txtContact.Text = "";
             txtAddress.Text = "";

         }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
            x = null;
            cmbLvlType.Items.Clear();
            getLvl();
        }

        void enable()
        {
            dateTimePicker1.Enabled = true;
            txtName.Enabled = true;
            txtMI.Enabled = true;
            txtLastName.Enabled = true;
            txtHomeAddress.Enabled = true;
            cmbGender.Enabled = true;
            txtTelephone.Enabled = true;
            txtGuard.Enabled = true;
            txtContact.Enabled = true;
            txtAddress.Enabled = true;
            txtAge.Enabled = true;
            btnGenerate.Enabled = true;
        }

        void disable()
        {
            dateTimePicker1.Enabled = false;
            txtName.Enabled = false;
            txtMI.Enabled = false;
            txtLastName.Enabled = false;
            txtHomeAddress.Enabled = false;
            cmbGender.Enabled = false;
            txtTelephone.Enabled = false;
            txtGuard.Enabled = false;
            txtContact.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
            btnGenerate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnNew.Enabled = true;

            byte[] img = null;
            FileStream fs;
            BinaryReader br;

            if (txtLastName.Text == "" || txtName.Text == "" || txtMI.Text == "")
            {
                MessageBox.Show("Missing Required Field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (isCLicked == false)
                {
                    imgLoc = Environment.CurrentDirectory + @"\emptyProfile.jpg";
                    fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                else
                {
                    fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }

                string sql = "Update tbl_Student set Name = '" + txtName.Text + "',MI = '" + txtMI.Text + "',Lname = '" + txtLastName.Text + "',completeName = '" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "',HAddress = '" + txtHomeAddress.Text + "',DateBirth = '" + dateTimePicker1.Text + "',Age = '" + txtAge.Text
                                                                   + "',TellNum = '" + txtTelephone.Text + "',Gender = '" + cmbGender.Text + "',Guardian = '" + txtGuard.Text + "',PAddress = '" + txtAddress.Text + "',Contact = '" + txtContact.Text + "',levelType = '" + cmbLvlType.Text + "' where ID like '" + txtIDno.Text + "'";

                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();

                cm = cn.CreateCommand();
                cm.CommandText = "EXECUTE sp_Add @ID,@pix";
                cm.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = txtIDno.Text;
                cm.Parameters.Add("@pix", SqlDbType.Image).Value = img;
                cm.ExecuteNonQuery();


                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record are successfuly saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "] was successfully updated to the student list");

                clear();
                fillUpForm_Load(sender, e);
                x = null;
                cmbLvlType.Items.Clear();
                getLvl();
                pictureBox1.Image = (System.Drawing.Image)(Properties.Resources.images);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            try
            {
                DialogResult del = MessageBox.Show("Are you sure you want to Delete this from the list?", "Delete Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (del == DialogResult.Yes)
                {

                    cm = cn.CreateCommand();
                    cm.CommandText = "EXECUTE sp_delStud @StudID";
                    cm.Parameters.Add("@StudID", SqlDbType.VarChar, 50).Value = studentList.FocusedItem.Text;
                    cm.ExecuteNonQuery();
                    fillUpForm_Load(sender, e);
                    clear();
                    MessageBox.Show("Record Successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Dispose();
                    x = null;
                    cmbLvlType.Items.Clear();
                    getLvl();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Convert.ToString(Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dateTimePicker1.Value.Year));
        }

        private void lblBrowse_Click(object sender, EventArgs e)
        {
            open.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";
            open.Title = "Select Employee Profile Picture";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLoc = open.FileName;
                pictureBox1.ImageLocation = imgLoc;
                isCLicked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cbBirthC.Enabled = true;
            }
            else
            {
                cbBirthC.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                cbBC.Enabled = true;
                cbTOR.Enabled = true;
            }
            else
            {
                cbBC.Enabled = false;
                cbTOR.Enabled = false;
            }
        }

        private void cmbLvlType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
