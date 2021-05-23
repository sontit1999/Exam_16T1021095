using Exam_16T1021095.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_16T1021095.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username="",string password = "")
        {
           
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                var user = UtilsDatabase.getDaTaBase().UserAccounts.Where(u => u.Username == username.Trim() && u.Password == password.Trim()).FirstOrDefault();
                if(user != null)
                {
                    // login ok
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // login fail
                    return RedirectToAction("Index", "Account");
                }
            }
            else
            {
                return View();
            }                           
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Account");
        }
    }
}