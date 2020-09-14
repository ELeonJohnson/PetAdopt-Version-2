using Microsoft.AspNetCore.Identity;
using PetAdopt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Reptile> Reptiles { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Image")]
        public byte[] Image { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }

        [Display(Name ="Role Name")]
        public string RoleName { get; set; }



    }
}
