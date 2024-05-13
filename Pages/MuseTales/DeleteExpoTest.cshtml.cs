using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Pages.MuseTales
{
    public class DeleteExpoTestModel : PageModel
    {
        [BindProperty]
        public Expo Expo { get; set; }
        private IExpoRepository _expoRepository { get; set; }
        public List<Expo> AllExpos;

        public DeleteExpoTestModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            Expo = new Expo(); ;
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

            _expoRepository.RemoveExpo(Expo.Id);
            return RedirectToPage("/MuseTales/ExpoList");
        }

        public IActionResult OnPostDelete(int id)
        {
            

            _expoRepository.RemoveExpo(id);
            return RedirectToPage("/MuseTales/ExpoList");
        }
    }
}
