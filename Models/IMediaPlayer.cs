namespace ProjectRagnarock.Models
{
    public interface IMediaPlayer
    {
        public void PlaySound(int id);
        public void StopSound();
        public void PauseSound();
        public void ResumeSound();
    }
}
