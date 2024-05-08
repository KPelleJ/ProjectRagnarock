namespace ProjectRagnarock.Models
{
    public interface IExpoRepository
    {
        public string BusinessName { get; }
        public string LogoImagePath { get; }
        public string BusinessDescription { get; }
        public List<Expo> Expos { get; }
        
        public List<Expo> GetAll();
        public void CreateExpo(string name, string description, string soundPath, string imagePath);
        public void UpdateExpo(int id);
        public void RemoveExpo(int id);

    }
}
