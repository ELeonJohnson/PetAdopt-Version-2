using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace PetAdopt.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public byte[] Image { get; set; }
        [Display(Name = "Food Requirements")]
        public string FoodReq { get; set; }
        [Display(Name = "Habitat Requiremtns")]
        public string HabitatReq { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Display(Name = "Recent Checkup")]
        public bool RecentCheckup { get; set; }
        public bool Trained { get; set; }
        public bool Neutered { get; set; }
        public bool Declawed { get; set; }
        [Display(Name = "Good With Dogs")]
        public bool GoodWithDogs { get; set; }
        [Display(Name = "Good With Other Cats")]
        public bool GoodWithCats { get; set; }
        [Display(Name = "Good With Kids")]
        public bool GoodWithKids { get; set; }

        
        public ApplicationUser ApplicationUser { get; set; }

        public int ApplicationUserId { get; set; }
    }
}
