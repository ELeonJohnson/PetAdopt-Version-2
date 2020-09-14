using Microsoft.AspNetCore.Mvc.Rendering;
using PetAdopt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.ViewModels
{
    public class CatViewModel
    {
        public Cat Cat { get; set; }
        public List<Cat> cats;
        public SelectList ages;
        public string catAge { get; set; }
        public SelectList genders;
        public string catGender { get; set; }
        public SelectList types;
        public string catType { get; set; }
        public SelectList sizes;
        public string catSize { get; set; }
        public SelectList colors;
        public string catColor { get; set; }
    }
}
