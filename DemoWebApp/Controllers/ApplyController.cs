using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp.Controllers
{
    public class ApplyController : Controller
    {
        //TO DO: Create a context structure to handle applies - delete code below (old) - show in modal

        // GET: Apply
        [HttpPost]
        public ActionResult ApplyPattern(string name, string surname, string exp, string tech, int salary)
        {
            string CName = name; string CSurname = surname; string Cexp = exp; string Ctech = tech; int CSalary = salary;
            List<ApplyForm> Applies = new List<ApplyForm>();
            Applies.Add(new ApplyForm{Name=name, Surname=surname, Experience=exp, Technologies=tech, Salary = salary });
            
            return RedirectToAction("DisplayApply");
        }

        public ActionResult Submit(FormCollection form)
        {
            List<ApplyForm> Applies = new List<ApplyForm>();
            Applies.Add(new ApplyForm
            {
                Name = form["name"],
                Surname = form["surname"],
                Experience = form["exp"],
                Technologies = form["tech"],
                Salary = 50
            });
            return View(Applies);
        }

        // Display Apply from ApplyForm Model
        public ActionResult DisplayApply()
        {
            
            return View();
        }
    }
}