using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

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
                ModelState.AddModelError(string.Empty, "Mangler brugernavn eller adgangskode");
                return Page();
            }
            if (admin.Validation(admin.Username, admin.Password))
            {
                Admin a = new Admin();
                HttpContext.Session.SetString("User", a.Username + a.Password);
                return RedirectToPage("MuseTales/AdminDash");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ugyldigt brugernavn eller adgangskode");
                return Page();
            }
            }
        }
    }


