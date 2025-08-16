namespace KiddieCare
{
    partial class frmSearch
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
            this.listSOA = new System.Windows.Forms.ListView();
            this.r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.g = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSOA
            // 
            this.listSOA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r,
            this.s,
            this.g});
            this.listSOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.listSOA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSOA.FullRowSelect = true;
            this.listSOA.GridLines = true;
            this.listSOA.Location = new System.Drawing.Point(0, 0);
            this.listSOA.Name = "listSOA";
            this.listSOA.Size = new System.Drawing.Size(420, 293);
            this.listSOA.TabIndex = 120;
            this.listSOA.UseCompatibleStateImageBehavior = false;
            this.listSOA.View = System.Windows.Forms.View.Details;
            this.listSOA.SelectedIndexChanged += new System.EventHandler(this.listSOA_SelectedIndexChanged);
            this.listSOA.DoubleClick += new System.EventHandler(this.listSOA_DoubleClick);
            // 
            // r
            // 
            this.r.DisplayIndex = 0;
            this.r.Text = "Student ID";
            this.r.Width = 200;
            // 
            // s
            // 
            this.s.Text = "Student name";
            this.s.Width = 240;
            // 
            // g
            // 
            this.g.Text = "Grade level";
            this.g.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 121;
            this.label1.Text = "Search Bar";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(118, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 30);
            this.txtSearch.TabIndex = 122;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 55);
            this.panel1.TabIndex = 123;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(420, 363);
            this.Controls.Add(this.listSOA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSOA;
        private System.Windows.Forms.ColumnHeader r;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.ColumnHeader g;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
    }
}