using NAudio.Wave;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRagnarock.Models
{
    public class Expo
    {
        public Expo()
        {
            
        }

        [Required]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Name {  get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Description {  get; set; }

        [Required]
        public string SoundFilePath {  get; set; }

        [Required]
        public string PicturePath {  get; set; }

        public int Id { get; set; }

    }
}
