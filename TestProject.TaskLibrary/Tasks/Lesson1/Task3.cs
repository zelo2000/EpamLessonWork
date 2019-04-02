using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            //Circle
            Circle crl = new Circle();
            Logger.Write($"Length: {crl.GetLength(3)}\n");
            Logger.Write($"Square: {crl.GetSquare(3)}\n");
        }
    }
}
