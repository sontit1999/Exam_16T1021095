using Exam_16T1021095_BusinessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_16T1021095.Web.Controllers
{
    public class BaiThiController : Controller
    {
        AccountBUL accountBUL = new AccountBUL();

        // GET: BaiThi

        public ActionResult Index()
        {
            var listAcc = accountBUL.getAllAccount();
            ViewBag.listAcc = listAcc;
            return View();
        }
    }
}