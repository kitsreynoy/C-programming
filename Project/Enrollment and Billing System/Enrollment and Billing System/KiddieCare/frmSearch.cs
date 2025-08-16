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
    public partial class frmSearch : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();

        frmLogin connection = new frmLogin();
        string schoolYr = "";
        string id, lvl, section;
        StatementOFAccount inday;

        public frmSearch(StatementOFAccount inday)
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            this.inday = inday;
        }

        void getYr()
        {
            try
            {
                string sql = "select * from tbl_sy where yrStatus like 'Active'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    schoolYr = dr.GetValue(1).ToString() + "-" + dr.GetValue(2).ToString();
                }
                dr.Close();

            }
            catch (Exception ee) { }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getYr();
            string sql = "select * from enrolleesList where sy like '" + schoolYr + "' and completeName like '" + txtSearch.Text +"%' order by completeName";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read() == true)
            {
                list = listSOA.Items.Add(dr.GetValue(1).ToString()); //id
                list.SubItems.Add(dr.GetValue(0).ToString()); //name
                list.SubItems.Add(dr.GetValue(7).ToString()); // gradelevel
            }
            dr.Close();
        }

        private void listSOA_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listSOA_DoubleClick(object sender, EventArgs e)
        {
            StatementOFAccount state = new StatementOFAccount();
            //getYr();
            //string sql = "select * from enrolleesList where sy like '" + schoolYr + "' and ID like '" + listSOA.FocusedItem.Text + "'";
            //cm = new SqlCommand(sql, cn);
            //dr = cm.ExecuteReader();
            //dr.Read();
            //if (dr.HasRows)
            //{
                //id = dr.GetValue(0).ToString();
                //section = dr.GetValue(4).ToString();
                //lvl = dr.GetValue(7).ToString();

               id = listSOA.FocusedItem.SubItems[0].Text;
                section = listSOA.FocusedItem.SubItems[1].Text;
                lvl = listSOA.FocusedItem.SubItems[2].Text;
                inday.pasa(id,section,lvl);
                this.Close();
            //}
            //dr.Close();
            //this.Close();
        }
    }
}
