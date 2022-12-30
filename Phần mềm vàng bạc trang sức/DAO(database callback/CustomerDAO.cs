using Phần_mềm_vàng_bạc_trang_sức.DTO_build_object_class_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO() { }
        public DataTable GetListCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT CustomerID, CustomerName, Gender, Address, ContactPhone, Totalmoney,VIP FROM dbo.Customer where visible=1");
        }
        public bool AddCustomer(string CustomerName, string Gender, string Address, string ContactPhone)
        {

            string query = string.Format("INSERT INTO Customer (CustomerID, CustomerName, Gender, Address, ContactPhone, Totalmoney, VIP, visible) VALUES ((Select isnull(max(CustomerID)+1,1)From Customer), N'{0}',  N'{1}',  N'{2}',  N'{3}', 0, 0,1)", CustomerName, Gender, Address, ContactPhone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCustomer(string CustomerName)
        {
            string query = string.Format("UPDATE Customer SET visible = 0 WHERE CustomerName=N'{0}'", CustomerName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomer(string CustomerName, string Gender, string ContactPhone, string Address, int Totalmoney, int CustomerID, string VIP)
        {



            string query = string.Format("UPDATE Customer SET CustomerName= N'{0}',Gender=N'{1}',ContactPhone=N'{2}',Address=N'{3}',Totalmoney=" + Totalmoney + ",VIP=N'{4}' WHERE CustomerID=" + CustomerID, CustomerName, Gender, ContactPhone, Address, VIP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMoney(int Totalmoney, int CustomerID)
        {



            string query = string.Format("UPDATE Customer SET Totalmoney= (Select Totalmoney WHERE CustomerID={0}) + " + Totalmoney + " WHERE CustomerID={0}", CustomerID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}