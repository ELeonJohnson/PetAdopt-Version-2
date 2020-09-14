using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetAdopt.Models;

namespace PetAdopt.ViewModels
{
    public class OwnerViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public List<ApplicationUser> owners;
        public SelectList states;
        public string ownerState { get; set; }
        public SelectList cities;
        public string ownerCity { get; set; }
        public SelectList firstNames;
        public string ownerFirstName { get; set; }
        public SelectList lastNames;
        public string ownerLastName { get; set; }
    }
}
