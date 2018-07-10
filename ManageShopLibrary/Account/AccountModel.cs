using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShopLibrary.Account
{
    public class AccountModel
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ID { get; set; }
        public DateTime? DOB { get; set; }

        public AccountModel() { }
        public AccountModel(DataRow row)
        {
            
        }
    }
}
