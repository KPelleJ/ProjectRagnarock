namespace ProjectRagnarock.Models
{
    public interface ICodeRepository
    {
        //Interfacet der bliver brugt til at hente alle koderne vi har tilgængelige til vores pinkode login side.
        public List<string> GetAll();
    }
}
