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
    public partial class frmRoomMaintenance : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();
        string uID, loginID;

        public frmRoomMaintenance()
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

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_room where Room like '" + txtRoom.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This " + dr[1].ToString() + " is already added", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return;
                }
                dr.Close();

                sql = "insert into tbl_room(Room) values('" + txtRoom.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Room is successfully save", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Room is successfully added");
                listRoom.Items.Clear();
                ListRooms();
                cm.Dispose();
                txtRoom.Text = "";

            }
        }

        void ListRooms() 
        {
            string sql = "Select * from tbl_room";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = listRoom.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());

            }
            dr.Close();
    }

        private void frmRoomMaintenance_Load(object sender, EventArgs e)
        {
            ListRooms();
            btnDelete.Enabled = false;
        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            txtRoom.Text = listRoom.FocusedItem.SubItems[1].Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoom.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == "")
            {
                MessageBox.Show("Please fill the empty field", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string sql = "delete from tbl_room where idRoom like '" + listRoom.FocusedItem.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Room is successfully delete", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auditrail(uID, "Room is successfully deleted");
                listRoom.Items.Clear();
                ListRooms();
                cm.Dispose();
                txtRoom.Text = "";
                btnDelete.Enabled = false;
            }
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            if (txtRoom.Text == "")
            {
                btnDelete.Enabled = false;
            }
        }
}
}