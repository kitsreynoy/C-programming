namespace KiddieCare
{
    partial class frmTime
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.listTime = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(68, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 36);
            this.btnUpdate.TabIndex = 125;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel.Location = new System.Drawing.Point(157, 307);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 36);
            this.btnDel.TabIndex = 124;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listTime
            // 
            this.listTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.r,
            this.s});
            this.listTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTime.FullRowSelect = true;
            this.listTime.GridLines = true;
            this.listTime.Location = new System.Drawing.Point(15, 80);
            this.listTime.Name = "listTime";
            this.listTime.Size = new System.Drawing.Size(312, 180);
            this.listTime.TabIndex = 122;
            this.listTime.UseCompatibleStateImageBehavior = false;
            this.listTime.View = System.Windows.Forms.View.Details;
            this.listTime.SelectedIndexChanged += new System.EventHandler(this.listTime_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "idRoom";
            this.columnHeader1.Width = 0;
            // 
            // r
            // 
            this.r.DisplayIndex = 0;
            this.r.Text = "Time";
            this.r.Width = 160;
            // 
            // s
            // 
            this.s.Text = "Session";
            this.s.Width = 160;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRoom.Location = new System.Drawing.Point(244, 307);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(83, 36);
            this.btnAddRoom.TabIndex = 123;
            this.btnAddRoom.Text = "Save";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSession);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.listTime);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 356);
            this.panel1.TabIndex = 126;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(73, 266);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(254, 27);
            this.txtTime.TabIndex = 202;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 201;
            this.label1.Text = "Time";
            // 
            // cmbSession
            // 
            this.cmbSession.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cmbSession.Location = new System.Drawing.Point(73, 45);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(254, 29);
            this.cmbSession.TabIndex = 200;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(11, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 19);
            this.label16.TabIndex = 199;
            this.label16.Text = "Session";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(225, 11);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(102, 27);
            this.txtTo.TabIndex = 198;
            this.txtTo.Text = "00:00PM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(186, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 19);
            this.label15.TabIndex = 197;
            this.label15.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(73, 11);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(97, 27);
            this.txtFrom.TabIndex = 196;
            this.txtFrom.Text = "00:00AM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(11, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 19);
            this.label14.TabIndex = 195;
            this.label14.Text = "From";
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(360, 380);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Maintenance";
            this.Load += new System.EventHandler(this.frmTime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListView listTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader r;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSession;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
    }
}