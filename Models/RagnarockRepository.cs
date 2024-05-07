using NAudio.Wave;

namespace ProjectRagnarock.Models
{
    public class RagnarockRepository:IExpoRepository
    {
        private string _businessName;
        private string _logoImagePath;
        private string _businessDescription;
        private List<Expo> _expos;
        //AudioFileReader audioFile;
        //WaveOutEvent outputDevice;
        
        public RagnarockRepository() 
        {
            //audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\ProRagnarock\wwwroot\Sound\Voicy_gnome sound.mp3");
            //outputDevice = new WaveOutEvent();
            _expos = new List<Expo>();
            _expos.Add(new Expo("60'ernes syrede Rock", "Take me oooooooooooooooooooooooooooonnnnnnnnnnnnnnnnn, take on me.", @"wwwroot/Sound/Voicy_gnome sound.mp3", "PsykRock.png"));
            _expos.Add(new Expo("Metal igennem tiderne", "Der var engang en svensk mand ved navn Lars, der elskede at eksperimentere i køkkenet. " +
                "Han prøvede alt fra traditionelle svenske retter til mere eksotiske opskrifter fra fjerne lande. Men der var én ting, han aldrig kunne mestre - at lave medisterpølse." +
                "\r\n\r\nLars havde hørt så meget om den danske delikatesse, medisterpølse, og besluttede sig for at prøve at lave det selv. " +
                "Han fandt en opskrift på nettet, købte alle ingredienserne og gik i gang med entusiasme.\r\n\r\nMen hver gang Lars forsøgte sig med medisterpølsen, endte resultatet altid forkert. " +
                "Enten blev pølsen for tør og kedelig, eller også blev den alt for fedtet og smattede. Uanset hvor meget han prøvede, kunne Lars ikke ramme den helt rigtige konsistens og smag." +
                "\r\n\r\nHan brugte timer i køkkenet, æltede farsen, tilsatte krydderier og formede pølserne med omhu, men intet hjalp. Til sidst gav Lars op. " +
                "Han erkendte, at medisterpølsen simpelthen var en kunst, han ikke kunne mestre.\r\n\r\nMen i stedet for at lade sig slå ud, besluttede Lars sig for at støtte de lokale delikatessebutikker og købe sin medisterpølse derfra fremover. " +
                "Selvom han aldrig blev en mesterkok inden for medisterpølsen, kunne han stadig nyde den på sin tallerken, perfekt tilberedt af dem, der virkelig forstod kunsten.", @"wwwroot\Sound\naked.wav", "Metal.png"));
            _expos.Add(new Expo("Kinesisk musik", "Dette er lyde fra det smukke og lyriske Kina", @"wwwroot/Sound/Voicy_Chinese food.mp3", "PsykRock.png"));

            _businessName = "Ragnarock";
            _logoImagePath = "RagnarockLogo.png";
            _businessDescription = "Her er en dybdegående beskrivelse af museet Ragnarock i Roskilde. Wow det er meget spændende";
        }

        public string BusinessName
        { get { return _businessName; } }
        public string LogoImagePath
        {  get { return _logoImagePath; } }
        public string BusinessDescription
        { get { return _businessDescription; } }
        public List<Expo> Expos
        {  get { return _expos; } }

        public void CreateExpo(string name, string description, string soundPath, string imagePath)
        {
            
        }
        public List<Expo> GetAll()
        {
            return _expos;
        }

        public void RemoveExpo(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpo(int id)
        {
            throw new NotImplementedException();
        }
        public void PlaySound(int id)
        {
            foreach (Expo expo in _expos) 
            { if(id == expo.Id) { 
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
    }
}
