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
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListService()
        {
            return DataProvider.Instance.ExecuteQuery(" select S_VoucherID, S_VoucherDate, CustomerName, StaffID, Total,TotalRemainingMoney, Status from ServiceVoucher join customer on ServiceVoucher.CustomerID = Customer.CustomerID");
        }
        public bool AddService(string S_VoucherDate, int CustomerIDd, int StaffID, int Total, int TotalPrepayment, int TotalRemainingMoney)
        {

            string query = string.Format("INSERT INTO ServiceVoucher (S_VoucherID, S_VoucherDate, CustomerID, StaffID, Total, TotalPrepayment, TotalRemainingMoney, Status) VALUES ((Select isnull(max(S_VoucherID)+1,1) from ServiceVoucher), '{0}', '{1}', '{2}', '{3}', '{4}','{5}','Undone')", S_VoucherDate, CustomerIDd, StaffID, Total, TotalPrepayment, TotalRemainingMoney);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool AddServicedetail(int S_ID, int PID, int OtherCosts, int EstimatedUnitPrice, int AMOUNT, int SubToTal, int AdvanceDeposit, int Remaining, string EstimatedRepairDate, string Remark)
        {

            string query = string.Format(" insert into ServiceVoucher_Detail( S_VoucherID, S_ID, PID, OtherCosts, EstimatedUnitPrice, AMOUNT, SubTotal, AdvanceDeposit, Remaining, EstimatedRepairDate,  Remarks, Status) VALUES ((Select isnull(max(S_VoucherID),1) from ServiceVoucher), '{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}','{7}','{8}','{9}','Not delivered yet')", S_ID, PID, OtherCosts, EstimatedUnitPrice, AMOUNT, SubToTal, AdvanceDeposit, Remaining, EstimatedRepairDate, Remark);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}