using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListProduct()
        {
            return DataProvider.Instance.ExecuteQuery(" SELECT  PID, ProductName, PTypeName, AMOUNT, SellUnitPrice from Product join PType on product.ptypeid = ptype.PTypeID");
        }
        public bool UpdateProduct(int PID,int amount)
        {



            string query = string.Format("UPDATE Product SET AMOUNT="+ amount+" WHERE PID=" + PID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
