namespace KiddieCare
{
    partial class frmUserSetting
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
            this.components = new System.ComponentModel.Container();
            this.lblChangeName = new System.Windows.Forms.LinkLabel();
            this.lblChangeUser = new System.Windows.Forms.LinkLabel();
            this.lblChangepass = new System.Windows.Forms.LinkLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblChangeName.LinkColor = System.Drawing.Color.Black;
            this.lblChangeName.Location = new System.Drawing.Point(374, 22);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(66, 19);
            this.lblChangeName.TabIndex = 78;
            this.lblChangeName.TabStop = true;
            this.lblChangeName.Text = "Change";
            this.lblChangeName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangeName_LinkClicked);
            // 
            // lblChangeUser
            // 
            this.lblChangeUser.AutoSize = true;
            this.lblChangeUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblChangeUser.LinkColor = System.Drawing.Color.Black;
            this.lblChangeUser.Location = new System.Drawing.Point(374, 60);
            this.lblChangeUser.Name = "lblChangeUser";
            this.lblChangeUser.Size = new System.Drawing.Size(66, 19);
            this.lblChangeUser.TabIndex = 77;
            this.lblChangeUser.TabStop = true;
            this.lblChangeUser.Text = "Change";
            this.lblChangeUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangeUser_LinkClicked);
            // 
            // lblChangepass
            // 
            this.lblChangepass.AutoSize = true;
            this.lblChangepass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblChangepass.LinkColor = System.Drawing.Color.Black;
            this.lblChangepass.Location = new System.Drawing.Point(374, 95);
            this.lblChangepass.Name = "lblChangepass";
            this.lblChangepass.Size = new System.Drawing.Size(66, 19);
            this.lblChangepass.TabIndex = 76;
            this.lblChangepass.TabStop = true;
            this.lblChangepass.Text = "Change";
            this.lblChangepass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangepass_LinkClicked);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(112, 96);
            this.txtPass.MaxLength = 1000;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(263, 30);
            this.txtPass.TabIndex = 75;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(112, 61);
            this.txtUser.MaxLength = 1000;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(263, 30);
            this.txtUser.TabIndex = 73;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Username";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(112, 26);
            this.txtName.MaxLength = 1000;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(263, 30);
            this.txtName.TabIndex = 71;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.txtPassOld);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPassNew);
            this.panel1.Controls.Add(this.txtPassConfirm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(478, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 135);
            this.panel1.TabIndex = 79;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(343, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 29);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(260, 97);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(77, 29);
            this.btnDone.TabIndex = 79;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtPassOld
            // 
            this.txtPassOld.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassOld.Location = new System.Drawing.Point(212, 7);
            this.txtPassOld.MaxLength = 1000;
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = '•';
            this.txtPassOld.Size = new System.Drawing.Size(211, 27);
            this.txtPassOld.TabIndex = 74;
            this.txtPassOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Old Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "New Password";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.Location = new System.Drawing.Point(212, 36);
            this.txtPassNew.MaxLength = 1000;
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '•';
            this.txtPassNew.Size = new System.Drawing.Size(211, 27);
            this.txtPassNew.TabIndex = 76;
            this.txtPassNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassConfirm.Location = new System.Drawing.Point(212, 65);
            this.txtPassConfirm.MaxLength = 1000;
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '•';
            this.txtPassConfirm.Size = new System.Drawing.Size(211, 27);
            this.txtPassConfirm.TabIndex = 78;
            this.txtPassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Confirm New Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblChangeName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblChangeUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblChangepass);
            this.panel2.Location = new System.Drawing.Point(6, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 136);
            this.panel2.TabIndex = 80;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(472, 161);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblChangeName;
        private System.Windows.Forms.LinkLabel lblChangeUser;
        private System.Windows.Forms.LinkLabel lblChangepass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}