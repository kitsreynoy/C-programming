namespace KiddieCare
{
    partial class frmFill
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtIDno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ListView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtPersonBring = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtOccupMader = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtOccupFader = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtMader = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtFathersName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtPrevSchool = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(385, 27);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(81, 29);
            this.btnGenerate.TabIndex = 159;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtIDno
            // 
            this.txtIDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDno.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIDno.Location = new System.Drawing.Point(150, 27);
            this.txtIDno.Name = "txtIDno";
            this.txtIDno.ReadOnly = true;
            this.txtIDno.Size = new System.Drawing.Size(229, 29);
            this.txtIDno.TabIndex = 158;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 157;
            this.label5.Text = "ID Number";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(653, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 29);
            this.txtSearch.TabIndex = 156;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(495, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 22);
            this.label10.TabIndex = 155;
            this.label10.Text = "Search Name";
            // 
            // studentList
            // 
            this.studentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentList.FullRowSelect = true;
            this.studentList.GridLines = true;
            this.studentList.Location = new System.Drawing.Point(495, 88);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(783, 436);
            this.studentList.TabIndex = 154;
            this.studentList.UseCompatibleStateImageBehavior = false;
            this.studentList.View = System.Windows.Forms.View.Details;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(494, 540);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 41);
            this.btnNew.TabIndex = 153;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(970, 540);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 41);
            this.btnClear.TabIndex = 149;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(850, 540);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 41);
            this.btnDelete.TabIndex = 148;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(734, 540);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnUpdate.TabIndex = 147;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(614, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 41);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(216, -95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 24);
            this.txtID.TabIndex = 145;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label23.Location = new System.Drawing.Point(76, -97);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(46, 18);
            this.Label23.TabIndex = 144;
            this.Label23.Text = "ID No";
            // 
            // txtPersonBring
            // 
            this.txtPersonBring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonBring.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPersonBring.Location = new System.Drawing.Point(150, 575);
            this.txtPersonBring.Name = "txtPersonBring";
            this.txtPersonBring.Size = new System.Drawing.Size(317, 29);
            this.txtPersonBring.TabIndex = 143;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label22.Location = new System.Drawing.Point(17, 548);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(423, 20);
            this.Label22.TabIndex = 142;
            this.Label22.Text = "Person who will regularly bring/ fetch the child in school :";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtContactPerson.Location = new System.Drawing.Point(150, 513);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(317, 29);
            this.txtContactPerson.TabIndex = 141;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label21.Location = new System.Drawing.Point(17, 488);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(293, 20);
            this.Label21.TabIndex = 140;
            this.Label21.Text = "Contact Person in case of Emergency :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLastName.Location = new System.Drawing.Point(150, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(316, 29);
            this.txtLastName.TabIndex = 139;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label20.Location = new System.Drawing.Point(16, 117);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(85, 20);
            this.Label20.TabIndex = 138;
            this.Label20.Text = "Last Name";
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMI.Location = new System.Drawing.Point(150, 87);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(316, 29);
            this.txtMI.TabIndex = 137;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label19.Location = new System.Drawing.Point(16, 88);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(108, 20);
            this.Label19.TabIndex = 136;
            this.Label19.Text = "Middle Name";
            // 
            // txtOccupMader
            // 
            this.txtOccupMader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupMader.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtOccupMader.Location = new System.Drawing.Point(150, 424);
            this.txtOccupMader.Name = "txtOccupMader";
            this.txtOccupMader.Size = new System.Drawing.Size(317, 29);
            this.txtOccupMader.TabIndex = 135;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label18.Location = new System.Drawing.Point(16, 430);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(98, 20);
            this.Label18.TabIndex = 134;
            this.Label18.Text = "Occupation";
            // 
            // txtOccupFader
            // 
            this.txtOccupFader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupFader.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtOccupFader.Location = new System.Drawing.Point(150, 364);
            this.txtOccupFader.Name = "txtOccupFader";
            this.txtOccupFader.Size = new System.Drawing.Size(317, 29);
            this.txtOccupFader.TabIndex = 133;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label15.Location = new System.Drawing.Point(17, 370);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(98, 20);
            this.Label15.TabIndex = 132;
            this.Label15.Text = "Occupation";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label14.Location = new System.Drawing.Point(17, 214);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(99, 20);
            this.Label14.TabIndex = 131;
            this.Label14.Text = "Date of Birth";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(150, 178);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(126, 32);
            this.cmbGender.TabIndex = 130;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label13.Location = new System.Drawing.Point(16, 183);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(66, 20);
            this.Label13.TabIndex = 129;
            this.Label13.Text = "Gender";
            // 
            // txtReligion
            // 
            this.txtReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtReligion.Location = new System.Drawing.Point(150, 454);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(317, 29);
            this.txtReligion.TabIndex = 128;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label12.Location = new System.Drawing.Point(17, 460);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(66, 20);
            this.Label12.TabIndex = 127;
            this.Label12.Text = "Religion";
            // 
            // txtMader
            // 
            this.txtMader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMader.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMader.Location = new System.Drawing.Point(150, 394);
            this.txtMader.Name = "txtMader";
            this.txtMader.Size = new System.Drawing.Size(317, 29);
            this.txtMader.TabIndex = 126;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label11.Location = new System.Drawing.Point(17, 400);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(120, 20);
            this.Label11.TabIndex = 125;
            this.Label11.Text = "Mother\'s Name";
            // 
            // txtFathersName
            // 
            this.txtFathersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFathersName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFathersName.Location = new System.Drawing.Point(150, 334);
            this.txtFathersName.Name = "txtFathersName";
            this.txtFathersName.Size = new System.Drawing.Size(317, 29);
            this.txtFathersName.TabIndex = 124;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label7.Location = new System.Drawing.Point(16, 334);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(112, 20);
            this.Label7.TabIndex = 123;
            this.Label7.Text = "Father\'s Name";
            // 
            // txtPrevSchool
            // 
            this.txtPrevSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevSchool.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrevSchool.Location = new System.Drawing.Point(150, 304);
            this.txtPrevSchool.Name = "txtPrevSchool";
            this.txtPrevSchool.Size = new System.Drawing.Size(317, 29);
            this.txtPrevSchool.TabIndex = 122;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label8.Location = new System.Drawing.Point(16, 304);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(124, 20);
            this.Label8.TabIndex = 121;
            this.Label8.Text = "Previous School";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTelephone.Location = new System.Drawing.Point(150, 274);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(317, 29);
            this.txtTelephone.TabIndex = 120;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(16, 274);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 20);
            this.Label3.TabIndex = 119;
            this.Label3.Text = "Telephone No";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeAddress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtHomeAddress.Location = new System.Drawing.Point(150, 244);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(317, 29);
            this.txtHomeAddress.TabIndex = 118;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(16, 244);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(114, 20);
            this.Label4.TabIndex = 117;
            this.Label4.Text = "Home Address";
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNickname.Location = new System.Drawing.Point(150, 147);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(316, 29);
            this.txtNickname.TabIndex = 116;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(16, 153);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 115;
            this.Label2.Text = "Nickname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(150, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 29);
            this.txtName.TabIndex = 114;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(16, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 20);
            this.Label1.TabIndex = 113;
            this.Label1.Text = "Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 30);
            this.dateTimePicker1.TabIndex = 160;
            this.dateTimePicker1.Tag = "";
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // frmFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1291, 621);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtIDno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.txtPersonBring);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtOccupMader);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.txtOccupFader);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtMader);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtFathersName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtPrevSchool);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "frmFill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill up ";
            this.Load += new System.EventHandler(this.frmFill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.TextBox txtIDno;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView studentList;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtPersonBring;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtContactPerson;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox txtMI;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtOccupMader;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox txtOccupFader;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox cmbGender;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtReligion;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtMader;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtFathersName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtPrevSchool;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtTelephone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtHomeAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtNickname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}