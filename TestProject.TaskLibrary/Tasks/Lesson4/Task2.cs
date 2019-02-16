using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task2 : IRunnable
    {

        private bool IsPrime(int number)
        {
            if (number != 1)
            {
                for (int j = 2; j <= (int)Math.Sqrt(number) + 1; j++)
                {
                    if (number % j == 0 && number != 2)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public void Run(ILog logger)
        {
            int n = Convert.ToInt32(logger.Read());
            int[] array = Utility.ReadArray(logger);
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (IsPrime(array[i]))
                {
                    sum += 1;
                }
            }

            logger.Write(sum + "\n");
        }
    }
}
