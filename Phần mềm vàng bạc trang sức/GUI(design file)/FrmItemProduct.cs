using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class FrmItemProduct : Form
    { int PID;
        public FrmItemProduct()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            string connectionSTR = "Data Source=DESKTOP-UMQQF4G\\SQLEXPRESS;Initial Catalog=ES104;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionSTR);
            con.Open();
            PID = int.Parse(Product.currentpid);
            string SqlQuery = "SELECT * FROM Product WHERE PID='" + PID + "'";
            SqlCommand command = new SqlCommand(SqlQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Name_txt.Text = reader["ProductName"].ToString();
                remain_txt.Text = "Remain: " + reader["AMOUNT"].ToString();
                price_txt.Text =   reader["SellUnitPrice"].ToString() ;
                ItemPic.ImageLocation = reader["Picture"].ToString();


            }
        }
        private void Sellbtn_Click(object sender, EventArgs e)
        { 
            try
            {
                FrmBill.itemTemps.Add(new FrmBill.ItemTemp() { PID = PID, ItemName = Name_txt.Text, Price = int.Parse(price_txt.Text), Amount = int.Parse(amount_txt.Text), Discount = 0, Total = int.Parse(price_txt.Text) * int.Parse(amount_txt.Text) });
                MessageBox.Show("Add into bill successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
