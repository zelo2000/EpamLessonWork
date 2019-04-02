using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson12
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            string cultureName = Logger.Read();
            CultureInfo cultureInfo = new CultureInfo(cultureName);
            DateTime date = Convert.ToDateTime(Logger.Read(), cultureInfo);
            Logger.Write(date.ToString());
        }
    }
}
