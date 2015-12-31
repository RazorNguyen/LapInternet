using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class ADSLController : BaseController
    {
        // GET: CapDong
        public ActionResult MegaMe()
        {
            ViewBag.HeaderPage = "Gói cước Internet ADSL MegaMe - 10M";
            return View();
        }
        
        // GET: CapDong
        public ActionResult MegaSave()
        {
            ViewBag.HeaderPage = "Gói cước Internet ADSL MegaSave - 6M";
            return View();
        }
    }
}