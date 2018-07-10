using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShopDAO.Utils
{
    public class DBConnector
    {
        private SqlConnection sqlConnect = null;
        private SqlTransaction sqlTran = null;

        private string ConnectionString = string.Empty;

        private void Init()
        {
            try
            {
                sqlConnect = new SqlConnection();
            }
            catch(Exception ex)
            {
                
            }
        }
        /// <summary>
        /// Huy.le
        /// </summary>
        /// <param name="ConnectionString">Connection String to Connect to Database</param>
        public void SetConnectionString(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            this.sqlConnect.ConnectionString = ConnectionString;
        }



        private int Connect()
        {
            bool isOpen = true;
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                    sqlConnect.Open();
            }
            catch(Exception ex)
            {
                isOpen = false;
            }
            return isOpen ? 1 : -1;
        }
        public DataSet ExecuteSP(SqlCommand cmd)
        {
            DataSet ds = null;
            try
            {
                if (this.Connect() == -1)
                    return null;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlConnect;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    ds = new DataSet("DataSet");
                    da.Fill(ds);
                };
            }
            catch(Exception ex)
            {

            }
            return ds;
        }

        public int CloseConnect()
        {
            int iClose = 1;
            try
            {
                if (sqlConnect != null)
                    sqlConnect.Close();
            }
            catch(Exception ex)
            {
                iClose = 0;
            }
            return iClose;
        }
    }
}
