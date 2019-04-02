using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson12
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            string firstSurname = Logger.Read();
            string secondSurname = Logger.Read();

            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            int compareResult = String.Compare(firstSurname, secondSurname, true, cultureInfo);
            Logger.Write($"Comparing in {cultureInfo.Name} returns {compareResult}");

            Logger.Write(LengthComparer(firstSurname, secondSurname) + "\n");

            Logger.Write(firstSurname[0].Equals(secondSurname[0]) ? "First letter is equal\n" : "First letter isn't equal\n");
            Logger.Write(firstSurname[firstSurname.Length - 1].Equals(secondSurname[secondSurname.Length - 1]) ? "Last letter is equal\n" : "Last letter isn't equal\n");
        }

        private static string LengthComparer(string first, string second)
        {
            if (first.Length < second.Length)
            {
                return "First is larger";
            }
            else if (first.Length > second.Length)
            {
                return "Second is larger";
            }
            else
            {
                return "Have equal length";
            }
        }
    }
}
