using ProjectRagnarock.Json;
using System.Diagnostics;
namespace ProjectRagnarock.Models
{
    public class RagnarockJsonRepository : IExpoRepository
    {
        //JsonFilePath er stien hvor vores json fil ligger
        string JsonFilePath = @"C:\Project Ragnarock\Data\json.json";
        private string _businessName;
        private string _logoImagePath;
        private string _businessDescription;
        private List<Expo> _expos;
        public RagnarockJsonRepository()
        {
            //Vi har valgt at bruge Json som en database, og her sender vi hele listen med i construktøren
            _expos = JsonReader.ReadJson(JsonFilePath);
        }

        public string BusinessName
        { get { return _businessName; } }
        public string LogoImagePath
        { get { return _logoImagePath; } }
        public string BusinessDescription
        { get { return _businessDescription; } }
        public List<Expo> Expos
        { get { return _expos; } }
        public void CreateExpo(Expo expo)
        {
            _expos.Add(expo);
            JsonWriter.WriteToJson(_expos, JsonFilePath);
        }
        //Vi tilføjer et Id til hver af vores expos, for at sørge for vi altid har fat i det rigtige expo
        public void ExpoId()
        {
            int counter = 1;
            foreach (Expo expo in _expos)
            {
                expo.Id = counter;
                counter++;
            }
        }
        public List<Expo> GetAll()
        {
            return _expos;
        }
        public void RemoveExpo(int id)
        {
            foreach (Expo expo in _expos)
            {
                if (expo.Id == id)
                {
                    _expos.Remove(expo);
                    break;
                }
            }
            JsonWriter.WriteToJson(_expos, JsonFilePath);
        }
        public void UpdateExpo(Expo expo)
        {
            foreach (Expo ex in _expos)
            {
                if (ex.Id == expo.Id)
                {
                    Debug.WriteLine("found");
                    ex.Name = expo.Name;
                    ex.Description = expo.Description;
                    ex.PicturePath = expo.PicturePath;
                    ex.SoundFilePath = expo.SoundFilePath;
                    JsonWriter.WriteToJson(_expos, JsonFilePath);
                }
            }
        }
    }
}
