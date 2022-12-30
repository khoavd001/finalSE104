namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class Staff
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
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddStaffButton = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.btnupdate = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.deletebtn = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.StaffGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(23, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(91, 18);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "PRODUCER:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(23, 39);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(87, 18);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "REPORT ID:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.AddStaffButton);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Location = new System.Drawing.Point(12, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 100);
            this.panel1.TabIndex = 9;
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Angle = 70F;
            this.AddStaffButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddStaffButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddStaffButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddStaffButton.BorderRadius = 17;
            this.AddStaffButton.BorderSize = 0;
            this.AddStaffButton.Color0 = System.Drawing.Color.Aquamarine;
            this.AddStaffButton.Color1 = System.Drawing.Color.Aqua;
            this.AddStaffButton.FlatAppearance.BorderSize = 0;
            this.AddStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStaffButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.AddStaffButton.ForeColor = System.Drawing.Color.Black;
            this.AddStaffButton.Location = new System.Drawing.Point(3, 27);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(175, 47);
            this.AddStaffButton.TabIndex = 2;
            this.AddStaffButton.Text = "ADD";
            this.AddStaffButton.TextColor = System.Drawing.Color.Black;
            this.AddStaffButton.UseVisualStyleBackColor = false;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            this.AddStaffButton.MouseEnter += new System.EventHandler(this.roundedbutton3_MouseEnter);
            this.AddStaffButton.MouseLeave += new System.EventHandler(this.roundedbutton3_MouseLeave);
            // 
            // btnupdate
            // 
            this.btnupdate.Angle = 177F;
            this.btnupdate.BackColor = System.Drawing.Color.Lavender;
            this.btnupdate.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnupdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnupdate.BorderRadius = 17;
            this.btnupdate.BorderSize = 0;
            this.btnupdate.Color0 = System.Drawing.Color.Aquamarine;
            this.btnupdate.Color1 = System.Drawing.Color.Aqua;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(1056, 27);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(175, 47);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextColor = System.Drawing.Color.Black;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.roundedbutton2_Click);
            this.btnupdate.MouseEnter += new System.EventHandler(this.roundedbutton2_MouseEnter);
            this.btnupdate.MouseLeave += new System.EventHandler(this.roundedbutton2_MouseLeave);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.Angle = 78F;
            this.deletebtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deletebtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deletebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deletebtn.BorderRadius = 17;
            this.deletebtn.BorderSize = 0;
            this.deletebtn.Color0 = System.Drawing.Color.Aquamarine;
            this.deletebtn.Color1 = System.Drawing.Color.Aqua;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.Location = new System.Drawing.Point(506, 27);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(175, 47);
            this.deletebtn.TabIndex = 0;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.TextColor = System.Drawing.Color.Black;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.roundedbutton1_Click);
            this.deletebtn.MouseEnter += new System.EventHandler(this.roundedbutton1_MouseEnter);
            this.deletebtn.MouseLeave += new System.EventHandler(this.roundedbutton1_MouseLeave);
            // 
            // StaffGridView
            // 
            this.StaffGridView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StaffGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGridView.ColumnHeadersHeight = 40;
            this.StaffGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StaffGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.StaffGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StaffGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.StaffGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.StaffGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.StaffGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.StaffGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.StaffGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.StaffGridView.CurrentTheme.Name = null;
            this.StaffGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.StaffGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StaffGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffGridView.EnableHeadersVisualStyles = false;
            this.StaffGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.StaffGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.StaffGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.StaffGridView.HeaderForeColor = System.Drawing.Color.White;
            this.StaffGridView.Location = new System.Drawing.Point(12, 65);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.RowHeadersVisible = false;
            this.StaffGridView.RowHeadersWidth = 51;
            this.StaffGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StaffGridView.RowTemplate.Height = 40;
            this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridView.Size = new System.Drawing.Size(1234, 470);
            this.StaffGridView.TabIndex = 5;
            this.StaffGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            this.StaffGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.StaffGridView_EditingControlShowing);
            this.StaffGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StaffGridView_UserDeletingRow);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1258, 984);
            this.ControlBox = false;
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Panel panel1;
        private Button_Custom.Roundedbutton AddStaffButton;
        private Button_Custom.Roundedbutton btnupdate;
        private Button_Custom.Roundedbutton deletebtn;
        private Bunifu.UI.WinForms.BunifuDataGridView StaffGridView;
    }
}