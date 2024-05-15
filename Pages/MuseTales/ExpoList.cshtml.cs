using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;


namespace ProjectRagnarock.Pages.MuseTales
{
    public class ExpoListModel : PageModel
    {
        public List<Expo> AllExpos;
        private readonly IExpoRepository _expoRepository;

        public ExpoListModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            AllExpos = expoRepository.GetAll();
        }

        public IExpoRepository ExpoRepository
        {  get { return _expoRepository; } }


        public IActionResult OnGet()
        {
            if(HttpContext.Session.GetString("User") != null || HttpContext.Session.GetString("Admin") != null)
            {
                _expoRepository.ExpoId();
                return Page();
            }
            else
            {
                return RedirectToPage("/Index");
            }
        }

    }
}
