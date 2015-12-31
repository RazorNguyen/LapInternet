using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class CapQuangController : BaseController
    {
        // GET: CapQuang
        public ActionResult Index()
        {
            ViewBag.HeaderPage = "Giới Thiệu về FTTH";
            return View();
        }
        
        public ActionResult Brozen()
        {
            ViewBag.HeaderPage = "Cáp quang FPT - Fiber Brozen - 30->40M";
            return View();
        }

        public ActionResult Public()
        {
            ViewBag.HeaderPage = "Cáp quang FPT - Fiber Public - 45M";
            return View();
        }

        public ActionResult Business()
        {
            ViewBag.HeaderPage = "Cáp quang FPT - Fiber Business - 35M";
            return View();
        }

        public ActionResult Others()
        {
            ViewBag.HeaderPage = "Cáp quang FPT - dành cho cá nhân/Doanh Nghiệp vừa và nhỏ";
            return View();
        }
    }
}