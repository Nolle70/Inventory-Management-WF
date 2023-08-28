using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Inventory_App
{
    public static class JSONUtility //Här sker all konvertering till och från json filerna
    {

        public static List<T> DeserializeListFromJson<T>(string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                return JsonSerializer.Deserialize<List<T>>(json);
            }

            return new List<T>();
        }
        public static string SerializeListToJson<T>(List<T> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public static List<T> GetData<T>(string path, List<T> list)
        {
            string jsonData = File.ReadAllText(path);
            return new List<T>(DeserializeListFromJson<T>(jsonData));
        }

        public static void UpdateJsonFile<T>(string path, List<T> list)
        {
            string jsonData = SerializeListToJson(list);
            File.WriteAllText(path, jsonData);
        }


    }

}

