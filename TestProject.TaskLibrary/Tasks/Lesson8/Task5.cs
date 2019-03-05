﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson8
{
    public class Task5 : IRunnable
    {
        private void DoSomeMath(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Parameter should be greater than 0", "a");
            }
            else if (b > 0)
            {
                throw new ArgumentException("Parameter should be less than 0", "b");
            }
        }

        public void Run(ILog logger)
        {
            try
            {
                DoSomeMath(1, 2);
            }
            catch (ArgumentException e)
            when (e.ParamName== "a")
            {
                logger.Write(e.Message);
            }
            catch (ArgumentException e)
            when (e.ParamName == "b")
            {
                logger.Write(e.Message);
            }            
        }
    }
}
