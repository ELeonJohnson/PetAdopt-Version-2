using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Data;
using PetAdopt.Models;
using PetAdopt.ViewModels;

namespace PetAdopt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            DisplayingPetsViewModel dpvm = new DisplayingPetsViewModel();
            dpvm.displayReptiles = _context.Reptiles.OrderByDescending(r => r.ReptileId).Take(2).ToList();
            dpvm.displayDogs = _context.Dogs.OrderByDescending(r => r.DogId).Take(2).ToList();
            dpvm.displayCats = _context.Cats.OrderByDescending(r => r.CatId).Take(2).ToList();

            return View(dpvm);
        }

        public IActionResult About()
        {
         
            return View();
        }

        



    }
}
