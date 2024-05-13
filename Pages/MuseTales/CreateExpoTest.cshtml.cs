using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using ProjectRagnarock.Pages.MuseTales;

namespace ProjectRagnarock.Pages.MuseTales
{
    public class CreateExpoTestModel : PageModel
    {

        [BindProperty]
        public Expo Expo { get; set; }
        private IExpoRepository _expoRepository { get; set; }
        

        public CreateExpoTestModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            Expo = new Expo();
        }
        public IActionResult OnGet()
        {
            return  Page();
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           _expoRepository.CreateExpo(Expo);
           return RedirectToPage("/MuseTales/ExpoList");
        }
    }
}
