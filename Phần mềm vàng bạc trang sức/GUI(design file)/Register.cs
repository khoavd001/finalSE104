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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            string username = UsernameText.Text;
            string firstname = Firstname.Text;
            string lastname = LastnameText.Text;
            string email = EmailText.Text;
            string password = PasswordText.Text;
            AddAccount(username,lastname,password,email);


        }
        void AddAccount(string userName, string displayName, string matkhau,string email)
        {
            if (string.IsNullOrEmpty(Firstname.Text) || string.IsNullOrEmpty(LastnameText.Text) || string.IsNullOrEmpty(UsernameText.Text) || string.IsNullOrEmpty(PasswordText.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DataTable data = AccountDAO.Instance.ListAccountByUserName(userName);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                return;
            }
            if (AccountDAO.Instance.AddAccount(userName, displayName, matkhau, email) )
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                Login f = new Login();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng Ký tài khoản thất bại");
            }
        }
    }
}
