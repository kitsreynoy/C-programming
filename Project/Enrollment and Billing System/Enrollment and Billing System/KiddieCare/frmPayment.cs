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
    public partial class frmPayment : Form
    {

        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public SqlDataReader dr;
 
        frmLogin connection = new frmLogin();

        double amountPay, urMoney, total, tAmount, tBook, tTotal;
        bool session;
        string yr;
        public frmPayment()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmList list = new frmList(this);
            //list.Show();
        }

        public void studPay(string pID, string pName, string pMi, string pLast)
        {
            txtIDSearch.Text = pID;
            txtName.Text = pName;
            txtMI.Text = pMi;
            txtLastname.Text = pLast;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtTotalPay.Enabled = false;
            txtIDSearch.Enabled = false;
            txtName.Enabled = false;
            txtMI.Enabled = false;
            txtLastname.Enabled = false;
            txtAmountPay.Enabled = false;
            lblDiscount.Visible = false;
            txtBook.Enabled = false;
            sy();
        }

       

        private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCash_TextChanged(sender, e);
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (cboPaymentType.SelectedItem == "Partial Payment")
            {

                lblDiscount.Visible = false;

                txtTotalPay.Text = "0.00";
                string peso = "8800.00";
                string book = "2000";

                double amount = Convert.ToDouble(peso);
                double pBook = Convert.ToDouble(book);
                txtAmountPay.Text = amount.ToString("#,###,#0.00");
                txtBook.Text = pBook.ToString("#,###,#0.00");



                if (txtCash.Text == "")
                {
                    txtAmountPay.Text = amount.ToString("#,###,#0.00");
                    txtRemarks.Text = "";
                }
                else
                {
                    amountPay = Double.Parse(txtAmountPay.Text);
                    urMoney = Double.Parse(txtCash.Text);
                    pBook = Double.Parse(txtBook.Text);

                    double distribute = urMoney / 2;

                    

                    if (amountPay > urMoney)
                    {
                        txtChange.Text = "0.00";
                    }
                    else
                    {
                        total = distribute - amountPay;
                        tBook = pBook - distribute;
                       // tTotal = urMoney - amountPay;

                        txtBook.Text = tBook.ToString("#,###,#0.00");
                        txtChange.Text = tTotal.ToString("#,###,#0.00");
                        txtTotalPay.Text = urMoney.ToString("#,###,#0.00");

                        if (urMoney >= 8800)
                        {
                            txtTotalPay.Text = "0.00";
                            txtRemarks.Text = Convert.ToString("Fully Paid");
                        }
                        else
                        {
                            txtRemarks.Text = Convert.ToString("Unpaid");
                        }

                        
                        if (urMoney >= 2000)
                        {
                            txtBook.Text = "0.00";
                        }

                        //txtRemarks.Text = Convert.ToString("Unpaid");
                    }

                 //----------------------------------------------------------------------------------------

                    if (urMoney > amountPay)
                    {
                        txtAmountPay.Text = "0.00";
                        txtRemarks.Text = Convert.ToString("Paid");

                    }
                    else
                    {
                        tAmount = amountPay - distribute;
                        tBook = pBook - distribute;

                        txtBook.Text = tBook.ToString("#,###,#0.00");
                        txtAmountPay.Text = tAmount.ToString("#,###,#0.00");
                        txtTotalPay.Text = urMoney.ToString("#,###,#0.00");

                        if (tAmount == 0.00)
                        {
                            txtAmountPay.Text = "0.00";
                            txtRemarks.Text = Convert.ToString("Fully Paid");
                        }

                        if (urMoney >= 8800)
                        {
                            txtTotalPay.Text = "0.00";
                            txtRemarks.Text = Convert.ToString("Fully Paid");
                        }
                        else
                        {
                            txtRemarks.Text = Convert.ToString("Unpaid");
                        }


                        if (urMoney >= 2000)
                        {
                            txtBook.Text = "0.00";
                        }

                       // txtRemarks.Text = Convert.ToString("Unpaid");
                    }

                   //----------------------------------------------------------------------------------------
                
                }

            }

            if (cboPaymentType.SelectedItem == "Full Payment")
            {
                lblDiscount.Visible = true;

                txtTotalPay.Text = "0.00";
                string peso = "7920.00";
                string book = "2000";

                double amount = Convert.ToDouble(peso);
                double pBook = Convert.ToDouble(book);
                txtAmountPay.Text = amount.ToString("#,###,#0.00");
                txtBook.Text = pBook.ToString("#,###,#0.00");


                if (txtCash.Text == "")
                {
                    txtAmountPay.Text = amount.ToString("#,###,#0.00");
                    txtRemarks.Text = "";
                }
                else
                {
                    amountPay = Double.Parse(txtAmountPay.Text);
                    urMoney = Double.Parse(txtCash.Text);

                    double distribute = urMoney / 2;

                    if (amountPay > urMoney)
                    {
                        txtChange.Text = "0.00";
                    }
                    else
                    {
                        total = distribute - amountPay;
                        txtChange.Text = total.ToString("#,###,#0.00");
                        txtTotalPay.Text = urMoney.ToString("#,###,#0.00");

                        if (urMoney >= 8000)
                        {
                            txtTotalPay.Text = "0.00";
                            txtRemarks.Text = Convert.ToString("Fully Paid");
                        }
                    }

                    if (urMoney > amountPay)
                    {
                        txtAmountPay.Text = "0.00";
                    }
                    else
                    {
                        tAmount = amountPay - distribute;
                        txtAmountPay.Text = tAmount.ToString("#,###,#0.00");
                        txtTotalPay.Text = urMoney.ToString("#,###,#0.00");

                        if (urMoney >= 8000)
                        {
                            txtTotalPay.Text = "0.00";
                        }
                        else
                        {
                            txtRemarks.Text = Convert.ToString("Unpaid");
                        }

                        if (tAmount == 0.00)
                        {
                            txtAmountPay.Text = "0.00";
                            txtRemarks.Text = Convert.ToString("Fully Paid");
                        }
                    }
                }


            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            
            //double[] arr = new double[dataListPayment.Rows.Count - 1];

            if (txtIDSearch.Text == "")
            {
                MessageBox.Show("Please search student", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int counter = 0;

                if (dataListPayment.Rows.Count > 1)
                {

                    while (counter != dataListPayment.Rows.Count - 1)
                    {

                        if (dataListPayment.Rows[0].Cells[0].Value.ToString() == txtIDSearch.Text)
                        {

                        }



                    }

                }
                if (session == true)
                {
                    double c = Convert.ToDouble(txtCash.Text);
                    dataListPayment.Rows.Add(txtIDSearch.Text, txtName.Text, txtMI.Text, txtLastname.Text, cmbGradeLvl.Text, rbMorning.Text, cmbTimeSched.Text, cmbRoom.Text, txtTotalPay.Text, txtAmountPay.Text, c.ToString("#,###,#0.00"), txtRemarks.Text);
                    clear();
                }
                else if (session == false) 
                {
                    double c = Convert.ToDouble(txtCash.Text);
                    dataListPayment.Rows.Add(txtIDSearch.Text, txtName.Text, txtMI.Text, txtLastname.Text, cmbGradeLvl.Text, rbAfternun.Text, cmbTimeSched.Text, cmbRoom.Text, txtTotalPay.Text, txtAmountPay.Text, c.ToString("#,###,#0.00"), txtRemarks.Text);
                    clear();
                }
                
            }


        }


        public void clear()
        {
            txtIDSearch.Text = string.Empty;
            txtName.Text = string.Empty;
            txtMI.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtAmountPay.Text = string.Empty;
            txtTotalPay.Text = string.Empty;
            txtCash.Text = string.Empty;
            txtChange.Text = string.Empty;
                
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void rbMorning_CheckedChanged(object sender, EventArgs e)
        {
            cmbTimeSched.Items.Clear();
            cmbTimeSched.Items.Add("8:00am - 10:00am");
            cmbTimeSched.Items.Add("10:00am - 12:00nn");
            session = true;
        }

        private void rbAfternun_CheckedChanged(object sender, EventArgs e)
        {
            cmbTimeSched.Items.Clear();
            cmbTimeSched.Items.Add("1:00pm - 3:00pm");
            cmbTimeSched.Items.Add("3:00pm - 5:00pm");
            session = false;
        }

        private void dataListPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void sy()
        {
            string sql = "SELECT * FROM tbl_sy";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();

            while (dr.Read() == true)
            {
                cmbYear.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cmbTimeSched_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
