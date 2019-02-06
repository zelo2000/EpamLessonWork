﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    class Rectangle : Figure
    {
        public override void Draw(ILog loger)
        {
            loger.Write("Rectangle\n");
        }
    }
}
