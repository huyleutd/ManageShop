using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShopLibrary.Request.Account
{
    public class AccountLoginRequest
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string SessionID { get; set; }
    }
}
