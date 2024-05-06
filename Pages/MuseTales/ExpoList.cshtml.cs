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


        public IActionResult OnGet()
        {
           return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
