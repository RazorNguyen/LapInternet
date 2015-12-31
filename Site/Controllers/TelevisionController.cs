using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class TelevisionController : BaseController
    {
        // GET: Television
        public ActionResult Index()
        {
            ViewBag.HeaderPage = "Giới Thiệu Truyền Hình FPT Telecom";
            return View();
        }

        public ActionResult Combo()
        {
            ViewBag.HeaderPage = "Gói Combo gồm Truyền hình + Internet";
            return View();
        }

        public ActionResult Single()
        {
            ViewBag.HeaderPage = "Gói truyền hình riêng lẻ";
            return View();
        }

        public ActionResult ListChanel()
        {
            ViewBag.HeaderPage = "Danh Sách Kênh Truyền Hình FPT Telecom";
            return View();
        }
    }
}