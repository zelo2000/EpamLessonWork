using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Rectangular : IShape
    {
        public Point LeftTop = new Point(0,0);
        public Point RightTop = new Point(0, 0);
        public Point RightBottom = new Point(0, 0);
        public Point LeftBottom = new Point(0, 0);

        public bool IsParallelToAxes()
        {
            if ((LeftTop.Y == RightTop.Y && LeftBottom.Y == RightBottom.Y) &&
                (LeftTop.X == LeftBottom.X && RightTop.X == RightBottom.X))
            {
                return true;
            }
            return false;
        }

        public void GetUnion(Rectangular first, Rectangular second)
        {
            LeftTop.X = Math.Min(first.LeftTop.X, second.LeftTop.X);
            LeftBottom.X = Math.Min(first.LeftTop.X, second.LeftTop.X);

            RightTop.X = Math.Max(first.RightTop.X, second.RightTop.X);
            RightBottom.X = Math.Max(first.RightTop.X, second.RightTop.X);

            LeftTop.Y = Math.Min(first.LeftTop.Y, second.LeftTop.Y);
            RightTop.Y = Math.Min(first.LeftTop.Y, second.LeftTop.Y);

            LeftBottom.Y = Math.Max(first.RightBottom.Y, second.RightBottom.Y);
            RightBottom.Y = Math.Max(first.RightBottom.Y, second.RightBottom.Y);
        }

        public Rectangular GetIntersection(Rectangular first, Rectangular second)
        {
            Rectangular result = new Rectangular();

            

            return result;
        }

        public void Move(Tuple<int, int> vector)
        {
            LeftBottom.X += vector.Item1;
            LeftBottom.Y += vector.Item2;
            LeftTop.X += vector.Item1;
            LeftTop.Y += vector.Item2;
            RightTop.X += vector.Item1;
            RightTop.Y += vector.Item2;
            RightBottom.X += vector.Item1;
            RightBottom.Y += vector.Item2;
        }

        public void Resize(int howMany)
        {
            int width = RightTop.X - LeftTop.X;
            int height = LeftBottom.Y - LeftTop.Y;

            RightTop.X += width * (howMany - 1);
            LeftBottom.Y += height * (howMany - 1);

            RightBottom.X += width * (howMany - 1);
            RightBottom.Y += height * (howMany - 1);
        }

        public void Draw()
        {

            for (var y = 0; y < LeftTop.Y; y++)
            {
                for (var x = 0; x < RightTop.X; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
            }


            for (var y = LeftTop.Y; y < LeftBottom.Y; y++)
            {
                for (var x = 0; x < LeftTop.X; x++)
                {
                    Console.Write(" ");
                }
                for (var x = LeftTop.X; x < RightTop.X; x++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
        }
    }
}
