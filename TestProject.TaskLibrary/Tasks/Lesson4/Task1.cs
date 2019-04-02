using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            int n = Convert.ToInt32(Logger.Read());
            int[] array = Utility.ReadArray();
            int[] cubeArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                cubeArray[i] = array[i] * array[i] * array[i];
            }

            for (int i = 0; i < n; i++)
            {
                Logger.Write(cubeArray[i] + " ");
            }
            Logger.Write("\n");
        }
    }
}
