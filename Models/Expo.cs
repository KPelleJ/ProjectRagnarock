using NAudio.Wave;

namespace ProjectRagnarock.Models
{
    public class Expo
    {
        private string _name;
        private AudioFileReader _audioFile;
        private string _description;
        private string _soundFilePath;
        private string _picturePath;
        private int _id;
        private static int _idCounter = 1;

        public Expo(string name, string description,string soundFilePath, string picturePath, AudioFileReader audioFile)
        {
            _audioFile = audioFile;
            _name = name;
            _description = description;
            _soundFilePath = soundFilePath;
            _picturePath = picturePath;
            _id = _idCounter++;
        }

        public string Name 
        { get { return _name; } }

        public string Description 
        { get { return _description; } }

        public int Id 
        { get { return _id; } }

        public string SoundFilePath
        { get { return _soundFilePath; } }

        public string PicturePath
        { get { return _picturePath; } }
    }
}
