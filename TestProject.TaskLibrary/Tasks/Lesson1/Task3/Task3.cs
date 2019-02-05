using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task3 : IRunnable
    {
        public void Run(ILog loger)
        {
            //Circle
            Circle crl = new Circle();
            loger.Write("Length: " + crl.Length(3) + "\n");
            loger.Write("Square: " + crl.Square(3) + "\n");
        }
    }
}
