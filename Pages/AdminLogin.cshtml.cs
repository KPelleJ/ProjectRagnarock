using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Pages
{
    public class AdminLoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Username is required")]
        public string _username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        public string _password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Validation(_username, _password))
            {
                return RedirectToPage("MuseTales/Expolist");
            }
            else
            {
                return Page();
            }
        }

        private bool Validation(string _username, string _password)
        {
            if (_username == "admin" && _password == "1234")
            {
                return true;
            }
            else
            {
                ModelState.AddModelError("_password", "Invalid username or password");
                return false;
            }
        }
    }
}

