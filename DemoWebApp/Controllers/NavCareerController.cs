using DemoWebApp.Context;
using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp.Controllers
{
    public class NavCareerController : Controller
    {
        // DB context
        ApplyContext context = new ApplyContext();

        // GET: NavCareer
        public ActionResult Index()
        {
            return View();
        }

        // GET all offerts
        public ActionResult Offers()
        {
            var offersList = context.JobPosters
                .Where(m => m.IsDeleted != true)
                .ToList();
                return View(offersList);
        }

        // GET: Career/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Career/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                JobPoster poster = new JobPoster()
                {
                    Name = collection["Name"],
                    Salary = Int32.Parse(collection["Salary"]),
                    Experience = collection["Experience"],
                    Contract = collection["Contract"],
                    Description = collection["Description"],
                    IsDeleted = false
                };

                context.JobPosters.Add(poster);
                context.SaveChanges();

                return RedirectToAction("Offers");
            }
            catch
            {
                return View();
            }
        }

        // GET: NavCareer/Details/5
        public ActionResult Details(int id)
        {
            var query = context.JobPosters
                .Where(s => s.JobPosterID == id)
                .FirstOrDefault<JobPoster>();
            return View(query);
        }

        // GET: NavCareer/Edit/5
        public ActionResult Edit(int id)
        {
            var query = context.JobPosters
                .Where(s => s.JobPosterID == id)
                .FirstOrDefault<JobPoster>();

            return View(query);
        }

        // POST: Edit an offer
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var query = context.JobPosters
                .Where(s => s.JobPosterID == id)
                .FirstOrDefault<JobPoster>();

                query.Name = collection["Name"];
                query.Salary = Int32.Parse(collection["Salary"]);
                query.Experience = collection["Experience"];
                query.Contract = collection["Contract"];
                query.Description = collection["Description"];

                context.SaveChanges();

                return RedirectToAction("Offers");
            }
            catch
            {
                return View();
            }
        }

        // GET: NavCareer/Delete/5
        public ActionResult Delete(int id)
        {
            var query = context.JobPosters
                .Where(s => s.JobPosterID == id)
                .FirstOrDefault<JobPoster>();

            return View(query);
        }

        // POST: NavCareer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var query = context.JobPosters
                .Where(s => s.JobPosterID == id)
                .FirstOrDefault<JobPoster>();

                query.IsDeleted = true;

                context.SaveChanges();

                return RedirectToAction("Offers");
            }
            catch
            {
                return View();
            }
        }

        // GET: NavCareer/Practice
        public ActionResult Practice()
        {
            return View();
        }

        // GET: NavCareer/Recruitment
        public ActionResult Recruitment()
        {
            return View();
        }
    }
}