using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp.Controllers
{
    public class NavOfferController : Controller
    {
        // GET: NavOffer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ERP()
        {
            return View();
        }

        public ActionResult Training()
        {
            return View();
        }
    }
}