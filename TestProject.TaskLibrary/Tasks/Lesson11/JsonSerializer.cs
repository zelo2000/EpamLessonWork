using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class JsonSerializer : ISerializer
    {
        public CarStorage DeSerialize(string path)
        {
            var result = File.ReadAllText(path);
            var cs = JsonConvert.DeserializeObject<List<Car>>(result);
            return new CarStorage(cs);
        }

        public string Serialize(CarStorage carStorage, string path)
        {
            var xs = JsonConvert.SerializeObject(carStorage);
            File.WriteAllText(path, xs);
            return xs;
        }
    }
}
