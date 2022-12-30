namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class FrmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotal_txt = new System.Windows.Forms.Label();
            this.tax_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discount_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.billform = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnSell = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffId_txt = new System.Windows.Forms.TextBox();
            this.CustomerId_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.billform)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(745, 480);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sub total:";
            // 
            // subTotal_txt
            // 
            this.subTotal_txt.AutoSize = true;
            this.subTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subTotal_txt.Location = new System.Drawing.Point(916, 480);
            this.subTotal_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotal_txt.Name = "subTotal_txt";
            this.subTotal_txt.Size = new System.Drawing.Size(45, 25);
            this.subTotal_txt.TabIndex = 2;
            this.subTotal_txt.Text = "53$";
            // 
            // tax_txt
            // 
            this.tax_txt.AutoSize = true;
            this.tax_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tax_txt.Location = new System.Drawing.Point(916, 519);
            this.tax_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tax_txt.Name = "tax_txt";
            this.tax_txt.Size = new System.Drawing.Size(50, 25);
            this.tax_txt.TabIndex = 4;
            this.tax_txt.Text = "5,3$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(745, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax:";
            // 
            // discount_txt
            // 
            this.discount_txt.AutoSize = true;
            this.discount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.discount_txt.Location = new System.Drawing.Point(920, 558);
            this.discount_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(41, 25);
            this.discount_txt.TabIndex = 6;
            this.discount_txt.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(745, 558);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount:";
            // 
            // total_txt
            // 
            this.total_txt.AutoSize = true;
            this.total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total_txt.Location = new System.Drawing.Point(916, 594);
            this.total_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(61, 25);
            this.total_txt.TabIndex = 8;
            this.total_txt.Text = "58,3$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(745, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(745, 633);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Staff Id:";
            // 
            // billform
            // 
            this.billform.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.billform.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billform.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billform.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billform.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billform.ColumnHeadersHeight = 40;
            this.billform.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.billform.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.billform.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billform.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.billform.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billform.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.billform.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.billform.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.billform.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.billform.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billform.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.billform.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.billform.CurrentTheme.Name = null;
            this.billform.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.billform.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.billform.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billform.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.billform.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billform.DefaultCellStyle = dataGridViewCellStyle3;
            this.billform.EnableHeadersVisualStyles = false;
            this.billform.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.billform.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.billform.HeaderBgColor = System.Drawing.Color.Empty;
            this.billform.HeaderForeColor = System.Drawing.Color.White;
            this.billform.Location = new System.Drawing.Point(12, 12);
            this.billform.Name = "billform";
            this.billform.RowHeadersVisible = false;
            this.billform.RowHeadersWidth = 51;
            this.billform.RowTemplate.Height = 40;
            this.billform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billform.Size = new System.Drawing.Size(1216, 444);
            this.billform.TabIndex = 12;
            this.billform.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnSell
            // 
            this.btnSell.Angle = 201F;
            this.btnSell.BackColor = System.Drawing.Color.Lavender;
            this.btnSell.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnSell.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSell.BorderRadius = 17;
            this.btnSell.BorderSize = 0;
            this.btnSell.Color0 = System.Drawing.Color.Aquamarine;
            this.btnSell.Color1 = System.Drawing.Color.Aqua;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.Black;
            this.btnSell.Location = new System.Drawing.Point(750, 724);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(175, 47);
            this.btnSell.TabIndex = 13;
            this.btnSell.Text = "Sell";
            this.btnSell.TextColor = System.Drawing.Color.Black;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(745, 671);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer ID:";
            // 
            // StaffId_txt
            // 
            this.StaffId_txt.Location = new System.Drawing.Point(921, 636);
            this.StaffId_txt.Name = "StaffId_txt";
            this.StaffId_txt.Size = new System.Drawing.Size(88, 22);
            this.StaffId_txt.TabIndex = 15;
            // 
            // CustomerId_txt
            // 
            this.CustomerId_txt.Location = new System.Drawing.Point(921, 671);
            this.CustomerId_txt.Name = "CustomerId_txt";
            this.CustomerId_txt.Size = new System.Drawing.Size(88, 22);
            this.CustomerId_txt.TabIndex = 16;
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 937);
            this.Controls.Add(this.CustomerId_txt);
            this.Controls.Add(this.StaffId_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.billform);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discount_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tax_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subTotal_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTotal_txt;
        private System.Windows.Forms.Label tax_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discount_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuDataGridView billform;
        private Button_Custom.Roundedbutton btnSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffId_txt;
        private System.Windows.Forms.TextBox CustomerId_txt;
    }
}