using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAudio.Wave;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Pages.MuseTales
{
    public class MediaPlayerModel : PageModel
    {
        private int _expoId;
        public List<Expo> AllExpos;
        private readonly IExpoRepository _expoRepository;

        public MediaPlayerModel(IExpoRepository expoRepository)
        {
            _expoRepository = expoRepository;
            AllExpos = expoRepository.GetAll();
        }

        public int ExpoId
        {  get { return _expoId; } }
        public IActionResult OnGet(int id)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                _expoId = id;
                return Page();
            }
            else
            {
                return RedirectToPage("/Index");
            }
        }

        public IActionResult OnPostReturn() 
        {
            return RedirectToPage("/MuseTales/ExpoList");
        }
    }
}
