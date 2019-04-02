using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class XMLSerializer : ISerializer
    {
        public CarStorage DeSerialize(string path)
        {
            CarStorage cs;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var xs = new XmlSerializer(typeof(CarStorage));
                cs = (CarStorage)xs.Deserialize(fs);
            }
            return cs;
        }

        public string Serialize(CarStorage carStorage, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                var xs = new XmlSerializer(typeof(CarStorage));
                xs.Serialize(fs, carStorage);
            }
            return File.ReadAllText(path);
        }
    }
}
