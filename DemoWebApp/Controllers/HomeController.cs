using DemoWebApp.Context;
using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        //using context
        ApplyContext context = new ApplyContext();

        public ActionResult Index()
        {
            //creating job poster
            //var poster = new JobPoster
            //{
            //    Salary=2400,
            //    Name=".NET developer",
            //    Experience=">rok",
            //    Description="Bardzo fajna fucha, polecam.",
            //    Contract="UoP"
            //};

            //context.JobPosters.Add(poster);
            //context.SaveChanges();

            // Adding Company Details info on main screen (in div)
            CompanyDetails details = new CompanyDetails
            {
                CompYears = "Na rynku od 28 lat",
                Customers = "400 zadowolonych klientów",
                Employers = "32 wykwalifikowanych pracowników",
                Partners = "8 partnerów biznesowych",
                Products = "Produkty dostępne dla 6 różnych branż"
            };

            ViewData["CompDetails"] = details;
            return View(details);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}