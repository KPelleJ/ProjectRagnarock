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
            expos.Add(new Expo("60'ernes syrede Rock", "entotre", "forhelvet", "kekw"));
            expos.Add(new Expo("Metal igennem tiderne", "entotre", "forhelvet", "kekw"));

            _businessName = "Ragnarock";
            _logoImagePath = "RagnarockLogo.png";
        }

        public string BusinessName
        { get { return _businessName; } }
        public string LogoImagePath
        {  get { return _logoImagePath; } }

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
    }
}
