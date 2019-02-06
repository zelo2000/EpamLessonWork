using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    class Rectangle : IDrawable
    {
        public void Draw(ILog loger)
        {
            loger.Write("Rectangle\n");
        }
    }
}
