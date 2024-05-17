using Newtonsoft.Json;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Json
{
    public class JsonReader
    {
        public static List<Expo> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Expo>>(jsonString);
        }
    }
}
