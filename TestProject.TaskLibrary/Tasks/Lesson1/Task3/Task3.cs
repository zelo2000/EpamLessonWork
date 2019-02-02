using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Circle
            Circle crl = new Circle();
            Console.WriteLine("Length: " + crl.Length(3));
            Console.WriteLine("Square: " + crl.Square(3));
        }
    }
}
