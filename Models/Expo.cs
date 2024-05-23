using NAudio.Wave;
using System.ComponentModel.DataAnnotations;

namespace ProjectRagnarock.Models
{
    public class Expo
    {
        private string _name;
        private string _description;
        private string _soundFilePath;
        private string _picturePath;
        public int Id { get; set; }

        public Expo(string name, string description,string soundFilePath, string picturePath)
        {
            _name = name;
            _description = description;
            _soundFilePath = soundFilePath;
            _picturePath = picturePath;
        }
        public Expo()
        { 
        }

        public string Name 
        { 
          get { return _name; } 
          set { _name = value; }
        }
        public string Description 
        { 
            get { return _description; }
            set { _description = value; }
        }
        public string SoundFilePath
        { 
            get { return _soundFilePath; } 
            set { _soundFilePath = value; }
        }
        public string PicturePath
        { 
            get { return _picturePath; } 
            set { _picturePath = value; }
        }
    }
}
