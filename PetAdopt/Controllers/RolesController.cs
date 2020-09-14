using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetAdopt.Controllers
{
    public class RolesController : Controller
    {
        RoleManager<IdentityRole<int>> roleManager;
        UserManager<IdentityUser<int>> userManager;

        /// 
        /// Injecting Role Manager
        /// 
        /// 
        public RolesController(RoleManager<IdentityRole<int>> roleManager, UserManager<IdentityUser<int>> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole<int> role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}

