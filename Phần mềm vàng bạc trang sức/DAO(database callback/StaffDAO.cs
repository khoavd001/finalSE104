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
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListStaff()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT StaffId, StaffName, Gender, ContactPhone, EmailAddress,Manager , Shift FROM dbo.Staff where visible=1");
        }
        public bool DeleteStaff(string StaffName)
        {
            string query = string.Format("UPDATE Staff SET visible = 0 WHERE StaffName=N'{0}'", StaffName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStaff(string StaffName, string Gender, string ContactPhone, string EmailAddress, int Shift, int StaffId,string IsManager)
        {
            


            string query = string.Format("UPDATE Staff SET StaffName= N'{0}',Gender=N'{1}',ContactPhone=N'{2}',EmailAddress=N'{3}',Shift=" + Shift + ",Manager=N'{4}' WHERE StaffId=" + StaffId, StaffName, Gender, ContactPhone, EmailAddress, IsManager);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddStaff(string StaffName, string Gender, string ContactPhone, string EmailAddress, int Shift)
        {

            string query = string.Format("INSERT INTO Staff (StaffID, StaffName, Gender, ContactPhone, EmailAddress, Manager, Shift,visible) VALUES ((Select isnull(max(StaffID)+1,1)From Staff), N'{0}', N'{1}', N'{2}', N'{3}', 0, "+Shift+",1)", StaffName, Gender, EmailAddress, ContactPhone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
