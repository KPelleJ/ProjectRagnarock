using NAudio.Wave;

namespace ProjectRagnarock.Models
{
    public class Expo
    {
        private string _name;
        private string _description;
        private string _soundFilePath;
        private string _picturePath;
        private int _id;
        private static int _idCounter = 1;
        AudioFileReader _audioFile;
        WaveOutEvent _outPutDevice;

        public Expo(string name, string description,string soundFilePath, string picturePath)
        {
            _name = name;
            _description = description;
            _soundFilePath = soundFilePath;
            _picturePath = picturePath;
            _id = _idCounter++;
            _audioFile = new AudioFileReader(soundFilePath);
            _outPutDevice = new WaveOutEvent();
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

        public AudioFileReader AudioFile { get => _audioFile; set => _audioFile = value; }
        public WaveOutEvent OutPutDevice { get => _outPutDevice; set => _outPutDevice = value; }
    }
}
