using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    interface ISerializer
    {
        string Serialize(CarStorage carStorage, string path);
        CarStorage DeSerialize(string path);
    }
}
