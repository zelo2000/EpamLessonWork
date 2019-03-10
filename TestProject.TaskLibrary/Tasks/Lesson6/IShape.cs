using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public interface IShape
    {
        void Move(Tuple<int, int> vector);
        void Resize(int howMany);
        void Draw(ILog logger);
    }
}
