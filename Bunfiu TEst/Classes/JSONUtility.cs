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
    public static class JSONUtility
    {
        public static UserControls.UC_Customers UC_Customers
        {
            get => default;
            set
            {
            }
        }

        public static Bunfiu_TEst.UserControls.UC_Inventory UC_Inventory
        {
            get => default;
            set
            {
            }
        }

        public static Bunfiu_TEst.UserControls.UC_Orders UC_Orders
        {
            get => default;
            set
            {
            }
        }

        public static List<T> DeserializeListFromJson<T>(string json) //Deseralising av datan från json
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            return new List<T>();
        }
        public static string SerializeListToJson<T>(List<T> list) //Serialize data inann det läggs till i json filerna
        {
            return JsonSerializer.Serialize(list);
        }
        public static List<T> GetData<T>(string path, List<T> list) //Hämtar all data från en json fil
        {
            string jsonData = File.ReadAllText(path);
            return new List<T>(DeserializeListFromJson<T>(jsonData));
        }

        public static void UpdateJsonFile<T>(string path, List<T> list) //Skriver över all data med den nya
        {
            string jsonData = SerializeListToJson(list);
            File.WriteAllText(path, jsonData);
        }


    }

}

