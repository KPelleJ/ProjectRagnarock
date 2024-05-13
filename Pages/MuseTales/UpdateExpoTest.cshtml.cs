using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Pages.MuseTales
{
    public class UpdateExpoTestModel : PageModel
    {

        [BindProperty]
        public Expo Expo { get; set; }
        private IExpoRepository _expoRepository { get; set; }
        public List<Expo> AllExpos;

        public UpdateExpoTestModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            Expo = new Expo();
            AllExpos = _expoRepository.GetAll();
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

            _expoRepository.UpdateExpo(Expo);
            return RedirectToPage("/MuseTales/ExpoList");
        }
    }
}
