using Newtonsoft.Json;
using ProjectRagnarock.Models;

namespace ProjectRagnarock.Json
{
    public class JsonWriter
    {
        public static void WriteToJson(List<Expo> expos, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(expos, Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
