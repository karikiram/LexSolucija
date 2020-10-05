using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tommy_Skrak_LexDo.Areas.Identity.Data;
using Tommy_Skrak_LexDo.Data;
using Tommy_Skrak_LexDo.Models;

namespace Tommy_Skrak_LexDo.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private AuthDBContext _context;

        public IndexModel(
            AuthDBContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            // First name Last Name Setup ( ne radi)
            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            [Display(Name = "First Name")]
            public string LastName { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            // First name Last Name Setup (ne radi)
            var userName = await _userManager.GetUserNameAsync(user);
            var firstName = user.FirstName;
            var lastName = user.LastName;

            Username = userName;

            Input = new InputModel
            {
                FirstName = firstName,
                LastName = lastName
        };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var firstName = user.FirstName;
            var lastName = user.LastName;

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
