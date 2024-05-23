using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRagnarock.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;


namespace ProjectRagnarock.Pages.MuseTales
{
    public class AdminDashModel : PageModel
    {
        [BindProperty]
        public Expo Expo { get; set; }
        private IExpoRepository _expoRepository { get; set; }
        public List<Expo> AllExpos;
        private IWebHostEnvironment Environment;
        public AdminDashModel(IExpoRepository expoRepository, IWebHostEnvironment environment)
        {
            _expoRepository = expoRepository;
            Environment = environment;
            //Expo = new Expo(); ;
            AllExpos = _expoRepository.GetAll();
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Admin") != null)
            {
                _expoRepository.ExpoId();
                return Page();
            }
            else
            {
                return RedirectToPage("/AdminLogin");
            }
        }

        public void UploadPic(List<IFormFile> PicturePath)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in PicturePath)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                    Expo.PicturePath = fileName;
                }
            }

        }

        public void UploadSound(List<IFormFile> SoundFilePath)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Sound");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in SoundFilePath)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                    Expo.SoundFilePath = fileName;
                }
            }
        }

        public IActionResult OnPostDelete()
        {
            _expoRepository.RemoveExpo(Expo.Id);
            return RedirectToPage("/MuseTales/AdminDash");
        }

        public IActionResult OnPostCreate(List<IFormFile> PicturePath, List<IFormFile> SoundFilePath)
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            UploadPic(PicturePath);
            UploadSound(SoundFilePath);

            _expoRepository.CreateExpo(Expo);
            return RedirectToPage("/MuseTales/AdminDash");
        }

        public IActionResult OnPostUpdate(List<IFormFile> PicturePath, List<IFormFile> SoundFilePath)
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            UploadPic(PicturePath);
            UploadSound(SoundFilePath);

            _expoRepository.UpdateExpo(Expo);
            return RedirectToPage("/MuseTales/AdminDash");

        }
    }
}
