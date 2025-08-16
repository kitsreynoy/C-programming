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
    public partial class frmList : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        frmLogin connection = new frmLogin();

        frmBilling gawas = null;

        public string id, name, gradeLvl,amtTot;
        public double amt = 0;
        public frmList(frmBilling gawas)
        {
            InitializeComponent();
            this.gawas = gawas;
           
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection.constring);
            cn.Open();
            txtSearch_TextChanged(sender, e);
        }

      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            studentList.Columns.Clear();
            studentList.Columns.Add("ID Number", 180);
            studentList.Columns.Add("Student Name", 270);
            studentList.Columns.Add("Grade level", 150);

            string sql = "Select * from tbl_Student where Name like '" + txtSearch.Text + "%'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                list = studentList.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString() + " " + dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(15).ToString());

            }
            dr.Close();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void studentList_DoubleClick(object sender, EventArgs e)
        {
           // getAmt();

            id = studentList.FocusedItem.SubItems[0].Text;
            name = studentList.FocusedItem.SubItems[1].Text;
            gradeLvl = studentList.FocusedItem.SubItems[2].Text;
            gawas.studBill(id, name, gradeLvl);
            this.Close();
        }

        void getAmt()
        {
            string sql = "select sum(amount) from tbl_tuition";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                amt = Convert.ToDouble(dr.GetValue(0).ToString());

            }
            dr.Close();
        }




    }
}
