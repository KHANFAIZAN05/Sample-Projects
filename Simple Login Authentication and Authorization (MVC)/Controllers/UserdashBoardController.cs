using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Simple_Login_Authentication_and_Authorization__MVC_.Controllers
{
    public class UserdashBoardController : Controller
    {

     
        public ActionResult Index()
        {
            return View();
        }


     
       
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Login");
        }
    }
}