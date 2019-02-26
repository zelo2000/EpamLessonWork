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
            Rectangular rect1 = new Rectangular();
            var lt = new Point(logger);
            var rt = new Point(logger);
            var lb = new Point(logger);
            var rb = new Point(logger);

            rect1.RightBottom = rb;
            rect1.LeftBottom = lb;
            rect1.LeftTop = lt;
            rect1.RightTop = rt;

            rect1.Draw();

            rect1.Move(new Tuple<int, int>(2, 2));
            rect1.Draw();

            rect1.Resize(2);
            rect1.Draw();

            Rectangular rect2 = new Rectangular();
            lt = new Point(logger);
            rt = new Point(logger);
            lb = new Point(logger);
            rb = new Point(logger);
            rect2.RightBottom = rb;
            rect2.LeftBottom = lb;
            rect2.LeftTop = lt;
            rect2.RightTop = rt;

            Rectangular rect3 = new Rectangular();
            rect3.GetUnion(rect1, rect2);
            rect3.Draw();
        }
    }
}
