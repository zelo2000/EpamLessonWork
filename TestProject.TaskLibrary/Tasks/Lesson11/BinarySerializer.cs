using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class BinarySerializer : ISerializer
    {
        public CarStorage DeSerialize(string path)
        {
            CarStorage cs;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                cs = (CarStorage)bf.Deserialize(fs);
            }
            return cs;
        }

        public string Serialize(CarStorage carStorage, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, carStorage);
            }
            return File.ReadAllText(path);
        }
    }
}
