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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            StaffGridView.DataSource = StaffDAO.Instance.GetListStaff();
            StaffGridView.Columns[0].ReadOnly=true;
            StaffGridView.Columns[1].HeaderText = "Name";
            StaffGridView.Columns[2].HeaderText = "Gender";
            StaffGridView.Columns[3].HeaderText = "Contact Phone";
            StaffGridView.Columns[4].HeaderText = "Email";
            StaffGridView.Columns[6].HeaderText = "Shift";
        }
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter(object sender, EventArgs e)
        {
            btnupdate.Color1 = Color.Blue;
        }
        
        private void roundedbutton2_Click(object sender, EventArgs e)
        {
            string Name = (StaffGridView.CurrentRow.Cells[1].Value).ToString();
            string Gender = (StaffGridView.CurrentRow.Cells[2].Value).ToString();
            string ContactPhone = (StaffGridView.CurrentRow.Cells[3].Value).ToString();
            string EmailAddress = (StaffGridView.CurrentRow.Cells[4].Value).ToString();
            string isManager = (StaffGridView.CurrentRow.Cells[5].Value).ToString();
            string Shift = (StaffGridView.CurrentRow.Cells[6].Value).ToString();
            string StaffId = (StaffGridView.CurrentRow.Cells[0].Value).ToString();
            UpdateStaff(Name, Gender, ContactPhone, EmailAddress, Int32.Parse(Shift), Int32.Parse(StaffId),isManager);
            LoadStaff();
        }
        void UpdateStaff(string StaffName, string Gender, string ContactPhone, string EmailAddress, int Shift, int StaffId,string isManager) 
        {
            if (StaffDAO.Instance.UpdateStaff(StaffName, Gender, ContactPhone, EmailAddress, Shift, StaffId, isManager) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }

            LoadStaff();
        }

        private void roundedbutton2_MouseLeave(object sender, EventArgs e)
        {
            btnupdate.Color1 = Color.Aqua;
        }

        private void roundedbutton1_MouseEnter(object sender, EventArgs e)
        {
            deletebtn.Color1 = Color.Blue;
        }

        private void roundedbutton1_MouseLeave(object sender, EventArgs e)
        {
            deletebtn.Color1 = Color.Aqua;
        }

        private void roundedbutton3_MouseEnter(object sender, EventArgs e)
        {
            AddStaffButton.Color1 = Color.Blue;
        }

        private void roundedbutton3_MouseLeave(object sender, EventArgs e)
        {
            AddStaffButton.Color1 = Color.Aqua;

        }
        void DeleteAccount(string userName)
        {

            if (StaffDAO.Instance.DeleteStaff(userName) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }

            LoadStaff();
        }
        private void StaffGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {


            DeleteAccount((StaffGridView.CurrentRow.Cells[1].Value).ToString());
            


            LoadStaff();

        }

        private void roundedbutton1_Click(object sender, EventArgs e)
        {
            DeleteAccount((StaffGridView.CurrentRow.Cells[1].Value).ToString());



            LoadStaff();
        }

        private void StaffGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (StaffGridView.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            if (StaffGridView.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            AddStaff f = new AddStaff();
            f.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            LoadStaff();
        }
    }
}
