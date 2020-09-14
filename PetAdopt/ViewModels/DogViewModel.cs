using Microsoft.AspNetCore.Mvc.Rendering;
using PetAdopt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.ViewModels
{
    public class DogViewModel
    {
        public Dog Dog { get; set; }
        public List<Dog> dogs;
        public SelectList ages;
        public string dogAge { get; set; }
        public SelectList genders;
        public string dogGender { get; set; }
        public SelectList types;
        public string dogType { get; set; }
        public SelectList sizes;
        public string dogSize { get; set; }
        public SelectList colors;
        public string dogColor { get; set; }
    }
}
