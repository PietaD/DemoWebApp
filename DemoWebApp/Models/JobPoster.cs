using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebApp.Models
{
    //Model for job offer
    public class JobPoster
    {
        public int JobPosterID { get; set; }    

        public string Name { get; set; }
        public int Salary { get; set; }
        public string Contract { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        //List<ApplyForm> Applies = new List<ApplyForm>();
        public ICollection<ApplyForm> Apllies { get; set; }
        public int AppliesCounter { get; set; }
        
    }
}