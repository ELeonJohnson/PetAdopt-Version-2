using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using PetAdopt;

namespace PetAdopt.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        RoleManager<IdentityRole<int>> _roleManager;


        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
            [Display(Name = "Owner's Image")]
            public byte[] Image { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            [Display(Name ="User Role")]
            public string RoleName { get; set; }


            [Display(Name = "Account's Age")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
            [DataType(DataType.Date)]
            public DateTime CreatedOn { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public string Number { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                RedirectToRoute(new { action = "Index", controller = "Home", area = "" });

            }

            // pass the Role List using ViewData
            ViewData["roles"] = _roleManager.Roles.ToList();
            ReturnUrl = returnUrl;
         
        }

        public async Task<IActionResult> OnPostAsync(IFormFile Image, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

          

            // search role
            var role = _roleManager.FindByIdAsync(Input.RoleName).Result;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {
                    UserName = Input.UserName,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    City = Input.City,
                    State = Input.State,
                    Image = Input.Image,
                    RoleName = Input.RoleName,
                    Number = Input.Number
                };

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
                        user.Image = p1;

                    }
                }
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    // code for adding user to role
                    await _userManager.AddToRoleAsync(user, role.Name);
                    // ends here


                   
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);



                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
