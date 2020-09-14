using PetAdopt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.ViewModels
{
    public class DisplayingPetsViewModel 
    {
        public List<Reptile> displayReptiles { get; set; }
        public List<Dog> displayDogs { get; set; }
        public List<Cat> displayCats { get; set; }

    }
}
