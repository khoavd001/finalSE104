using Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string Name = NameAddTxt.Text;
            string Gender = GenderAddTxt.Text;
            string Address = AddressAddTxt.Text;
            string Contact = PhoneTxtAdd.Text;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Contact))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            
            if (CustomerDAO.Instance.AddCustomer(Name, Gender, Address, Contact))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
               
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Đăng Ký tài khoản thất bại");
            }
            
            
        }

        private void PhoneTxtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhoneTxtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressAddTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderAddTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void NameAddTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
