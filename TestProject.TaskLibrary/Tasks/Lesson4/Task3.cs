﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            int n = Convert.ToInt32(Logger.Read());
            int[] array = Utility.ReadArray();

            Logger.Write(IsSymmetric(array) + "\n");
        }

        private bool IsSymmetric(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
