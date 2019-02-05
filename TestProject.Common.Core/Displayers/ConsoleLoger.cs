using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.Common.Core.Displayers
{
    public class ConsoleLoger : ILog
    {
        public ConsoleLoger() { }

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
