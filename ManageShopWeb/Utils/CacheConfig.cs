using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ManageShopWeb.Utils
{
    public class CacheConfig
    {
        public Dictionary<string, string> lstCacheConfig = new Dictionary<string, string>();
        
        public CacheConfig()
        {
            if (lstCacheConfig.Count == 0)
            {
                lstCacheConfig.Add("LogFolderPath", WebConfigurationManager.AppSettings["LogFolderPath"]);
            }
        }
    }
}