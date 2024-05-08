namespace ProjectRagnarock.Models
{
    public interface IMediaPlayer
    {
        public List<Expo> Expos { get; }
        public void PlaySound(int id);
        public void StopSound();
        public void PauseSound();
        public void ResumeSound();
    }
}
