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
        private readonly IMediaPlayer _mediaPlayer;

        public MediaPlayerModel(IExpoRepository expoRepository, IMediaPlayer mediaPlayer)
        {
            _expoRepository = expoRepository;
            AllExpos = expoRepository.GetAll();
            _mediaPlayer = mediaPlayer;
        }

        public int ExpoId
        {  get { return _expoId; } }
        public void OnGet(int id)
        {
            _expoId = id;
            //return Page();
        }
        public void OnPostPlay(int id)
        {
            _expoId = id;
            _mediaPlayer.PlaySound(_expoId);
        }
    }
}
