using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class FrmBill : Form
    {
        public static List<ItemTemp> itemTemps = new List<ItemTemp>();
        public FrmBill()
        {
            InitializeComponent();
            MakeData();
        }

        private void MakeData()
        {
            double subtotal = 0;
            double tax = 0;
         
            billform.DataSource = itemTemps;
            foreach(var item in itemTemps)
            {
                subtotal += item.Total;
            }
            subTotal_txt.Text = subtotal.ToString();
            tax = (subtotal * 0.1);
            tax_txt.Text = tax.ToString();
            total_txt.Text = (subtotal+tax).ToString();
            foreach (DataGridViewRow row in billform.Rows)
                row.DefaultCellStyle.BackColor = Color.Red;
        }
        public class ItemTemp
        { 
            public int PID { get; set; }
            public string ItemName { get; set; }
            public int Price { get; set; }
            public int Amount { get; set; }
            public int Discount { get; set; }
            public int Total { get; set; }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = billform.Rows[e.RowIndex];// get you required index
                                                         // check the cell value under your specific column and then you can toggle your colors
            row.DefaultCellStyle.BackColor = Color.FromArgb(215,245,244);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnSell.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnSell.Cursor = Cursors.Default;
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            if (string.IsNullOrEmpty(StaffId_txt.Text) || string.IsNullOrEmpty(CustomerId_txt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Yes", "Please confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BillDAO.Instance.AddBill(today.ToString(), CustomerId_txt.Text, StaffId_txt.Text, int.Parse(total_txt.Text)))
                    {
                        foreach (var item in itemTemps)
                        {
                            BillDAO.Instance.AddBillDetails(item.PID, item.Amount, item.Price, item.Discount, int.Parse(tax_txt.Text), item.Total);
                            BillDAO.Instance.Sell(item.PID, item.Amount);
                        }
                        MessageBox.Show("Successfully");
                    }
                    CustomerDAO.Instance.UpdateMoney(int.Parse(total_txt.Text), int.Parse(CustomerId_txt.Text));



                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
