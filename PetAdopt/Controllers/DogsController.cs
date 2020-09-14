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
    public class DogsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DogsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Dogs
        public async Task<IActionResult> Index(string searchString, string dogGender,
            string dogAge, string dogType, string dogSize, string dogColor)
        {
            IQueryable<string> genderQuery = from g in _context.Dogs
                                             orderby g.Gender
                                             select g.Gender;
            IQueryable<string> ageQuery = from a in _context.Dogs
                                          orderby a.Age
                                          select a.Age;
            IQueryable<string> typeQuery = from t in _context.Dogs
                                           orderby t.Type
                                           select t.Type;
            IQueryable<string> sizeQuery = from s in _context.Dogs
                                           orderby s.Size
                                           select s.Size;
            IQueryable<string> colorQuery = from c in _context.Dogs
                                            orderby c.Color
                                            select c.Color;




            var dogs = from d in _context.Dogs
                           select d;

            if (!string.IsNullOrEmpty(searchString))
            {
                dogs = dogs.Where(r => r.Name.Contains(searchString));

            }
            else if (!string.IsNullOrEmpty(dogGender))
            {
                dogs = dogs.Where(g => g.Gender == dogGender);

            }
            else if (!string.IsNullOrEmpty(dogAge))
            {
                dogs = dogs.Where(a => a.Age == dogAge);

            }
            else if (!string.IsNullOrEmpty(dogType))
            {
                dogs = dogs.Where(t => t.Type == dogType);
            }
            else if (!string.IsNullOrEmpty(dogSize))
            {
                dogs = dogs.Where(s => s.Size == dogSize);
            }
            else if (!string.IsNullOrEmpty(dogColor))
            {
                dogs = dogs.Where(c => c.Color == dogColor);
            }




            var dogVM = new DogViewModel();
            dogVM.genders = new SelectList(await genderQuery.Distinct().ToListAsync());
            dogVM.ages = new SelectList(await ageQuery.Distinct().ToListAsync());
            dogVM.types = new SelectList(await typeQuery.Distinct().ToListAsync());
            dogVM.sizes = new SelectList(await sizeQuery.Distinct().ToListAsync());
            dogVM.colors = new SelectList(await colorQuery.Distinct().ToListAsync());


            dogVM.dogs = await dogs.ToListAsync();

            return View(dogVM);
        }

        // GET: Dogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.DogId == id);

            var user = _context.Dogs.Include(r => r.ApplicationUser).Where(r => r.DogId == id).FirstOrDefault();


            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }


        [Authorize(Roles = "Admin, Owner")]
        // GET: Dogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DogId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed")] Dog dog, IFormFile Image)
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
                        dog.Image = p1;

                    }
                }

                var applicationUserId = _userManager.GetUserId(HttpContext.User);

                dog.ApplicationUserId = Convert.ToInt32(applicationUserId);

                _context.Add(dog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dog);
        }

        // GET: Dogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }
            return View(dog);
        }

        // POST: Dogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DogId,Name,Age,Image,FoodReq,HabitatReq,Gender,Type,Size,Color,RecentCheckup,Trained,Neutered,Declawed")] Dog dog)
        {
            if (id != dog.DogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogExists(dog.DogId))
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
            return View(dog);
        }

        // GET: Dogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.DogId == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: Dogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            _context.Dogs.Remove(dog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogExists(int id)
        {
            return _context.Dogs.Any(e => e.DogId == id);
        }
    }
}
