using ManageShopDAO.Utils;
using ManageShopLibrary;
using ManageShopLibrary.Account;
using ManageShopLibrary.Request.Account;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShopDAO
{
    public partial class DataAccess
    {
        public LoginResponseModel AccountLogin(AccountLoginRequest request)
        {
            LoginResponseModel res = new LoginResponseModel();
            string strSP = SqlCommandStore.uspAccountLogin;
            try
            {
                using (SqlCommand cmd = new SqlCommand(strSP))
                {
                    cmd.Parameters.Add("AccountName", SqlDbType.NVarChar, 100).Value = request.AccountName;
                    cmd.Parameters.Add("Password", SqlDbType.NVarChar, 100).Value = request.Password;
                    cmd.Parameters.Add("SessionID", SqlDbType.NVarChar, 100).Value = request.SessionID;
                    DataSet ds = DB.ExecuteSP(cmd);
                };
            }
            catch (Exception ex)
            {
                LogWriter.WriteLogException(ex);
                throw ex;
            }
            return res;
        }
    }
}
