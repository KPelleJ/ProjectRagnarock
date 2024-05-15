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
        public Customer customers { get; set; }

        
        public CustomerLogin login { get; }

        public IndexModel(ICodeRepository codeRepo)
        {
            login = new CustomerLogin(codeRepo);
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
            
            if (login.Validation(customers.Pincode) == true)
            {
                Customer c = new Customer();
                c.Pincode = customers.Pincode;
                HttpContext.Session.SetString("User",c.Pincode);
                return RedirectToPage("/MuseTales/ExpoList");
            }
            ModelState.AddModelError(string.Empty, "Forkert kode");
            return Page();
        }
    }
    
}
