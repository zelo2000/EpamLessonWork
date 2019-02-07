using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.Common.Core.Displayers
{
    /// <summary>
    /// Сlass for console input/output.
    /// </summary>
    public class ConsoleLogger : ILog
    {
        public ConsoleLogger() { }

        public string Read()
        {
            return Console.ReadLine();
        }

        public void ReadKey()
        {
            Console.ReadKey();
        }

        public void Write(string log)
        {
            Console.Write(log);
        }
    }
}
