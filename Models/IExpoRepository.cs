namespace ProjectRagnarock.Models
{
    public interface IExpoRepository
    {
        //Interfacet der bliver brugt til RagnarockJsonRepository.cs
        public string BusinessName { get; }
        public string LogoImagePath { get; }
        public string BusinessDescription { get; }
        public List<Expo> Expos { get; }

        public void ExpoId();
        public List<Expo> GetAll();
        public void CreateExpo(Expo expo);
        public void UpdateExpo(Expo expo);
        public void RemoveExpo(int id);

    }
}
