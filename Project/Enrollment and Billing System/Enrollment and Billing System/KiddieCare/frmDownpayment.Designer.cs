namespace KiddieCare
{
    partial class frmDownpayment
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
            this.listDown = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDown
            // 
            this.listDown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.r});
            this.listDown.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDown.FullRowSelect = true;
            this.listDown.GridLines = true;
            this.listDown.Location = new System.Drawing.Point(16, 67);
            this.listDown.Name = "listDown";
            this.listDown.Size = new System.Drawing.Size(134, 103);
            this.listDown.TabIndex = 126;
            this.listDown.UseCompatibleStateImageBehavior = false;
            this.listDown.View = System.Windows.Forms.View.Details;
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
            this.r.Text = "Discount amount";
            this.r.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.r.Width = 130;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRoom.Location = new System.Drawing.Point(68, 183);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(83, 36);
            this.btnAddRoom.TabIndex = 127;
            this.btnAddRoom.Text = "Save";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "Downpayment";
            // 
            // txtDown
            // 
            this.txtDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDown.Location = new System.Drawing.Point(16, 37);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(134, 27);
            this.txtDown.TabIndex = 125;
            this.txtDown.Text = "0";
            this.txtDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDown_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listDown);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.txtDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 231);
            this.panel1.TabIndex = 128;
            // 
            // frmDownpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(190, 253);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDownpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDownpayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listDown;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader r;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Panel panel1;
    }
}