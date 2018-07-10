using ManageShopWeb.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageShopWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        [Route("Login")]
        [CheckLoginAttributes]
        public ActionResult Login()
        {
            return View();
        }
    }
}