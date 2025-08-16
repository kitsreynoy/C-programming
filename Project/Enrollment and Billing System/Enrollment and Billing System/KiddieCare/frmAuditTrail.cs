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
    public partial class frmAuditTrail : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem lst = new ListViewItem();
        string uID, loginID;
        frmLogin connection = new frmLogin();

        public frmAuditTrail()
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

        private void frmAuditTrail_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender,e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string sql = "select * from auditTraiView where username like '" + txtSearch.Text + "%'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lst = listView1.Items.Add(dr[0].ToString());
                lst.SubItems.Add(dr[1].ToString());
                lst.SubItems.Add(dr[2].ToString());
                lst.SubItems.Add(dr[3].ToString());
                
            }
            dr.Close();

            listviewColor();
        }
    }
}
