using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebApp.Models
{
    public class ApplyForm
    {
        [Key]
        public int ApllyFormID { get; set; }    
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; } 
        public string Technologies { get; set; } 
        public int Salary { get; set; }

        public int JobPosterID { get; set; }
        public virtual JobPoster JobPoster { get; set; }    
    }
}