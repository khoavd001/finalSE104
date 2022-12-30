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
    public partial class FrmServiceDetail : Form
    {
        int S_ID = 0;
        int Subtotal = 0;
        int total = 0;
        public FrmServiceDetail()
        {
            InitializeComponent();
            othercost_txt.Text = "0";
            


            
        }

        private void Deposit_txt_TextChanged(object sender, EventArgs e)
        {
            remain_txt.Text = (total - int.Parse(Deposit_txt.Text)).ToString();
        }

        private void Total_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Request_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffId_txt.Text) || string.IsNullOrEmpty(CustomerId_txt.Text) || string.IsNullOrEmpty(amount_txt.Text) || string.IsNullOrEmpty(ProductID_txt.Text) || string.IsNullOrEmpty(es_txt.Text) || string.IsNullOrEmpty(othercost_txt.Text) || string.IsNullOrEmpty(Deposit_txt.Text) || string.IsNullOrEmpty(remain_txt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;

            }
            else
            {
                DateTime today = DateTime.Today;
                if (int.Parse(Deposit_txt.Text) < total * 0.5)
                    MessageBox.Show(" Deposit must more than  " + total * 0.5);
                if (ServiceDAO.Instance.AddService(today.ToString(), int.Parse(CustomerId_txt.Text), int.Parse(StaffId_txt.Text), total, int.Parse(Deposit_txt.Text), int.Parse(remain_txt.Text)))
                {
                    ServiceDAO.Instance.AddServicedetail(S_ID, int.Parse(ProductID_txt.Text), int.Parse(othercost_txt.Text), Subtotal, int.Parse(amount_txt.Text), total, int.Parse(Deposit_txt.Text), int.Parse(remain_txt.Text), es_txt.Text, remark_txt.Text);
                }
            }
        }

        private void Service_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Service_txt.Text == "Gemstone Maintenance Service")
            {
                S_ID = 30001;
                Subtotal = 25000000;
                Subtotal_txt.Text = "25000000";
            }
            else if (Service_txt.Text == "Order By Pattern")
            {
                S_ID = 30002;
                Subtotal = 500000;
                Subtotal_txt.Text = "500000";
            }
            
        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {
            
                total = (Subtotal + int.Parse(othercost_txt.Text)) * int.Parse(amount_txt.Text);
            Total_txt.Text = total.ToString();
        }

        private void Subtotal_txt_TextChanged(object sender, EventArgs e)
        {
            Total_txt_TextChanged(sender, e);
            Deposit_txt_TextChanged(sender, e);
        }
    }
}
