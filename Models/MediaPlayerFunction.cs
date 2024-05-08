using NAudio.Wave;

namespace ProjectRagnarock.Models
{
    public class MediaPlayerFunction : IMediaPlayer
    {
        public Expo expo;
        List<Expo> expoList;
        private readonly IMediaPlayer mediaPlayer;
        public MediaPlayerFunction()
        {
            
        }
        public void PlaySound(int id)
        {
            foreach (Expo expo in expoList)
            {
                if (id == expo.Id)
                {
                    if (expo.OutPutDevice.PlaybackState != PlaybackState.Playing)
                    {
                        expo.OutPutDevice.Init(expo.AudioFile);
                        expo.OutPutDevice.Play();
                    }
                    else if (expo.OutPutDevice.PlaybackState == PlaybackState.Stopped)
                    {
                        expo.OutPutDevice.Init(expo.AudioFile);
                        expo.OutPutDevice.Play();

                    }
                }
            }
        }
        public void PauseSound()
        {
            throw new NotImplementedException();
        }
        public void ResumeSound()
        {
            throw new NotImplementedException();
        }

        public void StopSound()
        {
            throw new NotImplementedException();
        }
    }
}
