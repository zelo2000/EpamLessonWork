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
        public ConsoleLogger()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
        }

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
