using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Task1 : IRunnable
    {
        public void Run(ILog logger)
        {
            var lt = Utility.InputPoint(logger);
            var rt = Utility.InputPoint(logger);
            var lb = Utility.InputPoint(logger);
            var rb = Utility.InputPoint(logger);
            Rectangular rect1 = new Rectangular(lt, rt, rb, lb);
            rect1.Draw(logger);
            rect1.Move(new Tuple<int, int>(2, 2));
            rect1.Draw(logger);
            rect1.Resize(2);
            rect1.Draw(logger);

            lt = Utility.InputPoint(logger);
            rt = Utility.InputPoint(logger);
            lb = Utility.InputPoint(logger);
            rb = Utility.InputPoint(logger);
            Rectangular rect2 = new Rectangular(lt, rt, rb, lb);

            Rectangular rect3 = new Rectangular();
            rect3.GetUnion(rect1, rect2);
            rect3.Draw(logger);

            rect3 = new Rectangular();
            rect3.GetIntersection(rect1, rect2);
            rect3.Draw(logger);
        }
    }
}
