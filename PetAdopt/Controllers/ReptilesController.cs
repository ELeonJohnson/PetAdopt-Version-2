using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Data;
using PetAdopt.Models;
using System.Web;
using PetAdopt.ViewModels;


namespace PetAdopt.Controllers
{
    public class ReptilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReptilesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Reptiles
        public async Task<IActionResult> Index(string searchString, string reptileGender, 
            string reptileAge, string reptileType, string reptileSize, string reptileColor
            )
        {
            IQueryable<string> genderQuery = from g in _context.Reptiles
                                            orderby g.Gender
                                            select g.Gender;
            IQueryable<string> ageQuery = from a in _context.Reptiles
                                             orderby a.Age
                                             select a.Age;
            IQueryable<string> typeQuery = from t in _context.Reptiles
                                          orderby t.Type
                                          select t.Type;
            IQueryable<string> sizeQuery = from s in _context.Reptiles
                                           orderby s.Size
                                           select s.Size;
            IQueryable<string> colorQuery = from c in _context.Reptiles
                                           orderby c.Color
                                           select c.Color;
            



        var reptiles = from r in _context.Reptiles
                           select r;

            if (!string.IsNullOrEmpty(searchString))
            {
                reptiles = reptiles.Where(r => r.Name.Contains(searchString));

            }
            else if (!string.IsNullOrEmpty(reptileGender)) {
                reptiles = reptiles.Where(g => g.Gender == reptileGender);

            }
            else if (!string.IsNullOrEmpty(reptileAge)) {
                reptiles = reptiles.Where(a => a.Age == reptileAge);

            }
            else if (!string.IsNullOrEmpty(reptileType)) {
                reptiles = reptiles.Where(t => t.Type == reptileType);
            }
            else if (!string.IsNullOrEmpty(reptileSize))
            {
                reptiles = reptiles.Where(s => s.Size == reptileSize);
            }
            else if (!string.IsNullOrEmpty(reptileColor))
            {
                reptiles = reptiles.Where(c => c.Color == reptileColor);
            }

         


            var reptileVM = new ReptileViewModel();
            reptileVM.genders = new SelectList(await genderQuery.Distinct().ToListAsync());
            reptileVM.ages = new SelectList(await ageQuery.Distinct().ToListAsync());
            reptileVM.types = new SelectList(await typeQuery.Distinct().ToListAsync());
            reptileVM.sizes = new SelectList(await sizeQuery.Distinct().ToListAsync());
            reptileVM.colors = new SelectList(await colorQuery.Distinct().ToListAsync());
            

            reptileVM.reptiles = await reptiles.ToListAsync();

            return View(reptileVM);

        }

        // GET: Reptiles/Details/5
        public async Task<IActionResult> Details(int? id, Reptile reptile)
        {
            if (id == null)
            {
                return NotFound();
            }


             reptile = await _context.Reptiles
                .FirstOrDefaultAsync(m => m.ReptileId == id);

            
            var user = _context.Reptiles.Include(r => r.ApplicationUser).Where(r => r.ReptileId == id).FirstOrDefault();

            if (reptile == null)
            {
                return NotFound();
            }

            return View(reptile);
        }


        [Authorize(Roles = "Admin, Owner")]
        // GET: Reptiles/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: Reptiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReptileId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed,ApplicationUserId")] Reptile reptile, IFormFile Image, ApplicationUser user)
        {

            var applicationUserId = _userManager.GetUserId(HttpContext.User);

            reptile.ApplicationUserId = Convert.ToInt32(applicationUserId);

            
          


            if (ModelState.IsValid)
            {
                if (Image != null)

                {
                    if (Image.Length > 0)

                    //Convert Image to byte and save to database

                    {

                        byte[] p1 = null;
                        using (var fs1 = Image.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        reptile.Image = p1;

                    }
                }



                _context.Add(reptile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reptile);
        }

        // GET: Reptiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            

            var reptile = await _context.Reptiles.FindAsync(id);

          

            if (reptile == null)
            {
                return NotFound();
            }
            return View(reptile);
        }

        // POST: Reptiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("ReptileId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed, ApplicationUserId")] Reptile reptile, IFormFile Image)
        {

            
            if (id != reptile.ReptileId)
            {
                return NotFound();
            }


           

            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    if (Image.Length > 0)

                    //Convert Image to byte and save to database

                    {

                        byte[] p1 = null;
                        using (var fs1 = Image.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        reptile.Image = p1;

                    }
                }
                
               

                try
                {

                    
                    _context.Update(reptile);
                    await _context.SaveChangesAsync();

                 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReptileExists(reptile.ReptileId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reptile);
        }

        // GET: Reptiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reptile = await _context.Reptiles
                .FirstOrDefaultAsync(m => m.ReptileId == id);
            if (reptile == null)
            {
                return NotFound();
            }

            return View(reptile);
        }

        // POST: Reptiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reptile = await _context.Reptiles.FindAsync(id);
            _context.Reptiles.Remove(reptile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReptileExists(int id)
        {
            return _context.Reptiles.Any(e => e.ReptileId == id);
        }
    }
}
