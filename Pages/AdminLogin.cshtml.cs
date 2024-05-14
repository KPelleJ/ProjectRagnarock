using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Pages
{
    public class AdminLoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Brugernavn er p�kr�vet")]
        public string _username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Adgangskode er p�kr�vet")]
        public string _password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Validation(_username, _password))
            {
                return RedirectToPage("MuseTales/AdminDash");
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
                ModelState.AddModelError("_password", "Forkert brugernavn eller adgangskode");
                return false;
            }
        }
    }
}

