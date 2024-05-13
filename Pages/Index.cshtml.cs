using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ProjectRagnarock.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; }

        List<Credential> credentials = new List<Credential>() {
            new Credential("1111"),
            new Credential("2222"),
            new Credential("3333"),
            new Credential("5656")
        };
        public IndexModel()
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
                return Page();
            }
            foreach (Credential cred in credentials)
            {
                if (credential.PinCode == cred.PinCode)
                {
                    return RedirectToPage("/MuseTales/ExpoList");
                }
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

    }
}
