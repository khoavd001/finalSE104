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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)//picLock
        {

        }

        private void Login_Load(object sender, EventArgs e)//Login_Load
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)//picUsername
        {

        }

        private void button1_Click(object sender, EventArgs e)//bntSignin
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (Signin(username, password))
            {
                Navigation f = new Navigation();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong");
            }
        }

        bool Signin(string username, string password)
        {
            return AccountDAO.Instance.Signin(username, password);
        }

        private void button3_Click(object sender, EventArgs e)//bntEXIT
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)//picLogo
        {

        }

        private void picPassword_Click(object sender, EventArgs e)//picPassword
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)//tbPassword
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit program?", "Notication", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)//tbUsername
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
