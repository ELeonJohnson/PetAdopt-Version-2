using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetAdopt;
using PetAdopt.Data;
using PetAdopt.Models;

namespace PetAdopt.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;



        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ApplicationDbContext context
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _context = context;
        }

        
        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public string Number { get; set; }

        public class InputModel
        {
            public int UserId { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            public string City { get; set; }

            public string State { get; set; }

            public string Number { get; set; }

            [Display(Name = "Image")]
            public byte[] Image { get; set; }

            public List<Reptile> Reptile { get; set; }
            public List<Dog> Dog { get; set; }
            public List<Cat> Cat { get; set; }


        }
        
        public async Task<IActionResult> OnGetAsync(int? id, ApplicationUser user)
        {
            user = await _context.ApplicationUsers
                .FirstOrDefaultAsync(m => m.Id == id);

            

            var reptile = _context.ApplicationUsers.Include(r => r.Reptiles).Where(r => r.Id == id).FirstOrDefault();
            var dog = _context.ApplicationUsers.Include(r => r.Dogs).Where(r => r.Id == id).FirstOrDefault();
            var cat = _context.ApplicationUsers.Include(r => r.Cats).Where(r => r.Id == id).FirstOrDefault();



            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);


            Input = new InputModel
            {
                UserId = user.Id,
                Email = email,
                PhoneNumber = phoneNumber,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                State = user.State,
                City = user.City,
                Number = user.Number,
                Image = user.Image,
                Reptile = user.Reptiles,
                Dog = user.Dogs,
                Cat = user.Cats
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);

            return Page();
        }
    }
}
