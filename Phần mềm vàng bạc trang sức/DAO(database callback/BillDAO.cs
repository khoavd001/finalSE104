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
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListBill()
        {

            return DataProvider.Instance.ExecuteQuery("SalesSlipID, SalesSlipDate, CustomerID, StaffID, Total FROM dbo.SalesSlip");
        }


        public bool AddBill(string SalesSlipDate, string CustomerID, string StaffID, int Total)
        {

            string query = string.Format("INSERT INTO SalesSlip (SalesSlipID, SalesSlipDate, CustomerID, StaffID, Total)  VALUES ((Select isnull(max(SalesSlipID)+1,1)From salesSlip), '{0}', '{1}', '{2}' , '{3}')", SalesSlipDate, CustomerID, StaffID, Total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable GetBillDetail(int SalesSlipID)
        {
            string query = string.Format("SELECT SalesSlipID, PID, AMOUNT, SellUnitPrice, Discount, TAX, Total FROM dbo.SalesSlip_Detail where  SalesSlipID ='{0}'", SalesSlipID);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddBillDetails(int PID, int Amount, int SellUnitPrice, double Discount, double TAX, int Total)
        {

            string query = string.Format("INSERT INTO SalesSlip_Detail (SalesSlipID, PID, AMOUNT, SellUnitPrice, Discount, TAX, Total)  VALUES ((Select isnull(max(SalesSlipID),1)From salesSlip), '{0}','{1}', '{2}', '{3}', '{4}','{5}')", PID, Amount, SellUnitPrice, Discount, TAX, Total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool Sell(int amount, int PID)
        {



            string query = string.Format("UPDATE Product SET Amount= (Select amount WHERE PID={0}) - " + amount + " WHERE PID={0}", PID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}