using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace AutomationFramework
{
    public static class JsonExtension
    {
        public static T ReadJson<T>(string path)
        {
            var jsonOUTPUT = File.ReadAllText(path);
            var a = JsonConvert.DeserializeObject<dynamic>(jsonOUTPUT);
            return JsonConvert.DeserializeObject<T>(jsonOUTPUT);
        }

        public static Dictionary<string, string> DictionaryReadJson(string path)
        {
            var jsonOUTPUT = File.ReadAllText(path);
            JObject jsonObj = JObject.Parse(jsonOUTPUT);
            return jsonObj.ToObject<Dictionary<string, string>>();
        }
    }
}
