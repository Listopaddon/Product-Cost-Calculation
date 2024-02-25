using DataService;
using Newtonsoft.Json;

namespace UnitTestForBS.SubObjects
{
    public class SubDataService<T> : IDS<T>
    {
        private const string filePath = "ProductListForTests.json";

        public List<T> LoadData()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
            }
            return new List<T>();
        }

        public void SaveData(List<T> users)
        {
            string jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
    }

}
