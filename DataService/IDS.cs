using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public interface IDS<T>
    {
        public List<T> LoadData();

        public void SaveData(List<T> users);
    }
}
