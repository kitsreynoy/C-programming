namespace KiddieCare
{
    partial class frmTimeSched
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
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTsched = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.schedList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.i = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTime.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(156, 57);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(217, 29);
            this.cboTime.TabIndex = 209;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Location = new System.Drawing.Point(156, 161);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(217, 29);
            this.cmbGradeLevel.TabIndex = 208;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(16, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 207;
            this.label12.Text = "Grade Level";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoom.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(156, 126);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(217, 29);
            this.cmbRoom.TabIndex = 206;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(16, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 205;
            this.label11.Text = "Room";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSession.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cmbSession.Location = new System.Drawing.Point(156, 22);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(217, 29);
            this.cmbSession.TabIndex = 204;
            this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.cmbSession_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(16, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 19);
            this.label13.TabIndex = 203;
            this.label13.Text = "Session";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(156, 92);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(217, 28);
            this.txtCapacity.TabIndex = 202;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 201;
            this.label4.Text = "Student Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 200;
            this.label3.Text = "Time Sched";
            // 
            // btnTsched
            // 
            this.btnTsched.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTsched.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTsched.Location = new System.Drawing.Point(288, 211);
            this.btnTsched.Name = "btnTsched";
            this.btnTsched.Size = new System.Drawing.Size(85, 34);
            this.btnTsched.TabIndex = 210;
            this.btnTsched.Text = "Save";
            this.btnTsched.UseVisualStyleBackColor = false;
            this.btnTsched.Click += new System.EventHandler(this.btnTsched_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnTsched);
            this.panel1.Controls.Add(this.cmbSession);
            this.panel1.Controls.Add(this.cboTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbGradeLevel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.cmbRoom);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 265);
            this.panel1.TabIndex = 211;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(106, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 34);
            this.btnDelete.TabIndex = 212;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(197, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 34);
            this.btnUpdate.TabIndex = 211;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // schedList
            // 
            this.schedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.t,
            this.s,
            this.r,
            this.rc,
            this.gl,
            this.i});
            this.schedList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedList.FullRowSelect = true;
            this.schedList.GridLines = true;
            this.schedList.Location = new System.Drawing.Point(0, 5);
            this.schedList.Name = "schedList";
            this.schedList.Size = new System.Drawing.Size(589, 265);
            this.schedList.TabIndex = 212;
            this.schedList.UseCompatibleStateImageBehavior = false;
            this.schedList.View = System.Windows.Forms.View.Details;
            this.schedList.SelectedIndexChanged += new System.EventHandler(this.schedList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 0;
            // 
            // t
            // 
            this.t.Text = "Time";
            this.t.Width = 200;
            // 
            // s
            // 
            this.s.Text = "Session";
            this.s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.s.Width = 150;
            // 
            // r
            // 
            this.r.Text = "Room";
            this.r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r.Width = 120;
            // 
            // rc
            // 
            this.rc.Text = "Room capacity";
            this.rc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rc.Width = 150;
            // 
            // gl
            // 
            this.gl.Text = "Grade level";
            this.gl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gl.Width = 150;
            // 
            // i
            // 
            this.i.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.schedList);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(430, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 270);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            // 
            // frmTimeSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1030, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTimeSched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time schedule Setting";
            this.Load += new System.EventHandler(this.frmTimeSched_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRoom;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSession;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTsched;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView schedList;
        private System.Windows.Forms.ColumnHeader t;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.ColumnHeader r;
        private System.Windows.Forms.ColumnHeader rc;
        private System.Windows.Forms.ColumnHeader gl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader i;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}