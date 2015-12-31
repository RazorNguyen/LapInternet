using Site.Model;
using Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.HeaderPage = "Trang Chủ";

            return View("About");
        }

        public ActionResult About()
        {
            ViewBag.HeaderPage = "Thông tin về Internet FPT Telecom";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.HeaderPage = "Liên hệ";
            return View();
        }

        public ActionResult Result()
        {
            ViewBag.HeaderPage = "Thông Báo";
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.HeaderPage = "Đăng kí trực tuyến";
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var service = new HomeService();
            var result = service.Register(model);

            return RedirectToAction("Result");
        }
    }
}