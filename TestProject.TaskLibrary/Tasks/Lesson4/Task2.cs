using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            int n = Convert.ToInt32(Logger.Read());
            int[] array = Utility.ReadArray();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (IsPrime(array[i]))
                {
                    sum += 1;
                }
            }

            Logger.Write(sum + "\n");
        }

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
    }
}
