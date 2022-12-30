namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class FrmServiceDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CustomerId_txt = new System.Windows.Forms.TextBox();
            this.StaffId_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Subtotal_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.Deposit_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.ProductID_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Service_txt = new System.Windows.Forms.ComboBox();
            this.remain_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.remark_txt = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Request_Btn = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.othercost_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.es_txt = new System.Windows.Forms.TextBox();
            this.esdate_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Service request";
            // 
            // CustomerId_txt
            // 
            this.CustomerId_txt.Location = new System.Drawing.Point(195, 77);
            this.CustomerId_txt.Name = "CustomerId_txt";
            this.CustomerId_txt.Size = new System.Drawing.Size(113, 22);
            this.CustomerId_txt.TabIndex = 42;
            // 
            // StaffId_txt
            // 
            this.StaffId_txt.Location = new System.Drawing.Point(195, 43);
            this.StaffId_txt.Name = "StaffId_txt";
            this.StaffId_txt.Size = new System.Drawing.Size(113, 22);
            this.StaffId_txt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Customer ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(2, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Staff Id:";
            // 
            // Subtotal_txt
            // 
            this.Subtotal_txt.Location = new System.Drawing.Point(195, 179);
            this.Subtotal_txt.Name = "Subtotal_txt";
            this.Subtotal_txt.ReadOnly = true;
            this.Subtotal_txt.Size = new System.Drawing.Size(113, 22);
            this.Subtotal_txt.TabIndex = 45;
            this.Subtotal_txt.Text = "Total";
            this.Subtotal_txt.TextChanged += new System.EventHandler(this.Subtotal_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(190, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sub total";
            // 
            // Total_txt
            // 
            this.Total_txt.Location = new System.Drawing.Point(192, 264);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.ReadOnly = true;
            this.Total_txt.Size = new System.Drawing.Size(113, 22);
            this.Total_txt.TabIndex = 54;
            this.Total_txt.TextChanged += new System.EventHandler(this.Total_txt_TextChanged);
            // 
            // Deposit_txt
            // 
            this.Deposit_txt.Location = new System.Drawing.Point(547, 226);
            this.Deposit_txt.Name = "Deposit_txt";
            this.Deposit_txt.Size = new System.Drawing.Size(106, 22);
            this.Deposit_txt.TabIndex = 53;
            this.Deposit_txt.TextChanged += new System.EventHandler(this.Deposit_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(350, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Advance Deposit";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(536, 80);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(117, 22);
            this.amount_txt.TabIndex = 50;
            this.amount_txt.TextChanged += new System.EventHandler(this.amount_txt_TextChanged);
            // 
            // ProductID_txt
            // 
            this.ProductID_txt.Location = new System.Drawing.Point(536, 45);
            this.ProductID_txt.Name = "ProductID_txt";
            this.ProductID_txt.Size = new System.Drawing.Size(117, 22);
            this.ProductID_txt.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(360, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(360, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Product ID";
            // 
            // Service_txt
            // 
            this.Service_txt.FormattingEnabled = true;
            this.Service_txt.Items.AddRange(new object[] {
            "Gemstone Maintenance Service",
            "Order By Pattern"});
            this.Service_txt.Location = new System.Drawing.Point(355, 129);
            this.Service_txt.Name = "Service_txt";
            this.Service_txt.Size = new System.Drawing.Size(171, 24);
            this.Service_txt.TabIndex = 55;
            this.Service_txt.SelectedIndexChanged += new System.EventHandler(this.Service_txt_SelectedIndexChanged);
            // 
            // remain_txt
            // 
            this.remain_txt.Location = new System.Drawing.Point(547, 264);
            this.remain_txt.Name = "remain_txt";
            this.remain_txt.Size = new System.Drawing.Size(106, 22);
            this.remain_txt.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(350, 264);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Remaining";
            // 
            // remark_txt
            // 
            this.remark_txt.Location = new System.Drawing.Point(178, 318);
            this.remark_txt.Name = "remark_txt";
            this.remark_txt.Size = new System.Drawing.Size(358, 128);
            this.remark_txt.TabIndex = 60;
            this.remark_txt.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(5, 314);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 61;
            this.label12.Text = "Remark:";
            // 
            // Request_Btn
            // 
            this.Request_Btn.Angle = 107F;
            this.Request_Btn.BackColor = System.Drawing.Color.Lavender;
            this.Request_Btn.BackgroundColor = System.Drawing.Color.Lavender;
            this.Request_Btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Request_Btn.BorderRadius = 17;
            this.Request_Btn.BorderSize = 0;
            this.Request_Btn.Color0 = System.Drawing.Color.Aquamarine;
            this.Request_Btn.Color1 = System.Drawing.Color.Aqua;
            this.Request_Btn.FlatAppearance.BorderSize = 0;
            this.Request_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Request_Btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Request_Btn.ForeColor = System.Drawing.Color.Black;
            this.Request_Btn.Location = new System.Drawing.Point(257, 470);
            this.Request_Btn.Name = "Request_Btn";
            this.Request_Btn.Size = new System.Drawing.Size(175, 47);
            this.Request_Btn.TabIndex = 62;
            this.Request_Btn.Text = "Request";
            this.Request_Btn.TextColor = System.Drawing.Color.Black;
            this.Request_Btn.UseVisualStyleBackColor = false;
            this.Request_Btn.Click += new System.EventHandler(this.Request_Btn_Click);
            // 
            // othercost_txt
            // 
            this.othercost_txt.Location = new System.Drawing.Point(547, 183);
            this.othercost_txt.Name = "othercost_txt";
            this.othercost_txt.Size = new System.Drawing.Size(106, 22);
            this.othercost_txt.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(350, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 25);
            this.label13.TabIndex = 63;
            this.label13.Text = "Other costs";
            // 
            // es_txt
            // 
            this.es_txt.Location = new System.Drawing.Point(192, 223);
            this.es_txt.Name = "es_txt";
            this.es_txt.Size = new System.Drawing.Size(113, 22);
            this.es_txt.TabIndex = 66;
            // 
            // esdate_txt
            // 
            this.esdate_txt.AutoSize = true;
            this.esdate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esdate_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esdate_txt.Location = new System.Drawing.Point(2, 222);
            this.esdate_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.esdate_txt.Name = "esdate_txt";
            this.esdate_txt.Size = new System.Drawing.Size(158, 25);
            this.esdate_txt.TabIndex = 65;
            this.esdate_txt.Text = "Estimated Date";
            // 
            // FrmServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 529);
            this.Controls.Add(this.es_txt);
            this.Controls.Add(this.esdate_txt);
            this.Controls.Add(this.othercost_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Request_Btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.remark_txt);
            this.Controls.Add(this.remain_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Service_txt);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.Deposit_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.ProductID_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Subtotal_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerId_txt);
            this.Controls.Add(this.StaffId_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmServiceDetail";
            this.Text = "ServiceDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox CustomerId_txt;
        private System.Windows.Forms.TextBox StaffId_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Subtotal_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.TextBox Deposit_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox ProductID_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Service_txt;
        private System.Windows.Forms.TextBox remain_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox remark_txt;
        private System.Windows.Forms.Label label12;
        private Button_Custom.Roundedbutton Request_Btn;
        private System.Windows.Forms.TextBox othercost_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox es_txt;
        private System.Windows.Forms.Label esdate_txt;
    }
}