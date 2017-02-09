using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chektheapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            // sabjdfs
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            //ksadhfkhsadk
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}