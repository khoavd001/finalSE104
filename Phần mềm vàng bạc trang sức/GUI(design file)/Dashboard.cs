using Bunifu.UI.WinForms.Helpers.Transitions;
using Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadCustomer();
            LoadChartFirst();
        }
        void LoadCustomer()
        {
            
            TotalMoneyTxt.Text = OveralDAO.Instance.LoadTotalProduct();
            SoldTxt.Text = OveralDAO.Instance.LoadSoldProduct();
            
            foreach (DataGridViewColumn col in this.TopProductGridView.Columns)

            {

                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            TopProductGridView.DataSource = OveralDAO.Instance.LoadTop5Product();
            TopProductGridView.Columns[0].HeaderText = "Top Product";
            TopProductGridView.Columns[0].ReadOnly = true;
            
        }
        void LoadChartFirst()
        {
            TotalSoldChart.DataSource = OveralDAO.Instance.LoadTotalSold();
            TotalSoldChart.Series["Sold"].XValueMember = "Month";
            TotalSoldChart.Series["Sold"].YValueMembers = "Total";

            //Doughnut
            DoughnutChart.DataSource = OveralDAO.Instance.LoadTop5Doughnut();
            DoughnutChart.Series["Top5"].XValueMember = "PID";
            DoughnutChart.Series["Top5"].YValueMembers = "Total";

        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void Top5ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
        }
        

        private void LastmonthButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChartFirst();
            TotalSoldChart.DataSource = OveralDAO.Instance.LoadSoldChart("1890", "2023");
            TotalSoldChart.Series["Sold"].XValueMember = "Month";
            TotalSoldChart.Series["Sold"].YValueMembers = "Total";
        }

        private void TotalSoldChart_Click(object sender, EventArgs e)
        {

        }
    }
}
