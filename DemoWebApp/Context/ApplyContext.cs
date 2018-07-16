using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoWebApp.Context
{
    public class ApplyContext : DbContext
    {
        public DbSet<JobPoster> JobPosters { get; set; }
        public DbSet<ApplyForm> ApllyForms { get; set; } 
    }
}