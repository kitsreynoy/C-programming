using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace KiddieCare
{
    public partial class Billing : Form
    {
        int n, thou, hun, tens, ones, zero, elevens;
        int TogMove;
        int MValX;
        int MValY;

        string word1 = "", word2 = "", word3 = "", word4 = "", word5 = "";

        String x = "";
        Random rand = new Random();
        frmBilling bill = null;
        public Billing()
        {
            InitializeComponent();
           // this.wee = wee;
        }

        public void pasaBill(string name, string mode, string cash, string change, string fees)
        {
            lblName.Text = name;
            lblParticular.Text = mode;
            lblCash.Text = cash;
            lblChange.Text = change;
            lblTotal.Text = fees;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            generateCode();
            NumberToWords();
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


            lblTin.Text = x;
            //if (lblTin.Text == x)
            //{
            //    x = null;
            //}

        }

        private void Billing_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Billing_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Billing_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Billing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                frmBilling bill = new frmBilling();
                bill.ShowDialog();
            }

            if (e.KeyCode == Keys.P)
            {
                PrintDialog printDlg = new PrintDialog();

                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Print Receipt";
                printDlg.Document = printDoc;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog() == DialogResult.OK)
                {
                    printDoc.PrintPage += new PrintPageEventHandler(PrintImage);
                    printDoc.Print();
                }
                else
                {

                }
                    
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
            Point p = new Point(100, 80);
            e.Graphics.DrawImage(img, p);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void NumberToWords()
        {
            int n = Convert.ToInt32(lblPesos.Text);

            if (n == 0)
            {
                switch (n)
                {
                    case 0: Console.WriteLine("Zero"); break;

                }
            }

            if ((n >= 100) && (n <= 50000))
            {

                thou = n / 1000;
                n = n % 1000;
                hun = n / 100;
                n = n % 100;

                switch (thou)
                {

                    case 1: word1 = "One Thousand "; break;
                    case 2: word1 = "Two Thousand "; break;
                    case 3: word1 = "Three Thousand "; break;
                    case 4: word1 = "Four Thousand "; break;
                    case 5: word1 = "Five Thousand "; break;
                    case 6: word1 = "Six Thousand "; break;
                    case 7: word1 = "Seven Thousand "; break;
                    case 8: word1 = "Eight Thousand "; break;
                    case 9: word1 = "Nine Thousand "; break;
                    case 10: word1 = "Eleven Thousand "; break;
                    case 11: word1 = "Twelve Thousand "; break;
                    case 12: word1 = "Thirteen Thousand "; break;
                    case 13: word1 = "Fourteen Thousand "; break;
                    case 14: word1 = "Fifteen Thousand "; break;
                    case 15: word1 = "Sixteen Thousand "; break;
                    case 16: word1 = "Seventeen Thousand "; break;
                    case 17: word1 = "Eighteen Thousand "; break;
                    case 18: word1 = "Eight Thousand "; break;
                    case 19: word1 = "Nineteen Thousand "; break;
                    case 20: word1 = "Twenty Thousand "; break;
                    case 21: word1 = "Twenty One Thousand "; break;
                    case 22: word1 = "Twenty Two Thousand "; break;
                    case 23: word1 = "Twenty Three Thousand "; break;
                    case 24: word1 = "Twenty Four Thousand "; break;
                    case 25: word1 = "Twenty Five Thousand "; break;
                    case 26: word1 = "Twenty Six Thousand "; break;
                    case 27: word1 = "Twenty Seven Thousand "; break;
                    case 28: word1 = "Twenty Eight Thousand "; break;
                    case 29: word1 = "Twenty Nine Thousand "; break;
                    case 30: word1 = "Thirty Thousand "; break;
                    case 31: word1 = "Thirty One Thousand "; break;
                    case 32: word1 = "Thirty Two Thousand "; break;
                    case 33: word1 = "Thirty Three Thousand "; break;
                    case 34: word1 = "Thirty Four Thousand "; break;
                    case 35: word1 = "Thirty Five Thousand "; break;
                    case 36: word1 = "Thirty Six Thousand "; break;
                    case 37: word1 = "Thirty Seven Thousand "; break;
                    case 38: word1 = "Thirty Eight Thousand "; break;
                    case 39: word1 = "Thirty Nine Thousand "; break;
                    case 40: word1 = "Fourty Thousand "; break;
                    case 41: word1 = "Fourty One Thousand "; break;
                    case 42: word1 = "Fourty Two Thousand "; break;
                    case 43: word1 = "Fourty Three Thousand "; break;
                    case 44: word1 = "Fourty Four Thousand "; break;
                    case 45: word1 = "Fourty Five Thousand "; break;
                    case 46: word1 = "Fourty Six Thousand "; break;
                    case 47: word1 = "Fourty Seven Thousand "; break;
                    case 48: word1 = "Fourty Eight Thousand "; break;
                    case 49: word1 = "Fourty Nine Thousand "; break;
                    case 50: word1 = "Fifty Thousand "; break;

                }


                switch (hun)
                {
                    case 1: word2 = "One Hundred "; break;
                    case 2: word2 = "Two Hundred "; break;
                    case 3: word2 = "Three Hundred "; break;
                    case 4: word2 = "Four Hundred "; break;
                    case 5: word2 = "Five Hundred "; break;
                    case 6: word2 = "Six Hundred "; break;
                    case 7: word2 = "Seven Hundred "; break;
                    case 8: word2 = "Eight Hundred "; break;
                    case 9: word2 = "Nine Hundred "; break;


                }
            }


            if ((n > 10) && (n < 20))
            {

                tens = n / 10;
                ones = n;
                elevens = n % 10;


                switch (elevens)
                {
                    case 1: word3 = "Eleven "; break;
                    case 2: word3 = "Twelve "; break;
                    case 3: word3 = "Thirteen "; break;
                    case 4: word3 = "Fourteen "; break;
                    case 5: word3 = "Fifteen "; break;
                    case 6: word3 = "Sixteen "; break;
                    case 7: word3 = "Seventeen "; break;
                    case 8: word3 = "Eighteen "; break;
                    case 9: word3 = "Nineteen "; break;
                     
                }
            }
            if (n > 50000)
            {
                Console.Write("INVALID INPUT");
            }

            else
            {
                tens = n / 10;
                n = n % 10;
                ones = n;

                switch (tens)
                {

                    case 1: word4 = "Ten "; break;
                    case 2: word4 = "Twenty "; break;
                    case 3: word4 = "Thirty "; break;
                    case 4: word4 = "Fourty "; break;
                    case 5: word4 = "Fifty "; break;
                    case 6: word4 = "Sixty "; break;
                    case 7: word4 = "Seventy "; break;
                    case 8: word4 = "Eighty "; break;
                    case 9: word4 = "Ninety "; break;
                }
                switch (ones)
                {

                    case 1: word4 = "One "; break;
                    case 2: word4 = "Two "; break;
                    case 3: word4 = "Three "; break;
                    case 4: word4 = "Four "; break;
                    case 5: word4 = "Five "; break;
                    case 6: word4 = "Six "; break;
                    case 7: word4 = "Seven "; break;
                    case 8: word4 = "Eight "; break;
                    case 9: word4 = "Nine "; break;

                    
                }

            }



            lblNumberWord.Text = word1 + " " + word2 + " " + word3 + " " + word4 + " " + word5;
        }





    }
}
