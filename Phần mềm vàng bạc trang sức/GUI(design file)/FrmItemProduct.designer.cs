namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class FrmItemProduct
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
            this.Name_txt = new System.Windows.Forms.Label();
            this.remain_txt = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.Label();
            this.ItemPic = new System.Windows.Forms.PictureBox();
            this.Sellbtn = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.AutoSize = true;
            this.Name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(25, 331);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(134, 25);
            this.Name_txt.TabIndex = 0;
            this.Name_txt.Text = "Couple rings";
            // 
            // remain_txt
            // 
            this.remain_txt.AutoSize = true;
            this.remain_txt.Location = new System.Drawing.Point(27, 382);
            this.remain_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remain_txt.Name = "remain_txt";
            this.remain_txt.Size = new System.Drawing.Size(72, 16);
            this.remain_txt.TabIndex = 1;
            this.remain_txt.Text = "Amount: 60";
            // 
            // price_txt
            // 
            this.price_txt.AutoSize = true;
            this.price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(98, 420);
            this.price_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(60, 25);
            this.price_txt.TabIndex = 2;
            this.price_txt.Text = "0000";
            // 
            // ItemPic
            // 
            this.ItemPic.Location = new System.Drawing.Point(16, 15);
            this.ItemPic.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPic.Name = "ItemPic";
            this.ItemPic.Size = new System.Drawing.Size(433, 293);
            this.ItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPic.TabIndex = 5;
            this.ItemPic.TabStop = false;
            // 
            // Sellbtn
            // 
            this.Sellbtn.Angle = 289F;
            this.Sellbtn.BackColor = System.Drawing.Color.Lavender;
            this.Sellbtn.BackgroundColor = System.Drawing.Color.Lavender;
            this.Sellbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Sellbtn.BorderRadius = 17;
            this.Sellbtn.BorderSize = 0;
            this.Sellbtn.Color0 = System.Drawing.Color.Aquamarine;
            this.Sellbtn.Color1 = System.Drawing.Color.Aqua;
            this.Sellbtn.FlatAppearance.BorderSize = 0;
            this.Sellbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sellbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Sellbtn.ForeColor = System.Drawing.Color.Black;
            this.Sellbtn.Location = new System.Drawing.Point(289, 519);
            this.Sellbtn.Name = "Sellbtn";
            this.Sellbtn.Size = new System.Drawing.Size(175, 47);
            this.Sellbtn.TabIndex = 9;
            this.Sellbtn.Text = "SELL";
            this.Sellbtn.TextColor = System.Drawing.Color.Black;
            this.Sellbtn.UseVisualStyleBackColor = false;
            this.Sellbtn.Click += new System.EventHandler(this.Sellbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount: ";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(92, 448);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(80, 22);
            this.amount_txt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price: ";
            // 
            // FrmItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sellbtn);
            this.Controls.Add(this.ItemPic);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.remain_txt);
            this.Controls.Add(this.Name_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmItemProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_txt;
        private System.Windows.Forms.Label remain_txt;
        private System.Windows.Forms.Label price_txt;
        private System.Windows.Forms.PictureBox ItemPic;
        private Button_Custom.Roundedbutton Sellbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label2;
    }
}