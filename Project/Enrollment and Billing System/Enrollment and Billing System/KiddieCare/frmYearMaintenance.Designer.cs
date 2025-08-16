namespace KiddieCare
{
    partial class frmYearMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.listYear = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(221, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(64, 30);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(131, 27);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(253, 30);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(144, 27);
            this.txtTo.TabIndex = 3;
            // 
            // listYear
            // 
            this.listYear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.y,
            this.columnHeader2,
            this.a});
            this.listYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listYear.FullRowSelect = true;
            this.listYear.GridLines = true;
            this.listYear.Location = new System.Drawing.Point(11, 68);
            this.listYear.Name = "listYear";
            this.listYear.Size = new System.Drawing.Size(386, 207);
            this.listYear.TabIndex = 111;
            this.listYear.UseCompatibleStateImageBehavior = false;
            this.listYear.View = System.Windows.Forms.View.Details;
            this.listYear.SelectedIndexChanged += new System.EventHandler(this.listYear_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // y
            // 
            this.y.DisplayIndex = 0;
            this.y.Text = "Year from";
            this.y.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year to";
            this.columnHeader2.Width = 120;
            // 
            // a
            // 
            this.a.Text = "Status";
            this.a.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnActivate);
            this.panel1.Controls.Add(this.btnErase);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listYear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 336);
            this.panel1.TabIndex = 113;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActivate.Location = new System.Drawing.Point(130, 283);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(85, 39);
            this.btnActivate.TabIndex = 115;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnErase.Location = new System.Drawing.Point(312, 283);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(85, 39);
            this.btnErase.TabIndex = 114;
            this.btnErase.Text = "Clear";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // frmYearMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(436, 363);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmYearMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year enrolled Maintenance";
            this.Load += new System.EventHandler(this.frmYearMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ListView listYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader y;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.Button btnActivate;
    }
}