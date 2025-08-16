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
    public partial class frmMain : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        frmLogin connection = new frmLogin();
        public string uID, loginDate, logID;
        public bool accesscodeform = false;

        public frmMain()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }

        public void dawat(string ID, string loginD)
        {
            uID = ID;
            loginDate = loginD;

            string sql = "select * from tbl_logtrail where uID like '" + uID + "' and loginDate like '" + loginDate + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                logID = dr.GetValue(0).ToString();
            }
            dr.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            auditrail(uID, "Main form load");
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
            this.Opacity += 0.2;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
        }



        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            maintenance mainten = new maintenance();
            mainten.ShowDialog();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPay pay = new frmPay();
            pay.ShowDialog();
        }


        private void btnSchedulePaySetting_Click(object sender, EventArgs e)
        {
            frmSchedPay schedpay = new frmSchedPay();
            schedpay.ShowDialog();
        }

        private void btnPaymenSetting_Click(object sender, EventArgs e)
        {
            frmPaymentSetting paySetting = new frmPaymentSetting();
            paySetting.ShowDialog();
        }

        private void btnSchedSetting_Click(object sender, EventArgs e)
        {
            frmTimeSched timeSched = new frmTimeSched();
            timeSched.ShowDialog();
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            //frmListStudent listStud = new frmListStudent();
            //listStud.ShowDialog();
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            frmYearMaintenance year = new frmYearMaintenance();
            year.dawat(uID, logID);
            year.ShowDialog();
            auditrail(uID, "The school year under the maintenance form was display");
        }

        private void btnAddLvl_Click(object sender, EventArgs e)
        {
            frmGradeLvlMaintenance gradeLvl = new frmGradeLvlMaintenance();
            gradeLvl.dawat(uID, logID);
            gradeLvl.ShowDialog();
            auditrail(uID, "The grade level under the maintenance form was display");
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmRoomMaintenance roomMaintenance = new frmRoomMaintenance();
            roomMaintenance.dawat(uID, logID);
            roomMaintenance.ShowDialog();
            auditrail(uID, "The room form under the maintenance was display");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //if (accesscodeform == true)
            //{
            //    frmAccessCode access = new frmAccessCode(uID, logID);
            //    access.addStudent = true;
            //    access.ShowDialog();
            //}
            //else
            //{
                fillUpForm fillup = new fillUpForm();
                fillup.dawat0(uID, logID);
                fillup.ShowDialog();
                auditrail(uID, "The add student form was display");
            //}
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
        //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout this account?", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        string sql = "update tbl_user set status = 'offline' where uID like '" + uID + "'";
        //        cm = new SqlCommand(sql, cn);
        //        cm.ExecuteNonQuery();
        //        cm.Dispose();


        //        sql = "update tbl_logtrail set logoutDate = '" + DateTime.Now + "' where logID like '" + logID + "'";
        //        cm = new SqlCommand(sql, cn);
        //        cm.ExecuteNonQuery();
        //        cm.Dispose();

        //        this.Hide();
        //        frmLogin login = new frmLogin();
        //        login.ShowDialog();
        //    }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            //if (accesscodeform == true)
            //{
            //    frmAccessCode access = new frmAccessCode(uID, logID);
            //    access.addTeacher = true;
            //    access.ShowDialog();
            //}
            //else
            //{
                frmAddTeacher teacher = new frmAddTeacher();
                teacher.dawat(uID, logID);
                teacher.ShowDialog();
                auditrail(uID, "The add teacher form was display");
            //}
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmSubject subject = new frmSubject();
            subject.ShowDialog();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            frmSection section = new frmSection();
            section.dawat(uID, logID);
            section.ShowDialog();
            auditrail(uID, "The section under the maintenance form was display");
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            frmFee fee = new frmFee();
            fee.dawat(uID, logID);
            fee.ShowDialog();
            auditrail(uID, "The tuition fee under the maintenance form was display");
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.dawat(uID, logID);
            about.ShowDialog();
            auditrail(uID, "The about us form was display");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            frmTime time = new frmTime();
            time.dawat(uID, logID);
            time.ShowDialog();
            auditrail(uID, "The time schedule under the maintenance form was display");
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            //if (accesscodeform == true)
            //{
            //    frmAccessCode access = new frmAccessCode(uID, logID);
            //    access.Bill = true;
            //    access.ShowDialog();
            //}
            //else
            //{
                frmBilling billing = new frmBilling();
                billing.dawat(uID, logID);
                billing.ShowDialog();
                auditrail(uID, "The Billing form was display");
            //}
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            //if (accesscodeform == true)
            //{
            //    frmAccessCode access = new frmAccessCode(uID, logID);
            //    access.Enroll = true;
            //    access.ShowDialog();
            //}
            //else
            //{
                frmEnrollment enrollS = new frmEnrollment();
                enrollS.dawat(uID, logID);
                enrollS.ShowDialog();
                auditrail(uID, "The enrollment form was display");
            //}
        }

        private void btnSAccount_Click(object sender, EventArgs e)
        {
            //if (accesscodeform == true)
            //{
            //    frmAccessCode access = new frmAccessCode(uID, logID);
            //    access.SOA = true;
            //    access.ShowDialog();
            //}
            //else
            //{
                StatementOFAccount statement = new StatementOFAccount();
                statement.dawat(uID, logID);
                statement.ShowDialog();
                auditrail(uID, "The statement of account form was display");
            //}
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmListEnrolless enrollees = new frmListEnrolless();
            enrollees.dawat(uID, logID);
            enrollees.ShowDialog();
            auditrail(uID, "The enrollees form was display");
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            frmPrintList printList = new frmPrintList();
            printList.dawat(uID, logID);
            printList.ShowDialog();
            auditrail(uID, "The student list form was display");
        }

        private void btnLogtrail_Click(object sender, EventArgs e)
        {
            frmLogTrail logtrail = new frmLogTrail();
            logtrail.dawat(uID, logID);
            logtrail.ShowDialog();
            auditrail(uID, "The login trail form was display");
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            frmAuditTrail audit = new frmAuditTrail();
            audit.dawat(uID, logID);
            audit.ShowDialog();
            auditrail(uID, "The audit trail form was display");
        }

        private void btnAddSecurity_Click(object sender, EventArgs e)
        {
            frmManagement manage = new frmManagement();
            manage.dawat(uID, logID);
            manage.ShowDialog();
            auditrail(uID, "The security form under the maintenance was display");
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            frmUserSetting setting = new frmUserSetting();
            setting.dawat(uID, logID);
            setting.ShowDialog();
            auditrail(uID, "The user setting under the maintenance form was display");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserSetting setting = new frmUserSetting();
            setting.dawat(uID, logID);
            setting.ShowDialog();
            auditrail(uID, "The user setting form under the maintenance was display");
        }

        private void studentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillUpForm fillup = new fillUpForm();
            fillup.dawat0(uID, logID);
            fillup.ShowDialog();
            auditrail(uID, "The add student form was display");
        }

        private void teacherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTeacher teacher = new frmAddTeacher();
            teacher.dawat(uID, logID);
            teacher.ShowDialog();
            auditrail(uID, "The add teacher form was display");
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnrollment enrollS = new frmEnrollment();
            enrollS.dawat(uID, logID);
            enrollS.ShowDialog();
            auditrail(uID, "The enrollment form was display");
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilling billing = new frmBilling();
            billing.dawat(uID, logID);
            billing.ShowDialog();
            auditrail(uID, "The Billing form was display");
        }

        private void statementOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatementOFAccount statement = new StatementOFAccount();
            statement.dawat(uID, logID);
            statement.ShowDialog();
            auditrail(uID, "The statement of account form was display");
        }

        private void studentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEnrolless enrollees = new frmListEnrolless();
            enrollees.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sign out?", "Christian Kiddie Star Academy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "update tbl_user set status = 'offline' where uID like '" + uID + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cm.Dispose();


                sql = "update tbl_logtrail set logoutDate = '" + DateTime.Now + "' where logID like '" + logID + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cm.Dispose();

                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void fileToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount();
            discount.ShowDialog();
        }

        private void downpaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDownpayment dp = new frmDownpayment();
            dp.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.ShowDialog();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintenance maintenance = new maintenance();
            maintenance.ShowDialog();
        }

        private void auditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditTrail atrail = new frmAuditTrail();
            atrail.ShowDialog();
        }

        private void loginTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogTrail lt = new frmLogTrail();
            lt.ShowDialog();
        }

        private void schoolYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearMaintenance frmsy = new frmYearMaintenance();
            frmsy.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintList printList = new frmPrintList();
            printList.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
