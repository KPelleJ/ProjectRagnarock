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
        public Credential credential { get; set; }

        [BindProperty]
        public CodeCred codes { get; set; }

        public CustomerLogin login { get; set; }

        List<Credential> credentials = new List<Credential>() {
            new Credential("1111"),
            new Credential("2222"),
            new Credential("3333"),
            new Credential("5656")
        };
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
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            
            if (login.Validation(codes.pincode) == true)
            {
                return RedirectToPage("/MuseTales/ExpoList");
            }
            
            
            ModelState.AddModelError(string.Empty, "Forkert kode");
            return Page();
        }
    }
    public class Credential
    {
        public Credential()
        {

        }
        public Credential(string pinCode)
        {
            PinCode = pinCode;
        }

        [Required]
        [StringLength(4)]
        [DataType(DataType.Password)]
        [Display(Name = "Pincode")]
        public string PinCode { get; set; }
        public string Name { get; set; }
    }
}
