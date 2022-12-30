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
    public partial class Product : Form
    {
        public static string currentpid;
        public Product()
        {
            InitializeComponent();
            try { LoadProduct(); }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        void LoadProduct()
        {
            
            ProductGridview.DataSource = ProductDAO.Instance.GetListProduct();
            ProductGridview.Columns[0].ReadOnly = true;
            ProductGridview.Columns[1].HeaderText = "Name";
            ProductGridview.Columns[2].HeaderText = "Type Name";
            ProductGridview.Columns[3].HeaderText = "Amount";
            ProductGridview.Columns[4].HeaderText = "Price";
            
        }

        

        private void ProductGridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            int rowindex = ProductGridview.CurrentCell.RowIndex;


            currentpid = ProductGridview.Rows[rowindex].Cells[0].Value.ToString();
            FrmItemProduct f = new FrmItemProduct();
            f.Show();

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            int rowindex = ProductGridview.CurrentCell.RowIndex;
            currentpid = ProductGridview.Rows[rowindex].Cells[0].Value.ToString();
            String amount= ProductGridview.Rows[rowindex].Cells[3].Value.ToString();
            int amounts = Int32.Parse(amount);
            int pid = Int32.Parse(currentpid);
            UpdateProduct(pid, amounts);
        }
        void UpdateProduct(int id,int amounts)
        {
            if (ProductDAO.Instance.UpdateProduct(id, amounts)) {
                MessageBox.Show("Sửa sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }
        
        }
    }
}
