using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Struct.Task2
{
    interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }
        double Perimeter();
    }
}
