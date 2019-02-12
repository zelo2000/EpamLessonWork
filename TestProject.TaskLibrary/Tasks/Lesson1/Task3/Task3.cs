using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task3 : IRunnable
    {
        public void Run(ILog logger)
        {
            //Circle
            Circle crl = new Circle();
            logger.Write($"Length: {crl.GetLength(3)}\n");
            logger.Write($"Square: {crl.GetSquare(3)}\n");
        }
    }
}
