using Phần_mềm_vàng_bạc_trang_sức.Button_Custom;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        void LoadCustomer()
        {
            CustomerGridView.DataSource = CustomerDAO.Instance.GetListCustomer();
            CustomerGridView.Columns[0].HeaderText = "Id";
            CustomerGridView.Columns[0].ReadOnly=true; 
            CustomerGridView.Columns[1].HeaderText = "Name";
            CustomerGridView.Columns[2].HeaderText = "Gender";
            CustomerGridView.Columns[3].HeaderText = "Address";
            CustomerGridView.Columns[4].HeaderText = "Number";
            CustomerGridView.Columns[5].HeaderText = "Money";
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            
        }
        
        private void roundedbutton1_Click(object sender, EventArgs e)
        {

        }
        Color color0;
        private void roundedbutton1_MouseEnter(object sender, EventArgs e)
        {
            
            
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton1_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
            
        }

        private void roundedbutton3_Click(object sender, EventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;

        }

        private void roundedbutton2_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
        }

        private void roundedbutton3_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedbutton3_MouseEnter_1(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton3_Click_2(object sender, EventArgs e)
        {

        }
        
        private void roundedbutton2_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter_1(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton2_MouseLeave_1(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1= Color.Aqua;
        }

        private void roundedbutton3_MouseEnter_2(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Blue;
        }

        private void roundedbutton3_MouseLeave_1(object sender, EventArgs e)
        {
            CustomerAddButton.Color1= Color.Aqua;
        }

        private void roundedbutton4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CumstomerDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedbutton1_Click_1(object sender, EventArgs e)
        {
            DeleteAccount((CustomerGridView.CurrentRow.Cells[1].Value).ToString());



            LoadCustomer();
        }
        void DeleteAccount(string userName)
        {

            if (CustomerDAO.Instance.DeleteCustomer(userName) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }

            
        }
        private void roundedbutton1_MouseEnter_1(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void DeleteCustomerButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
        }

        private void CustomerAddButton_MouseEnter(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Blue;
        }

        private void CustomerAddButton_MouseLeave(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Aqua;
        }

        private void UpdateCustomerButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Blue;
        }

        private void UpdateCustomerButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Aqua;
        }

        private void CustomerAddButton_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
            f.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            LoadCustomer();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            string CustomerName = (CustomerGridView.CurrentRow.Cells[1].Value).ToString();
            string Gender = (CustomerGridView.CurrentRow.Cells[2].Value).ToString();
            string ContactPhone = (CustomerGridView.CurrentRow.Cells[4].Value).ToString();
            string Address = (CustomerGridView.CurrentRow.Cells[3].Value).ToString();
            string Totalmoney = (CustomerGridView.CurrentRow.Cells[5].Value).ToString();
            string VIP = (CustomerGridView.CurrentRow.Cells[6].Value).ToString();
            string CustomerID = (CustomerGridView.CurrentRow.Cells[0].Value).ToString();
            UpdateStaff(Name, Gender, ContactPhone, Address, Int32.Parse(Totalmoney), Int32.Parse(CustomerID), VIP);
            LoadCustomer();
        }
        void UpdateStaff(string CustomerName, string Gender, string ContactPhone, string Address,int Totalmoney, int CustomerID, string VIP)
        {
            if (CustomerDAO.Instance.UpdateCustomer(CustomerName, Gender, ContactPhone, Address, Totalmoney, CustomerID, VIP) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }

            
        }
    }
}
