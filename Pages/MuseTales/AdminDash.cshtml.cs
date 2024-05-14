using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Pages.MuseTales
{
    public class AdminDashModel : PageModel
    {
        [BindProperty]
        public Expo Expo { get; set; }
        private IExpoRepository _expoRepository { get; set; }
        public List<Expo> AllExpos;

        public AdminDashModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            Expo = new Expo(); ;
            AllExpos = _expoRepository.GetAll();
        }
        
        public IActionResult OnGet()
        {
            _expoRepository.ExpoId();
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            _expoRepository.RemoveExpo(Expo.Id);
            return RedirectToPage("/MuseTales/AdminDash");
        }

        public IActionResult OnPostCreate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _expoRepository.CreateExpo(Expo);
            return RedirectToPage("/MuseTales/AdminDash");
        }

        public IActionResult OnPostUpdate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _expoRepository.UpdateExpo(Expo);
            return RedirectToPage("/MuseTales/AdminDash");
            
        }
    }
}
