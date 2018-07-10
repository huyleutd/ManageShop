using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageShopWeb.Utils
{
    public class ShopSession
    {
        public static UserSession GetUserInfo()
        {
            var data = HttpContext.Current.Session[typeof(UserSession).ToString()] as Dictionary<string, UserSession>;
            return null;
        }

        public static bool IsLogin()
        {
            return GetUserInfo() != null;
        }
    }
}