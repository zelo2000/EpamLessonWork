using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public interface IShape
    {
        void Move(Tuple<int, int> vector);
        void Resize(int howMany);
        void Draw();
    }
}
