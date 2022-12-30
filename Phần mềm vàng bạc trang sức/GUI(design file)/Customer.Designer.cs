using System;
using System.Windows.Forms;

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class CustomerForm
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
            this.CustomerGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerAddButton = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.UpdateCustomerButton = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.DeleteCustomerButton = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            this.CustomerText = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CustomerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CustomerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGridView.ColumnHeadersHeight = 40;
            this.CustomerGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.CustomerGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CustomerGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CustomerGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.CustomerGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.CustomerGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.CustomerGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.CustomerGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerGridView.CurrentTheme.Name = null;
            this.CustomerGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CustomerGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CustomerGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGridView.EnableHeadersVisualStyles = false;
            this.CustomerGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.CustomerGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.CustomerGridView.HeaderForeColor = System.Drawing.Color.White;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 68);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersVisible = false;
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerGridView.RowTemplate.Height = 40;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(1234, 470);
            this.CustomerGridView.TabIndex = 10;
            this.CustomerGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CustomerAddButton);
            this.panel1.Controls.Add(this.UpdateCustomerButton);
            this.panel1.Controls.Add(this.DeleteCustomerButton);
            this.panel1.Location = new System.Drawing.Point(12, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 100);
            this.panel1.TabIndex = 13;
            // 
            // CustomerAddButton
            // 
            this.CustomerAddButton.Angle = 158F;
            this.CustomerAddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CustomerAddButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CustomerAddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CustomerAddButton.BorderRadius = 17;
            this.CustomerAddButton.BorderSize = 0;
            this.CustomerAddButton.Color0 = System.Drawing.Color.Aquamarine;
            this.CustomerAddButton.Color1 = System.Drawing.Color.Aqua;
            this.CustomerAddButton.FlatAppearance.BorderSize = 0;
            this.CustomerAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerAddButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CustomerAddButton.ForeColor = System.Drawing.Color.Black;
            this.CustomerAddButton.Location = new System.Drawing.Point(3, 27);
            this.CustomerAddButton.Name = "CustomerAddButton";
            this.CustomerAddButton.Size = new System.Drawing.Size(175, 47);
            this.CustomerAddButton.TabIndex = 2;
            this.CustomerAddButton.Text = "ADD";
            this.CustomerAddButton.TextColor = System.Drawing.Color.Black;
            this.CustomerAddButton.UseVisualStyleBackColor = false;
            this.CustomerAddButton.Click += new System.EventHandler(this.CustomerAddButton_Click);
            this.CustomerAddButton.MouseEnter += new System.EventHandler(this.CustomerAddButton_MouseEnter);
            this.CustomerAddButton.MouseLeave += new System.EventHandler(this.CustomerAddButton_MouseLeave);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Angle = 170F;
            this.UpdateCustomerButton.BackColor = System.Drawing.Color.Lavender;
            this.UpdateCustomerButton.BackgroundColor = System.Drawing.Color.Lavender;
            this.UpdateCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UpdateCustomerButton.BorderRadius = 17;
            this.UpdateCustomerButton.BorderSize = 0;
            this.UpdateCustomerButton.Color0 = System.Drawing.Color.Aquamarine;
            this.UpdateCustomerButton.Color1 = System.Drawing.Color.Aqua;
            this.UpdateCustomerButton.FlatAppearance.BorderSize = 0;
            this.UpdateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateCustomerButton.Location = new System.Drawing.Point(1056, 27);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(175, 47);
            this.UpdateCustomerButton.TabIndex = 1;
            this.UpdateCustomerButton.Text = "UPDATE";
            this.UpdateCustomerButton.TextColor = System.Drawing.Color.Black;
            this.UpdateCustomerButton.UseVisualStyleBackColor = false;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            this.UpdateCustomerButton.MouseEnter += new System.EventHandler(this.UpdateCustomerButton_MouseEnter);
            this.UpdateCustomerButton.MouseLeave += new System.EventHandler(this.UpdateCustomerButton_MouseLeave);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCustomerButton.Angle = 106F;
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteCustomerButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteCustomerButton.BorderRadius = 17;
            this.DeleteCustomerButton.BorderSize = 0;
            this.DeleteCustomerButton.Color0 = System.Drawing.Color.Aquamarine;
            this.DeleteCustomerButton.Color1 = System.Drawing.Color.Aqua;
            this.DeleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.DeleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(506, 27);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(175, 47);
            this.DeleteCustomerButton.TabIndex = 0;
            this.DeleteCustomerButton.Text = "DELETE";
            this.DeleteCustomerButton.TextColor = System.Drawing.Color.Black;
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.roundedbutton1_Click_1);
            this.DeleteCustomerButton.MouseEnter += new System.EventHandler(this.roundedbutton1_MouseEnter_1);
            this.DeleteCustomerButton.MouseLeave += new System.EventHandler(this.DeleteCustomerButton_MouseLeave);
            // 
            // CustomerText
            // 
            this.CustomerText.AllowParentOverrides = false;
            this.CustomerText.AutoEllipsis = false;
            this.CustomerText.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerText.CursorType = System.Windows.Forms.Cursors.Default;
            this.CustomerText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerText.Location = new System.Drawing.Point(23, 15);
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerText.Size = new System.Drawing.Size(73, 18);
            this.CustomerText.TabIndex = 11;
            this.CustomerText.Text = "Customer:";
            this.CustomerText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CustomerText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 984);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView CustomerGridView;
        private Panel panel1;
        private Button_Custom.Roundedbutton CustomerAddButton;
        private Button_Custom.Roundedbutton UpdateCustomerButton;
        private Bunifu.UI.WinForms.BunifuLabel CustomerText;
        private Button_Custom.Roundedbutton DeleteCustomerButton;
    }
}