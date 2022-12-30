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

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
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

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string Name = NameAddTxt.Text;
            string Gender = GenderAddTxt.Text;
            string Email = EmailTxt.Text;
            string Contact = PhoneTxtAdd.Text;
            string Shift = ShiftTxt.Text;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Contact) || string.IsNullOrEmpty(Shift))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (StaffDAO.Instance.AddStaff(Name, Gender, Email, Contact,Int32.Parse( Shift)))
            {
                MessageBox.Show("Thêm Nhân viên thành công");

                this.Hide();


            }
            else
            {
                MessageBox.Show("Đăng Ký tài khoản thất bại");
            }
        }
    }
}
