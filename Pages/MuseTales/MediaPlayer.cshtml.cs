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
            _expoId = id;
            return Page();
        }
        public void OnPost(int id)
        {
            _expoId = id;
            _expoRepository.PlaySound(@"C:\Users\nqvis\OneDrive\Skrivebord\ProRagnarock\wwwroot\Sound\Voicy_gnome sound.mp3");
        }
    }
}
