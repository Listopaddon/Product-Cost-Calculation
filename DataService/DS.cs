﻿using Newtonsoft.Json;

namespace DataService
{
    public class DS <T> 
    {
        private const string filePath = "ProductList.json";

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
            string jsonData = JsonConvert.SerializeObject(users,Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
