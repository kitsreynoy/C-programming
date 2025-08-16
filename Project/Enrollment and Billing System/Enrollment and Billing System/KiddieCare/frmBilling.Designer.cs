namespace KiddieCare
{
    partial class frmBilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling));
            this.lblORNo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradeType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModePay = new System.Windows.Forms.ComboBox();
            this.listMode = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTuitionFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblORNo
            // 
            this.lblORNo.AutoSize = true;
            this.lblORNo.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblORNo.Location = new System.Drawing.Point(511, 42);
            this.lblORNo.Name = "lblORNo";
            this.lblORNo.Size = new System.Drawing.Size(116, 22);
            this.lblORNo.TabIndex = 0;
            this.lblORNo.Text = "OR number";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(151, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(209, 27);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID no.";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(151, 72);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(255, 27);
            this.txtName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student name";
            // 
            // txtGradeType
            // 
            this.txtGradeType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGradeType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeType.Location = new System.Drawing.Point(151, 101);
            this.txtGradeType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGradeType.Name = "txtGradeType";
            this.txtGradeType.ReadOnly = true;
            this.txtGradeType.Size = new System.Drawing.Size(255, 27);
            this.txtGradeType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grade type";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(151, 159);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(255, 27);
            this.txtBalance.TabIndex = 11;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(18, 161);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(60, 17);
            this.lblBal.TabIndex = 10;
            this.lblBal.Text = "Balance";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(365, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mode of Payment";
            // 
            // cmbModePay
            // 
            this.cmbModePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModePay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModePay.FormattingEnabled = true;
            this.cmbModePay.Location = new System.Drawing.Point(152, 48);
            this.cmbModePay.Name = "cmbModePay";
            this.cmbModePay.Size = new System.Drawing.Size(189, 29);
            this.cmbModePay.TabIndex = 14;
            this.cmbModePay.SelectedIndexChanged += new System.EventHandler(this.cmbModePay_SelectedIndexChanged);
            // 
            // listMode
            // 
            this.listMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.t,
            this.a});
            this.listMode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMode.FullRowSelect = true;
            this.listMode.GridLines = true;
            this.listMode.Location = new System.Drawing.Point(37, 83);
            this.listMode.Name = "listMode";
            this.listMode.Size = new System.Drawing.Size(304, 228);
            this.listMode.TabIndex = 110;
            this.listMode.UseCompatibleStateImageBehavior = false;
            this.listMode.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // t
            // 
            this.t.Text = "Title";
            this.t.Width = 150;
            // 
            // a
            // 
            this.a.Text = "Amount";
            this.a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.a.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblORNo);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.lblBal);
            this.panel1.Controls.Add(this.txtGradeType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(11, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 218);
            this.panel1.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(452, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bill No.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 31);
            this.panel3.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(302, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 118;
            this.label12.Text = "Student Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtChange);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCash);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTotalFee);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTuitionFee);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.listMode);
            this.panel2.Controls.Add(this.cmbModePay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 321);
            this.panel2.TabIndex = 112;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(491, 48);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 25);
            this.lblDiscount.TabIndex = 118;
            this.lblDiscount.Text = "Dicount";
            this.lblDiscount.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(557, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 38);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(449, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 38);
            this.btnSave.TabIndex = 113;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChange.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(449, 230);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(207, 32);
            this.txtChange.TabIndex = 116;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "Change";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCash.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(449, 177);
            this.txtCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(207, 45);
            this.txtCash.TabIndex = 114;
            this.txtCash.Text = "0.00";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.Enter += new System.EventHandler(this.txtCash_Enter);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            this.txtCash.Leave += new System.EventHandler(this.txtCash_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "Cash";
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalFee.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFee.ForeColor = System.Drawing.Color.Red;
            this.txtTotalFee.Location = new System.Drawing.Point(449, 131);
            this.txtTotalFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.ReadOnly = true;
            this.txtTotalFee.Size = new System.Drawing.Size(207, 40);
            this.txtTotalFee.TabIndex = 112;
            this.txtTotalFee.Text = "0.00";
            this.txtTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "Total Fees";
            // 
            // txtTuitionFee
            // 
            this.txtTuitionFee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTuitionFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuitionFee.Location = new System.Drawing.Point(449, 96);
            this.txtTuitionFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTuitionFee.Name = "txtTuitionFee";
            this.txtTuitionFee.ReadOnly = true;
            this.txtTuitionFee.Size = new System.Drawing.Size(207, 27);
            this.txtTuitionFee.TabIndex = 15;
            this.txtTuitionFee.Text = "0.00";
            this.txtTuitionFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tuition Fees";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 31);
            this.panel4.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(302, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 117;
            this.label11.Text = "Payment Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(698, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblORNo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbModePay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTuitionFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader t;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}