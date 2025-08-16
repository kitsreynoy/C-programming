using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace KiddieCare
{
    public partial class frmReport : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        frmLogin connection = new frmLogin();
        public DataSet1 ds;
        public SqlDataAdapter da;

        public frmReport()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        public void LoadRecord(string sql)
        {
            ReportDataSource rptDataSource;
            reportViewer1.LocalReport.ReportPath = @"Report\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            da = new SqlDataAdapter();
            ds = new DataSet1();
            da.SelectCommand = new SqlCommand(sql, cn);
            da.Fill(ds.Tables[0]);
            rptDataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rptDataSource);

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

        }


        public void LoadRecord1(string sql1)
        {
            ReportDataSource rptDataSource;
            reportViewer1.LocalReport.ReportPath = @"Report\Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            da = new SqlDataAdapter();
            ds = new DataSet1();
            da.SelectCommand = new SqlCommand(sql1, cn);
            da.Fill(ds.Tables[0]);
            rptDataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rptDataSource);

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

        }
    }
}
