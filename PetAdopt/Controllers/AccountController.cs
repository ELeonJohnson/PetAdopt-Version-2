using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Data;
using PetAdopt.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetAdopt.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }


        public async Task<IActionResult> ListOwners(string searchString, string ownerState, string ownerCity,
            string ownerFirstName, string ownerLastName)
        {
            IQueryable<string> stateQuery = from s in _context.Users
                                             where s.RoleName == "5"
                                             orderby s.State
                                             select s.State;
            IQueryable<string> cityQuery = from c in _context.Users
                                            where c.RoleName == "5"
                                            orderby c.City
                                            select c.City;
            IQueryable<string> firstNameQuery = from fn in _context.Users
                                            where fn.RoleName == "5"
                                            orderby fn.FirstName
                                            select fn.FirstName;
            IQueryable<string> lastNameQuery = from ln in _context.Users
                                            where ln.RoleName == "5"
                                            orderby ln.LastName
                                            select ln.LastName;

            var owners = _userManager.Users.Where(u => u.RoleName == "5");

            if (!string.IsNullOrEmpty(searchString))
            {
                owners = owners.Where(un => un.UserName.Contains(searchString) && un.RoleName == "5");

            }
            else if (!string.IsNullOrEmpty(ownerState))
            {
                owners = owners.Where(s => s.State == ownerState);

            }
            else if (!string.IsNullOrEmpty(ownerCity))
            {
                owners = owners.Where(c => c.City == ownerState);

            }
            else if (!string.IsNullOrEmpty(ownerFirstName))
            {
                owners = owners.Where(fn => fn.FirstName == ownerFirstName);

            }
            else if (!string.IsNullOrEmpty(ownerLastName))
            {
                owners = owners.Where(ln => ln.LastName == ownerLastName);

            }

            
            var ownerVM = new OwnerViewModel();
            ownerVM.states = new SelectList(await stateQuery.Distinct().ToListAsync());
            ownerVM.cities = new SelectList(await cityQuery.Distinct().ToListAsync());
            ownerVM.firstNames = new SelectList(await firstNameQuery.Distinct().ToListAsync());
            ownerVM.lastNames = new SelectList(await lastNameQuery.Distinct().ToListAsync());
            


            ownerVM.owners = await owners.ToListAsync();

            return View(ownerVM);
        }



        public async Task<IActionResult> ListAdopters(string searchString, string adopterState, string adopterCity,
            string adopterFirstName, string adopterLastName)
        {
            IQueryable<string> stateQuery = from s in _context.Users
                                            where s.RoleName == "6"
                                            orderby s.State
                                            select s.State;
            IQueryable<string> cityQuery = from c in _context.Users
                                           where c.RoleName == "6"
                                           orderby c.City
                                           select c.City;
            IQueryable<string> firstNameQuery = from fn in _context.Users
                                                where fn.RoleName == "6"
                                                orderby fn.FirstName
                                                select fn.FirstName;
            IQueryable<string> lastNameQuery = from ln in _context.Users
                                               where ln.RoleName == "6"
                                               orderby ln.LastName
                                               select ln.LastName;

            var adopters = _userManager.Users.Where(u => u.RoleName == "6");

            if (!string.IsNullOrEmpty(searchString))
            {
                adopters = adopters.Where(un => un.UserName.Contains(searchString) && un.RoleName == "6");

            }
            else if (!string.IsNullOrEmpty(adopterState))
            {
                adopters = adopters.Where(s => s.State == adopterState);

            }
            else if (!string.IsNullOrEmpty(adopterCity))
            {
                adopters = adopters.Where(c => c.City == adopterState);

            }
            else if (!string.IsNullOrEmpty(adopterFirstName))
            {
                adopters = adopters.Where(fn => fn.FirstName == adopterFirstName);

            }
            else if (!string.IsNullOrEmpty(adopterLastName))
            {
                adopters = adopters.Where(ln => ln.LastName == adopterLastName);

            }


            var adopterVM = new AdopterViewModel();
            adopterVM.states = new SelectList(await stateQuery.Distinct().ToListAsync());
            adopterVM.cities = new SelectList(await cityQuery.Distinct().ToListAsync());
            adopterVM.firstNames = new SelectList(await firstNameQuery.Distinct().ToListAsync());
            adopterVM.lastNames = new SelectList(await lastNameQuery.Distinct().ToListAsync());



            adopterVM.adopters = await adopters.ToListAsync();

            return View(adopterVM);
        }
    }
}
