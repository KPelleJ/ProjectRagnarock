using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Pages
{
    public class AdminLoginModel : PageModel
    {
        [BindProperty]
        public AdminLogin admin {  get; set; }
        public AdminLoginModel()
        {

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Mangler username og password");
                return Page();
            }
            if (admin.Validation(admin.Username, admin.Password))
            {
                return RedirectToPage("MuseTales/AdminDash");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ugyldigt username og password");
                return Page();
            }
            }
        }
    }


