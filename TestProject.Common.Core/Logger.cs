using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.Common.Core
{
    /// <summary>
    /// Singleton class that provides input/output regardless of where it occurs.
    /// </summary>
    public class Logger
    {
        private static ILog _console;

        private Logger(ILog Logger)
        {
            _console = Logger;
        }

        /// <summary>
        /// Seting a specific logger
        /// </summary>
        /// <param name="Logger">Specific logger</param>
        public static void SetLogger(ILog Logger)
        {
            if (_console == null)
            {
                _console = Logger;
            }
        }

        /// <summary>
        /// Write data
        /// </summary>
        /// <param name="str">Output data</param>
        public static void Write(string str)
        {
            _console.Write(str);
        }

        /// <summary>
        /// Read data
        /// </summary>
        /// <returns>Input data</returns>
        public static string Read()
        {
            return _console.Read();
        }
    }
}
