using Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_;
using Phần_mềm_vàng_bạc_trang_sức.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_vàng_bạc_trang_sức
{
    public partial class Navigation : Form
    {

        public Navigation()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.showPanel.Controls.Count > 0)
                this.showPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.showPanel.Controls.Add(f);
            this.showPanel.Tag = f;
            f.Show();
        }
        private void Navigation_Load(object sender, EventArgs e)//Navigation_Load
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)//bntHelpCenter
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)//bntContact
        {

        }

        private void bunifuLabel1_Click_2(object sender, EventArgs e)//LabAeon
        {

        }

        private void tbUsername_Click(object sender, EventArgs e)//tbUsename
        {
            Account f = new Account();
            f.Show();
        }

        private void tbProducer_TextChanged(object sender, EventArgs e)//tbProducer
        {

        }

        private void bntProduct_Click(object sender, EventArgs e)//bntProduct
        {
            loadform(new Product());
        }

        private void bntOverview_Click_2(object sender, EventArgs e)//bntOverview
        {
            loadform(new Dashboard());
        }

        private void bntBill_Click(object sender, EventArgs e)//bntBill
        {
            loadform(new FrmBill());
        }

        private void bntStaff_Click(object sender, EventArgs e)//bntStaff
        {
            loadform(new Staff());
        }

        private void bntCustomer_Click(object sender, EventArgs e)//bntCustomer
        {
            loadform(new CustomerForm());
        }

        private void bntSetting_Click(object sender, EventArgs e)//bntSetting
        {
            loadform(new FrmItemService());
        }

        private void bntLogout_Click(object sender, EventArgs e)//bntLogout
        {
                Login f = new Login();
                this.Hide();
                f.ShowDialog();
               
        }

        private void picSearch_Click(object sender, EventArgs e)//picSearch
        {
           
        }

        private void picNotìication_Click(object sender, EventArgs e)//picNotication
        {

        }

        private void picUsername_Click(object sender, EventArgs e)//picUdername
        {
            Account f = new Account();
            f.Show();
        }

        private void redNotica_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)//Rec_Notica
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void Navigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit program?", "Notication", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbDate2_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
