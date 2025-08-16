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
    public partial class frmBilling : Form
    {
        public SqlConnection cn;
        public SqlCommand cm;
        public SqlDataReader dr;

        public ListViewItem list = new ListViewItem();
        frmLogin connection = new frmLogin();
        string schoolYr = "";
        string schoolYrOld = "";
        String x = "";
        Random rand = new Random();
        double amt = 0;
        double getTot = 0;
        double getTotFinal = 0;
        double iCnt;
        double mo = 0;
        double dummy_total = 0;
        double downpayment = 0, discount = 0;
        string uID, loginID, percentage;
        string name, mode, cash, change, fees, mode1, bal;
        bool isBal = false;
        public frmBilling()
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

        private void frmBilling_Load(object sender, EventArgs e)
        {
            generateCode();
            cmbModePay.Enabled = false;
            txtCash.Enabled = false;
            btnSave.Enabled = false;
            //cmbModePay.Items.Add("Downpayment");
            //cmbModePay.Items.Add("Installment");
            //cmbModePay.Items.Add("Full Payment");
        }

        void generateCode()
        {
            string z = Convert.ToString(DateTime.Now.Year);
            string y = Convert.ToString(DateTime.Now.Day);


            for (int s = 1; s <= 3; s++)
            {
                x += Convert.ToString(rand.Next(0, 9));

            }


            lblORNo.Text = z + "" + y + "-" + x;
            if (lblORNo.Text == x)
            {
                x = null;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbModePay.Items.Clear();
            frmList list = new frmList(this);
            list.ShowDialog();
        }

        public void studBill(string id, string name, string gradeLvl)
        {
            txtID.Text = id;
            txtName.Text = name;
            txtGradeType.Text = gradeLvl;

        }

        private void cmbModePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMode.Items.Clear();
            getDiscount();
            
            if (cmbModePay.SelectedItem == "Downpayment")
            {
                getDownpayment();
                txtCash.Enabled = true;
                btnSave.Enabled = true;
                lblDiscount.Visible = false;
            }
            else if (cmbModePay.SelectedItem == "Installment")
            {
                getInstallment();
                txtCash.Enabled = true;
                btnSave.Enabled = true;
            }
            else if (cmbModePay.SelectedItem == "Full Payment")
            {
                getTotTuition();
                getMode();
                string sql = "select count(BillingNo),sum(amount) from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if ((Convert.ToDouble(dr[0]) >= 1 && (mode1 == "Downpayment")) || (Convert.ToDouble(dr[0]) >= 1 && mode1 == "Installment"))
                    {
                        SqlConnection cn1 = new SqlConnection(cn.ConnectionString);
                        cn1.Open();
                        sql = "select sum(amount) from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
                        SqlCommand cm1 = new SqlCommand(sql, cn1);
                        SqlDataReader dr1 = cm1.ExecuteReader();
                        dr1.Read();
                        if (dr1.HasRows)
                        {
                            txtTotalFee.Text =  String.Format("{0:#,#0.00}", (Convert.ToDouble(getTotFinal) - Convert.ToDouble(dr[1])));
                        }
                        dr1.Close();
                    }
                    else
                    {
                        txtBalance.Text = discount.ToString("#,##0.00");
                        txtTotalFee.Text = txtBalance.Text;
                        txtTuitionFee.Text = discount.ToString("#,##0.00");
                        lblDiscount.Visible = true;
                        lblDiscount.Text = percentage + "% Discount";
                        txtCash.Enabled = true;
                        btnSave.Enabled = true;
                    }




                }
                else 
                {
                    
                }
                dr.Close();

                txtCash.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        void getMode()
        {
            string sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                mode1 = dr[7].ToString();
            }
            dr.Close();
        }

        //--------------------- Downpayment

        public void getDowpay()
        {
            string sql = "select * from tbl_downpayment";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                downpayment = Convert.ToDouble(dr.GetValue(1).ToString());
            }
            dr.Close();

        }

        // ---------------- Discount payment

        public void getDiscount()
        {
            string sql = "select * from tbl_discount";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                percentage = dr.GetValue(1).ToString();
                discount = Convert.ToDouble(dr.GetValue(2).ToString());
            }
            dr.Close();

        }


        void getDownpayment()
        {
            getDowpay();

            if (cmbModePay.SelectedItem == "Downpayment")
            {
                try
                {
                    string sql = "select * from tbl_tuition";
                    cm = new SqlCommand(sql, cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        list = listMode.Items.Add(dr.GetValue(0).ToString());
                        list.SubItems.Add(dr.GetValue(2).ToString());
                        list.SubItems.Add(dr.GetValue(3).ToString());

                    }
                    dr.Close();

                    dummy_total = downpayment;
                }
                catch (Exception ee)
                {

                }

                label8.Text = "Downpay";
            }
            else if (cmbModePay.SelectedItem == "Full Payment")
            {
                getDiscount();

                try
                {
                    dummy_total = getTotFinal;
                }
                catch (Exception xx)
                {
                }
            }

            getTotTuition();

            txtTotalFee.Text = dummy_total.ToString("#,##0.00");
            txtTuitionFee.Text = getTotFinal.ToString("#,##0.00");
            txtBalance.Text = getTotFinal.ToString("#,##0.00");

        }

        //-------------------- Tuition fee

        void getTotTuition()
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

      

        void getMonthly()
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

        void getInstallment()
        {
            getMonthly();
            dummy_total = 0;
            iCnt = 0;

            if (cmbModePay.SelectedItem == "Installment")
            {
                try
                {
                    string sql = "select * from tbl_tuition";
                    cm = new SqlCommand(sql, cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        list = listMode.Items.Add(dr.GetValue(0).ToString());
                        list.SubItems.Add(dr.GetValue(2).ToString());
                        list.SubItems.Add(dr.GetValue(3).ToString());
                    }

                    dr.Close();
                    dummy_total = dummy_total + mo;


                }
                catch (Exception ex)
                {
                }

            }
            //else if (cmbModePay.SelectedItem == "Full Payment")
            //{
            //    try
            //    {

            //        //string sql = "select * from tbl_tuition";
            //        //cm = new SqlCommand(sql, cn);
            //        //dr = cm.ExecuteReader();
            //        //while (dr.Read())
            //        //{
            //        //    list = listMode.Items.Add(dr.GetValue(0).ToString());
            //        //    list.SubItems.Add(dr.GetValue(2).ToString());
            //        //    list.SubItems.Add(dr.GetValue(3).ToString());
            //        //}
            //        //dr.Close();

            //      //  dummy_total = discount;
            //        //iCnt = iCnt + 1;
            //    }
            //    catch (Exception xx) { }

            //}
            txtTuitionFee.Text = getTotFinal.ToString("#,##0.00");
            txtTotalFee.Text = dummy_total.ToString("#,##0.00");
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                cmbModePay.Enabled = true;
                txtCash.Enabled = false;

                getYr();
                getTotTuition();
                getDiscount();

                string sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy <> '" + schoolYr + "' and currentBalance <> '0'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                //string bal = dr[8].ToString();
                if (dr.HasRows /*&& bal != "0"*/)
                {
                    MessageBox.Show("You have a previous balance", "Christian kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    do
                    {
                        getTot = Convert.ToDouble(dr.GetValue(8).ToString());
                        txtTotalFee.Text = getTot.ToString("#,##0.00");
                        txtTuitionFee.Text = getTotFinal.ToString("#,##0.00");
                        txtBalance.Text = txtTotalFee.Text;
                        schoolYrOld = dr.GetValue(4).ToString();

                    } while (dr.Read());

                    if (txtBalance.Text == "0.00")
                    {
                        txtTotalFee.Text = "Fully paid";
                        txtCash.Enabled = false;
                        cmbModePay.Enabled = false;

                    }

                    txtCash.Enabled = true;
                    btnSave.Enabled = true;
                    isBal = true;
                    return;
                }
                dr.Close();



                sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    do
                    {
                        getTot = Convert.ToDouble(dr.GetValue(8).ToString());
                        txtTotalFee.Text = getTot.ToString("#,##0.00");
                        txtTuitionFee.Text = getTotFinal.ToString("#,##0.00");
                        txtBalance.Text = txtTotalFee.Text;

                    } 
                    while (dr.Read());

                    if (txtBalance.Text == "0.00")
                    {
                        txtTotalFee.Text = "Fully paid";
                        txtCash.Enabled = false;
                        cmbModePay.Enabled = false;

                    }
                }
                else
                {
                    dr.Close();

                    //--------------- tuition discount -----------------

                    //sql = "select sum(amount) from tbl_tuition";
                    //cm = new SqlCommand(sql, cn);
                    //dr = cm.ExecuteReader();
                    //while (dr.Read())
                    //{
                       // getTot = Convert.ToDouble(dr.GetValue(0).ToString());
                        txtTuitionFee.Text = getTotFinal.ToString("#,##0.00");
                        txtTotalFee.Text = getTotFinal.ToString("#,##0.00");
                        txtBalance.Text = getTotFinal.ToString("#,##0.00");


                    //}
                    // dr.Close();
                    if (txtBalance.Text == "0.00")
                    {
                        txtTotalFee.Text = "Fully paid";
                        txtCash.Enabled = false;
                        cmbModePay.Enabled = false;
                    }
                }
                dr.Close();

                sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cmbModePay.Items.Add("Installment");
                    cmbModePay.Items.Add("Full Payment");
                }
                else
                {
                    cmbModePay.Items.Add("Downpayment");
                    cmbModePay.Items.Add("Full Payment");
                }
                dr.Close();
            }
            catch (Exception ee) { }
        }



        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCash_Enter(object sender, EventArgs e)
        {

            if (txtCash.Text == "0.00")
            {
                txtCash.Text = "";
            }
        }

        private void txtCash_Leave(object sender, EventArgs e)
        {
            if (txtCash.Text == "")
            {
                txtCash.Text = "0.00";
                txtChange.Text = "0.00";
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = 0;
                x = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtTotalFee.Text);
                txtChange.Text = x.ToString("#,##0.00");

                if (Convert.ToDouble(txtTotalFee.Text) > Convert.ToDouble(txtCash.Text))
                {
                    txtChange.Text = "0.00";
                }

                //double bal1 = 0;
                //bal1 = getTotFinal - Convert.ToDouble(txtCash.Text);
                //textBox1.Text = bal1.ToString("#,##0.00");

                //if (Convert.ToDouble(txtBalance.Text) < Convert.ToDouble(txtCash.Text))
                //{

                //    textBox1.Text = "0.00";
                //}
            }
            catch (Exception ex)
            {
                // txtID_TextChanged(sender, e);
                txtChange.Text = "0.00";
                //textBox1.Text = txtBalance.Text;
            }
        }

        void updateOld() 
        {
            string sql = "update tbl_billing set currentBalance='0' where ID like '" + txtID.Text + "' and sy like '" + schoolYrOld + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void updateCurrent()
        {
            string sql = "update tbl_billing set currentBalance='0' where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cm.Dispose();
        }

        void getBal() 
        {
            string sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy like '" + schoolYr + "' and currentBalance like '0'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows) 
            {
                bal = dr[8].ToString();
            }
            dr.Close();
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtCash.Text) < Convert.ToDouble(txtTotalFee.Text))
            {
                MessageBox.Show("Insuficient amount to pay downpayment", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtID.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               // try
               // {
                double cb = 0, amount = 0;
                if (Convert.ToDouble(txtCash.Text) > Convert.ToDouble(txtTotalFee.Text))
                {
                    if (MessageBox.Show("The cash is greater than the total fee, do you want to save this amount? If you click yes then the amount will be saved, if you click no then the amount of the total fee will be deducted from cash and return the change", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cb = Convert.ToDouble(txtBalance.Text) - Convert.ToDouble(txtCash.Text);

                        if (Convert.ToDouble(txtBalance.Text) < Convert.ToDouble(txtCash.Text))
                        {
                            cb = 0.00;
                        }

                        amount = Convert.ToDouble(txtCash.Text);
                        txtChange.Text = "0.00";


                    }
                    else
                    {
                        cb = Convert.ToDouble(txtBalance.Text) - Convert.ToDouble(txtTotalFee.Text);
                        amount = Convert.ToDouble(txtTotalFee.Text);
                    }
                }
                else
                {
                    cb = Convert.ToDouble(txtBalance.Text) - Convert.ToDouble(txtTotalFee.Text);
                    amount = Convert.ToDouble(txtCash.Text);
                }
                    getYr();
                    dr.Close();

                    //string sql = "select * from tbl_billing ";
                    string sql = "";
                    if (isBal == true) 
                    {
                        sql = "insert into tbl_billing(BillingNo,ID,date,sy,amount,mode,currentBalance,PrevBalance) values('" + lblORNo.Text + "','" + txtID.Text + "','" 
                            + DateTime.Now.ToString() + "','" + schoolYrOld + "','" + amount + "','" + cmbModePay.Text + "','" + cb + "','" + cb + "')";
                        cm = new SqlCommand(sql, cn);
                        cm.ExecuteNonQuery();
                        auditrail(uID, "Mr/Ms [" + txtName.Text + "] paid the amount of this remaining balance from " + schoolYrOld + "");
                        isBal = false;
                        updateOld();
                    }
                    else if (isBal == false) 
                    {
                        sql = "insert into tbl_billing(BillingNo,ID,date,sy,amount,mode,currentBalance,PrevBalance) values('" + lblORNo.Text + "','" + txtID.Text + "','" 
                            + DateTime.Now.ToString() + "','" + schoolYr + "','" + amount + "','" + cmbModePay.Text + "','" + cb + "','" + cb + "')";
                        cm = new SqlCommand(sql, cn);
                        cm.ExecuteNonQuery();
                        auditrail(uID, "Mr/Ms [" + txtName.Text + "] paid the amount of this remaining balance for this year " + schoolYr + "");
                    }
                    getBal();
                    if (bal == "0") 
                    {
                        updateCurrent();
                    }


                    sql = "insert into tbl_mode_billing(ID,BillingNo,Title,amount) values('" + txtID.Text + "','" + lblORNo.Text + "','" + cmbModePay.Text + "','" + txtCash.Text + "')";
                    cm = new SqlCommand(sql, cn);
                    cm.ExecuteNonQuery();

                    Billing bill = new Billing();
                    bill.lblName.Text = txtName.Text;
                    bill.lblParticular.Text = cmbModePay.Text;
                    bill.lblPesos.Text = txtCash.Text;
                    bill.lblTotal.Text = txtTotalFee.Text;
                    bill.lblCash.Text = txtCash.Text;
                    bill.lblChange.Text = txtChange.Text;
                    this.Hide();
                    bill.ShowDialog();
                    
                    clear();
                    cm.Dispose();

                    lblDiscount.Visible = false;


                    SqlConnection cn1 = new SqlConnection(connection.constring);
                    cn1.Open();

                    sql = "select * from tbl_billing where ID like '" + txtID.Text + "' and sy = '" + schoolYrOld + "'";
                    cm = new SqlCommand(sql, cn1);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        double curBal = Convert.ToDouble(txtTotalFee.Text) - Convert.ToDouble(txtCash.Text);

                        sql = "update tbl_billing set currentBalance = '" + curBal + "' where sy like '" + schoolYrOld + "'";
                        cm = new SqlCommand(sql, cn);
                        cm.ExecuteNonQuery();
                    }

                    dr.Close();
                    

               // }
               // catch (Exception ee)
              //  {
               //     MessageBox.Show(ee.Message, "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // }
            }


        }


        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txtID.Clear();
            txtName.Text = string.Empty;
            txtGradeType.Text = "";
            txtBalance.Text = "";
            cmbModePay.Text = "";
            txtTuitionFee.Text = "0.00";
            txtTotalFee.Text = "0.00";
            txtCash.Text = "0.00";
            txtChange.Text = "0.00";
            cmbModePay.Enabled = false;
        }


    }
}
