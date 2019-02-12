using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task4 : IRunnable
    {
        public void Run(ILog logger)
        {
            int m = Convert.ToInt32(logger.Read());
            int n = Convert.ToInt32(logger.Read());
            int[,] doubleDimensionArray = new int[m, n];

            for (var i = 0; i < m; i++)
            {
                var tempArray = Utility.ReadArray(logger);
                for (var j = 0; j < n; j++)
                {
                    doubleDimensionArray[i, j] = tempArray[j];
                }
            }

            int[] maxVector = new int[m];
            for (var i = 0; i < m; i++)
            {
                int max = doubleDimensionArray[i, 0];
                for (var j = 1; j < n; j++)
                {
                    if (doubleDimensionArray[i, j] > max)
                    {
                        max = doubleDimensionArray[i, j];
                    }
                }
                maxVector[i] = max;
            }

            for (var i = 0; i < n; i++)
            {
                logger.Write(maxVector[i] + " ");
            }
            logger.Write("\n");
        }
    }
}
