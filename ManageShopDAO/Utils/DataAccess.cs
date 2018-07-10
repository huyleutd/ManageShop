using ManageShopDAO.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShopDAO
{
    public partial class DataAccess
    {
        public DataAccess() { }
        private DBConnector _db = null;

        public DBConnector DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new DBConnector();
                    _db.SetConnectionString(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
                }
                return _db;
            }
        }
    }
}
