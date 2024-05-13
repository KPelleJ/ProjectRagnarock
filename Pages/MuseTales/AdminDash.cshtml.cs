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
            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            _expoRepository.RemoveExpo(id);
            return RedirectToPage("/MuseTales/ExpoList");
        }

        public IActionResult OnPostCreate()
        {
            return RedirectToPage("/MuseTales/ExpoList");
        }

        public IActionResult OnPostUpdate()
        {
            return RedirectToPage("/MuseTales/ExpoList");
        }
    }
}
