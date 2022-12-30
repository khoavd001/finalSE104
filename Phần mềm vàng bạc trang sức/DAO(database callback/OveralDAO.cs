using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback
{
    public class OveralDAO
    {
        private static OveralDAO instance;
        public static OveralDAO Instance
        {
            get { if (instance == null) instance = new OveralDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable LoadTop5Product()
        {

            string query = string.Format("select TOP 5 ProductName from Product,Inventory_Report where Product.PID=Inventory_Report.PID group by ProductName order by sum(QuantitySold) desc " );
            

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string LoadTotalProduct()
        {

            string query = string.Format("SELECT SUM(QuantityPurchased)FROM Inventory_Report");
          

            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
        public string LoadSoldProduct()
        {

            string query = string.Format("SELECT SUM(QuantitySold)FROM Inventory_Report");


            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
        public DataTable LoadTotalSold()
        {

            string query = string.Format("SELECT month(SalesSlipDate) as Month, Total From SalesSlip WHERE SalesSlipDate > DATEADD(year,-1,GETDATE())");


            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadTop5Doughnut()
        {

            string query = string.Format("select TOP 5 Inventory_Report.PID, sum(QuantitySold) as Total from Product,Inventory_Report where Product.PID=Inventory_Report.PID group by Inventory_Report.PID order by sum(QuantitySold) desc \r\n ");


            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadSoldChart(string beginYear, string endYear)
        {

            string query = string.Format("SELECT month(SalesSlipDate) as Month, Total From SalesSlip WHERE YEAR(SalesSlipDate) > N'{0}'and YEAR(SalesSlipDate) <N'{1}'",beginYear,endYear);


            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
