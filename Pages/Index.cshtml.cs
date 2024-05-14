using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ProjectRagnarock.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public CodeCred codes { get; set; }

        public CustomerLogin login { get; set; }

        public IndexModel()
        {
            login = new CustomerLogin();
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (login.Validation(codes.Pincode) == true)
            {
                return RedirectToPage("/MuseTales/ExpoList");
            }
            
            
            ModelState.AddModelError(string.Empty, "Forkert kode");
            return Page();
        }
    }
    
}
