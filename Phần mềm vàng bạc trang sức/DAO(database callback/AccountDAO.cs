using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Signin(string username, string password)
        {
            string query = string.Format("SELECT * FROM users WHERE UserName = N'{0}' AND Password =N'{1}'", username, password);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public DataTable ListAccountByUserName(string username)
        {
            string query = string.Format("Select *from users where UserName=N'{0}'", username);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddAccount(string userName, string displayName, string password,string email)
        {
            string gender = "male";
            string query = string.Format("INSERT INTO users (UserID, UserName, DisplayName, Gender, Contact, Address, Email, Password, Type, profile_pic) VALUES ((Select isnull(max(UserID)+1,1)From users), N'{0}', N'{1}', 'Nu','00000000', NULL, N'{2}', N'{3}', 1, NULL)", userName, displayName, email, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        
       
    }
}
