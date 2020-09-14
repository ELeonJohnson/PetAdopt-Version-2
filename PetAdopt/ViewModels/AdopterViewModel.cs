using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.ViewModels
{
    public class AdopterViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public List<ApplicationUser> adopters;
        public SelectList states;
        public string adopterState { get; set; }
        public SelectList cities;
        public string adopterCity { get; set; }
        public SelectList firstNames;
        public string adopterFirstName { get; set; }
        public SelectList lastNames;
        public string adopterLastName { get; set; }
    }
}
