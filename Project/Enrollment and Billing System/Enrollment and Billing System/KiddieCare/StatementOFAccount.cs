using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
namespace KiddieCare
{
    public partial class StatementOFAccount : Form
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public SqlDataReader dr;
        public ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();

        int TogMove;
        int MValX;
        int MValY;

        string schoolYr;
        double getTotFinal, mo;
        string uID, loginID;

        public StatementOFAccount()
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

        private void StatementOFAccount_Load(object sender, EventArgs e)
        {
           // getFees();
        }
        public void pasa(string id, string section, string lvl)
        {
            lblName.Text = id;
            lblSection.Text = section;
            lblGradelvl.Text = lvl;
            getFees();
        }

        private void StatementOFAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void StatementOFAccount_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void StatementOFAccount_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void StatementOFAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void StatementOFAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.S)
            {
                frmSearch search = new frmSearch(this);
                search.ShowDialog();
            }

            if (e.KeyCode == Keys.P)
            {
                PrintScreen();
                printPreviewDialog1.ShowDialog();

                //PrintDialog printDlg = new PrintDialog();

                //PrintDocument printDoc = new PrintDocument();
                //printDoc.DocumentName = "Print Receipt";
                //printDlg.Document = printDoc;
                //printDlg.AllowSelection = true;
                //printDlg.AllowSomePages = true;

                //if (printDlg.ShowDialog() == DialogResult.OK)
                //{
                //    printDoc.PrintPage += new PrintPageEventHandler(PrintImage);
                //    printDoc.Print();
                //}
                //else
                //{
                //}
                    
            }

            if (e.KeyCode == Keys.A)
            {
                //getYr();

                //string sql = "select * from tbl_statementAccount where ID like '" + lblName.Text + "' and sy like '" + schoolYr + "'";
                //cm = new SqlCommand(sql,cn);
                //dr = cm.ExecuteReader();
                //dr.Read();
                //if (dr.HasRows)
                //{

                //}
                //else
                //{

                //}

                //dr.Close();
                
            }
            
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        void saveSOP()
        {
            //string sql = "insert into tbl_statementAccount(ID,sy,pace,pcs,monthly,amount,total,less,payable) values('" + + "')";
        }

        public void getFees()
        {

            getYr();
           // getTotTuition();
         //   getMonthly();

            double dless = 0;
            double dTuition = 0;
            double dMTuition = 0;
            double dMMisc = 0;
            double dWMisc = 0;
            double dMOthers = 0;
            double dWOthers = 0;


            //---------------------------------------------------------------------------------------------

            string sql = "select * from tbl_billing where sy like '" + schoolYr +"' and ID like '" + lblName.Text +"'";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //textBox1.Text = dr.GetValue(3).ToString() + "\n";
                //textBox1.Items.Add(dr.GetValue(3).ToString());
                //lblDate.Text = dr.GetValue(3).ToString() + "\n";
                //lblPartcular.Text = dr.GetValue(7).ToString() + "\n";
                lblAmount.Text = dr.GetValue(6).ToString() + "\n";
                //dless = dless + Convert.ToDouble(lblAmount.Text);

                list = listahan.Items.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(7).ToString());
                list.SubItems.Add(dr.GetValue(6).ToString());
                dless = dless + Convert.ToDouble(lblAmount.Text);

            }
            
            dr.Close();
                //--------------------------> get tuition

                sql = "select * from tbl_tuition where (lvlType like 'All' or lvlType like '" + lblGradelvl.Text + "') and feetype like 'Tuition fee'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblMTuition.Text = dr.GetValue(4).ToString();
                lblWTuition.Text = dr.GetValue(3).ToString();
                dTuition = dTuition + Convert.ToDouble(lblWTuition.Text);
                dMTuition = dMTuition + Convert.ToDouble(lblMTuition.Text);
            }
            dr.Close();

            //----------------------------> get Miscellaneous

            sql = "select * from tbl_tuition where (lvlType like 'All' or lvlType like '" + lblGradelvl.Text + "') and feetype like 'Miscellaneous Fee'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblMisc.Text = dr.GetValue(2).ToString() + "\n";
                lblMMisc.Text = dr.GetValue(4).ToString() + "\n";
                lblWMisc.Text = dr.GetValue(3).ToString() + "\n";
                dMMisc = dMMisc + Convert.ToDouble(lblMMisc.Text);
                dWMisc = dWMisc + Convert.ToDouble(lblWMisc.Text);
            }
            dr.Close();

            lblMMiscTot.Text = dMMisc.ToString("#,##0.00");
            lblWMiscTot.Text = dWMisc.ToString("#,##0.00");

            //----------------------------> get Other fees

            sql = "select * from tbl_tuition where (lvlType like 'All' or lvlType like '" + lblGradelvl.Text + "') and feetype like 'Others Fee'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblOthers.Text = dr.GetValue(2).ToString() + "\n";
                lblMOthers.Text = dr.GetValue(4).ToString() + "\n";
                lblWOthers.Text = dr.GetValue(3).ToString() + "\n";
                dMOthers = dMOthers + Convert.ToDouble(lblMOthers.Text);
                dWOthers = dWMisc + Convert.ToDouble(lblWOthers.Text);
            }
            dr.Close();

            //----------------------------> 

            sql = "select * from tbl_statementAccount where sy like '" + schoolYr + "' and ID like '" + lblName.Text + "'";
            cm = new SqlCommand(sql,cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblPace.Text = dr.GetValue(2).ToString();
                lblPcs.Text = dr.GetValue(3).ToString();
                lblPaceTotal.Text = dr.GetValue(4).ToString();
            }
            dr.Close();
            
            lblMOthersTot.Text = dMOthers.ToString("#,##0.00");
           // lblWOthers.Text = dWOthers.ToString("#,##0.00");

            double dMTotal = Convert.ToDouble(lblMTuition.Text) + Convert.ToDouble(lblMMiscTot.Text) + Convert.ToDouble(lblMOthersTot.Text);
            double dWTotal = Convert.ToDouble(lblWTuition.Text) + Convert.ToDouble(lblWMiscTot.Text) + Convert.ToDouble(lblWOthersTot.Text);
            double dTotal = dWTotal + Convert.ToDouble(lblPaceTotal.Text);
            double payable = dWTotal - dless;

            if (dless < dWTotal)
            {
                payable = 0.00;
            }


            lblMTotal.Text = dMTotal.ToString("#,##0.00");
            lblWTotal.Text = dWTotal.ToString("#,##0.00");
            lblTotal.Text = dTotal.ToString("#,##0.00");
            txtPayable.Text = payable.ToString("#,##0.00");

            lblLess.Text = dless.ToString("#,##0.00");
        }

       public void getTotTuition()
        {
            try
            {
                string sql = "select sum(amount) from tbl_tuition";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    getTotFinal = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (Exception ee) { }
        }

       public void getMonthly()
        {
            try
            {

                string sql = "select sum(monthly) from tbl_tuition";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    mo = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
            }
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {

            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(50, 80);
            e.Graphics.DrawImage(img, p);
        }

        public void getYr()
        {
            //dr.Close();
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

        private void lblName_Click(object sender, EventArgs e)
        {
          // getFees();
        }

        private void lblLess_Click(object sender, EventArgs e)
        {
        //    double payable = (Convert.ToDouble(lblTotal.Text) + Convert.ToDouble(lblLess.Text));
        //    txtPayable.Text = payable.ToString("#,##0.00");
        }

        private void lblPaceTotal_Click(object sender, EventArgs e)
        {
            //double dTotal = (Convert.ToDouble(lblWTotal.Text) + Convert.ToDouble(lblPaceTotal.Text));
            //double payable = (Convert.ToDouble(lblTotal.Text) + Convert.ToDouble(lblLess.Text));
            //lblTotal.Text = dTotal.ToString("#,##0.00");
            //txtPayable.Text = payable.ToString("#,##0.00");

        }

        private void txtPayable_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        //int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (x == 10)
            //{
            //    timer1.Stop();
            //    print_Click(sender, e);
            //}
            //else
            //    x++;
        }
        
       

        
    }
}
