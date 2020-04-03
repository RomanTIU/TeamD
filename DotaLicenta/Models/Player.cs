using DotaLicenta.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElectronicLicenta.Models
{
    public enum Roles {HardSupport,SoftSupport,HardLiner,Midder,Core}
    public class Player
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter NickName"), MaxLength(30)]
        public string NickName { get; set; }

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
              
        [Required(ErrorMessage = "Please enter Second name"), MaxLength(30)]
        [Display(Name = "Second Name")]
        public string SurName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Adress")]
        public string Adress { get; set; }        
        public Roles Role { get; set; } 
        public int Rating { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }
        
        [Display(Name = "Add photo")]
        public string ImagePath { get; set; }
        
        [Required(ErrorMessage = "Please enter Country  "), MaxLength(30)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter Nationality"), MaxLength(30)]
        public string Nationality { get; set; }
               
        [Required(ErrorMessage = "Please enter City"), MaxLength(30)]
        public string City { get; set; }
                
        [Required(ErrorMessage = "Please enter About Me")]
        [Display(Name = "About Me")]
        public string AboutMe { get; set; } 
       
        public string Owner { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}