using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.Common.Core
{
    public class Logger
    {
        private static ILog _console;

        private Logger(ILog Logger)
        {
            _console = Logger;
        }

        public static void SetLogger(ILog Logger)
        {
            if (_console == null)
            {
                _console = Logger;
            }
        }

        public static void Write(string str)
        {
            _console.Write(str);
        }

        public static string Read()
        {
            return _console.Read();
        }
    }
}
