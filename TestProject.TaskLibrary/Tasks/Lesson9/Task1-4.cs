﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson9
{
    public class Task1_4 : IRunnable
    {
        private int HendleStackOverflowException(int n)
        {
            return HendleStackOverflowException(n * n);
        }

        private int HendleIndexOutOfRangeException()
        {
            var arr = new int[2];
            return arr[100];
        }

        public void Run()
        {
            try
            {
                HendleStackOverflowException(1);
                HendleIndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Logger.Write(e.Message);
            }
            catch (StackOverflowException e)
            {
                Logger.Write(e.Message);
            }

        }
    }
}
