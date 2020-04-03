using ElectronicLicenta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotaLicenta.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }


        [Required(ErrorMessage = "Please enter City"), MaxLength(30)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Add Logo")]
        public string ImagePath { get; set; }
        public string Coach { get; set; } 
        
        public int PlayerId { get; set; }
        public Player Players { get; set; }
    }
}