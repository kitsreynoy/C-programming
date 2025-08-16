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
    public partial class frmLogTrail : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        string uID, loginID;
        frmLogin connection = new frmLogin();

        public frmLogTrail()
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

        private void frmLogTrail_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender,e);
        }

        void listviewColor()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = Color.LightBlue;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string sql = "select * from logtrailView where username like '" + txtSearch.Text + "%'";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                list = listView1.Items.Add(dr.GetValue(4).ToString()); // username
                list.SubItems.Add(dr.GetValue(5).ToString()); // account name
                list.SubItems.Add(dr.GetValue(2).ToString()); // login
                list.SubItems.Add(dr.GetValue(3).ToString()); // logout
            }
            dr.Close();

            listviewColor();
        }
    }
}
