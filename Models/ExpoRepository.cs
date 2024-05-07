using NAudio.Wave;
using System.Media;

namespace ProjectRagnarock.Models
{
    public class ExpoRepository:IExpoRepository
    {
        private string _businessName;
        private string _logoImagePath;
        private List<Expo> expos;

        public ExpoRepository()
        {
            expos = new List<Expo>();
            wave = new WaveOutEvent();
            expos.Add(new Expo("60'ernes syrede Rock", "Take me oooooooooooooooooooooooooooonnnnnnnnnnnnnnnnn, take on me.", "Forhelvete", "PsykRock.png"));
            expos.Add(new Expo("Metal igennem tiderne", "Der var engang en svensk mand ved navn Lars, der elskede at eksperimentere i køkkenet. Han prøvede alt fra traditionelle svenske retter til mere eksotiske opskrifter fra fjerne lande. Men der var én ting, han aldrig kunne mestre - at lave medisterpølse.\r\n\r\nLars havde hørt så meget om den danske delikatesse, medisterpølse, og besluttede sig for at prøve at lave det selv. Han fandt en opskrift på nettet, købte alle ingredienserne og gik i gang med entusiasme.\r\n\r\nMen hver gang Lars forsøgte sig med medisterpølsen, endte resultatet altid forkert. Enten blev pølsen for tør og kedelig, eller også blev den alt for fedtet og smattede. Uanset hvor meget han prøvede, kunne Lars ikke ramme den helt rigtige konsistens og smag.\r\n\r\nHan brugte timer i køkkenet, æltede farsen, tilsatte krydderier og formede pølserne med omhu, men intet hjalp. Til sidst gav Lars op. Han erkendte, at medisterpølsen simpelthen var en kunst, han ikke kunne mestre.\r\n\r\nMen i stedet for at lade sig slå ud, besluttede Lars sig for at støtte de lokale delikatessebutikker og købe sin medisterpølse derfra fremover. Selvom han aldrig blev en mesterkok inden for medisterpølsen, kunne han stadig nyde den på sin tallerken, perfekt tilberedt af dem, der virkelig forstod kunsten.", "forhelvet", "Metal.png"));

            _businessName = "Ragnarock";
            _logoImagePath = "RagnarockLogo.png";
        }

        public string BusinessName
        { get { return _businessName; } }
        public string LogoImagePath
        {  get { return _logoImagePath; } }

        public string BusinessDescription => throw new NotImplementedException();

        public List<Expo> Expos => throw new NotImplementedException();

        public void CreateExpo(string name, string description, string soundPath, string imagePath)
        {
            
        }

        public List<Expo> GetAll()
        {
            return expos;
        }

        public void RemoveExpo(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpo(int id)
        {
            throw new NotImplementedException();
        }
        public void PlaySound()
        {
            
            if (wave.PlaybackState != PlaybackState.Playing)
            {
                wave.Init(audioFile);
                wave.Play();
                wave.PlaybackStopped += OutputDevice_PlaybackStopped;
            }
        }
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Playback stopped, clean up resources
            wave.Dispose();
            wave.Dispose();

            audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\ProRagnarock\wwwroot\Sound\Voicy_gnome sound.mp3");
            wave = new WaveOutEvent();
        }

        public void PauseSound()
        {
            throw new NotImplementedException();
        }

        public void StopSound()
        {
            throw new NotImplementedException();
        }

        public void ResumeSound()
        {
            throw new NotImplementedException();
        }
    }
}
