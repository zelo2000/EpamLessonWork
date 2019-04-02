using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            var lt = Utility.InputPoint();
            var rt = Utility.InputPoint();
            var lb = Utility.InputPoint();
            var rb = Utility.InputPoint();
            Rectangular rect1 = new Rectangular(lt, rt, rb, lb);
            rect1.Draw();
            rect1.Move(new Tuple<int, int>(2, 2));
            rect1.Draw();
            rect1.Resize(2);
            rect1.Draw();

            lt = Utility.InputPoint();
            rt = Utility.InputPoint();
            lb = Utility.InputPoint();
            rb = Utility.InputPoint();
            Rectangular rect2 = new Rectangular(lt, rt, rb, lb);

            Rectangular rect3 = new Rectangular();
            rect3.GetUnion(rect1, rect2);
            rect3.Draw();

            rect3 = new Rectangular();
            rect3.GetIntersection(rect1, rect2);
            rect3.Draw();
        }
    }
}
