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
using PetAdopt.ViewModels;

namespace PetAdopt.Controllers
{
    public class CatsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CatsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Cats
        public async Task<IActionResult> Index(string searchString, string catGender,
            string catAge, string catType, string catSize, string catColor)
        {
            IQueryable<string> genderQuery = from g in _context.Cats
                                             orderby g.Gender
                                             select g.Gender;
            IQueryable<string> ageQuery = from a in _context.Cats
                                          orderby a.Age
                                          select a.Age;
            IQueryable<string> typeQuery = from t in _context.Cats
                                           orderby t.Type
                                           select t.Type;
            IQueryable<string> sizeQuery = from s in _context.Cats
                                           orderby s.Size
                                           select s.Size;
            IQueryable<string> colorQuery = from c in _context.Cats
                                            orderby c.Color
                                            select c.Color;




            var cats = from c in _context.Cats
                       select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cats = cats.Where(r => r.Name.Contains(searchString));

            }
            else if (!string.IsNullOrEmpty(catGender))
            {
                cats = cats.Where(g => g.Gender == catGender);

            }
            else if (!string.IsNullOrEmpty(catAge))
            {
                cats = cats.Where(a => a.Age == catAge);

            }
            else if (!string.IsNullOrEmpty(catType))
            {
                cats = cats.Where(t => t.Type == catType);
            }
            else if (!string.IsNullOrEmpty(catSize))
            {
                cats = cats.Where(s => s.Size == catSize);
            }
            else if (!string.IsNullOrEmpty(catColor))
            {
                cats = cats.Where(c => c.Color == catColor);
            }




            var catVM = new CatViewModel();
            catVM.genders = new SelectList(await genderQuery.Distinct().ToListAsync());
            catVM.ages = new SelectList(await ageQuery.Distinct().ToListAsync());
            catVM.types = new SelectList(await typeQuery.Distinct().ToListAsync());
            catVM.sizes = new SelectList(await sizeQuery.Distinct().ToListAsync());
            catVM.colors = new SelectList(await colorQuery.Distinct().ToListAsync());


            catVM.cats = await cats.ToListAsync();

            return View(catVM);
        }

        // GET: Cats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cats
                .FirstOrDefaultAsync(m => m.CatId == id);

            var user = _context.Cats.Include(r => r.ApplicationUser).Where(r => r.CatId == id).FirstOrDefault();

            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }


        [Authorize( Roles = "Admin, Owner")]
        // GET: Cats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed")] Cat cat, IFormFile Image)
        {
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
                        cat.Image = p1;

                    }
                }

                var applicationUserId = _userManager.GetUserId(HttpContext.User);

                cat.ApplicationUserId = Convert.ToInt32(applicationUserId);

                _context.Add(cat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        // GET: Cats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cats.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        // POST: Cats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed")] Cat cat)
        {
            if (id != cat.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatExists(cat.CatId))
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
            return View(cat);
        }

        // GET: Cats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cats
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }

        // POST: Cats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cat = await _context.Cats.FindAsync(id);
            _context.Cats.Remove(cat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatExists(int id)
        {
            return _context.Cats.Any(e => e.CatId == id);
        }
    }
}
