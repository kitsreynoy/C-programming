namespace KiddieCare
{
    partial class frmSchedPay
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
            this.btnSaveSchedPay = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSchedPay
            // 
            this.btnSaveSchedPay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveSchedPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSchedPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveSchedPay.Location = new System.Drawing.Point(217, 116);
            this.btnSaveSchedPay.Name = "btnSaveSchedPay";
            this.btnSaveSchedPay.Size = new System.Drawing.Size(85, 34);
            this.btnSaveSchedPay.TabIndex = 204;
            this.btnSaveSchedPay.Text = "Save";
            this.btnSaveSchedPay.UseVisualStyleBackColor = false;
            this.btnSaveSchedPay.Click += new System.EventHandler(this.btnSaveSchedPay_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 28);
            this.dateTimePicker1.TabIndex = 203;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(19, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 19);
            this.label18.TabIndex = 202;
            this.label18.Text = "Due Date";
            // 
            // cmbParticular
            // 
            this.cmbParticular.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.Items.AddRange(new object[] {
            "downpayment",
            "secondpayment",
            "thirdpayment",
            "fourthpayment",
            "fifthpayment"});
            this.cmbParticular.Location = new System.Drawing.Point(113, 28);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(189, 29);
            this.cmbParticular.TabIndex = 201;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(19, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 19);
            this.label17.TabIndex = 200;
            this.label17.Text = "Particular";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnSaveSchedPay);
            this.panel1.Controls.Add(this.cmbParticular);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 172);
            this.panel1.TabIndex = 205;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmSchedPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(376, 196);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSchedPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule of payment Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSchedPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbParticular;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;

    }
}