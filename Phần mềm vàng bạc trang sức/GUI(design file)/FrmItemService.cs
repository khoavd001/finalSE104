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
namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class FrmItemService : Form
    {
        public FrmItemService()
        {
            InitializeComponent();
            LoadService();
        }

        private void FrmItemService_Load(object sender, EventArgs e)
        {

        }
        void LoadService()
        {

            ServiceGridView.DataSource = ServiceDAO.Instance.GetListService();
            ServiceGridView.ReadOnly = true;
            ServiceGridView.Columns[0].HeaderText = "ID";
            ServiceGridView.Columns[1].HeaderText = "Date";
            ServiceGridView.Columns[2].HeaderText = "Customer Name";
            ServiceGridView.Columns[3].HeaderText = "Staff ID";
            ServiceGridView.Columns[4].HeaderText = "Price";
            ServiceGridView.Columns[5].HeaderText = "Remaining";
            ServiceGridView.Columns[6].HeaderText = "Status";

        }

        private void Sellbtn_Click(object sender, EventArgs e)
        {
            FrmServiceDetail  f = new FrmServiceDetail();
            f.Show();
        }
    }
}
