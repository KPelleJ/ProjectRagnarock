namespace ProjectRagnarock.Models
{
    public interface IExpoRepository
    {
        public List<Expo> GetAll();
        public void CreateExpo(string name, string description, string soundPath, string imagePath);
        public void UpdateExpo(int id);
        public void RemoveExpo(int id);

    }
}
