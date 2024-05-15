using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using QRCoder;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;


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
        { get { return _expoRepository; } }

        public string QRCodeImage { get; private set; }

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
        
  

