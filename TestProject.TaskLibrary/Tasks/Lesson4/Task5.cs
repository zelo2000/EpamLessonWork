using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            int m = Convert.ToInt32(Logger.Read());
            int n = Convert.ToInt32(Logger.Read());
            int[][] jaggedArray = new int[m][];

            for (var i = 0; i < m; i++)
            {
                var tempArray = Utility.ReadArray();
                jaggedArray[i] = tempArray;
            }

            int[] maxVector = new int[m];
            for (var i = 0; i < m; i++)
            {
                int max = jaggedArray[i][0];
                for (var j = 1; j < n; j++)
                {
                    if (jaggedArray[i][j] > max)
                    {
                        max = jaggedArray[i][j];
                    }
                }
                maxVector[i] = max;
            }

            for (var i = 0; i < n; i++)
            {
                Logger.Write(maxVector[i] + " ");
            }
            Logger.Write("\n");
        }
    }
}
