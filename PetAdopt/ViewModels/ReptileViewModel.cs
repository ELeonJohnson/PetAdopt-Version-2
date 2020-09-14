using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.ViewModels
{
    public class ReptileViewModel
    {
        public Reptile Reptile { get; set; }
        public List<Reptile> reptiles;
        public SelectList genders;
        public string reptileGender { get; set; }
        public SelectList ages;
        public string reptileAge { get; set; }
        public SelectList types;
        public string reptileType { get; set; }
        public SelectList sizes;
        public string reptileSize { get; set; }
        public SelectList colors;
        public string reptileColor { get; set; }

      


    }


}
