using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Rectangular : IShape
    {
        public Point LeftTop { get; set; }
        public Point RightTop { get; set; }
        public Point RightBottom { get; set; }
        public Point LeftBottom { get; set; }

        public Rectangular() { }

        public Rectangular(Point lt, Point rt, Point rb, Point lb)
        {
            LeftTop = lt;
            RightTop = rt;
            RightBottom = rb;
            LeftBottom = lb;
        }

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
            LeftTop = new Point();
            LeftBottom = new Point();
            RightTop = new Point();
            RightBottom = new Point();

            LeftTop.X = Math.Min(first.LeftTop.X, second.LeftTop.X);
            LeftBottom.X = Math.Min(first.LeftTop.X, second.LeftTop.X);

            RightTop.X = Math.Max(first.RightTop.X, second.RightTop.X);
            RightBottom.X = Math.Max(first.RightTop.X, second.RightTop.X);

            LeftTop.Y = Math.Min(first.LeftTop.Y, second.LeftTop.Y);
            RightTop.Y = Math.Min(first.LeftTop.Y, second.LeftTop.Y);

            LeftBottom.Y = Math.Max(first.RightBottom.Y, second.RightBottom.Y);
            RightBottom.Y = Math.Max(first.RightBottom.Y, second.RightBottom.Y);
        }

        public void GetIntersection(Rectangular first, Rectangular second)
        {
            LeftTop = new Point();
            LeftBottom = new Point();
            RightTop = new Point();
            RightBottom = new Point();

            if (first.RightBottom.X >= second.LeftBottom.X)
            {
                RightBottom.X = first.RightBottom.X;
                RightTop.X = first.RightBottom.X;
                LeftBottom.X = second.LeftBottom.X;
                LeftTop.X = second.LeftBottom.X;
                if (first.LeftBottom.Y >= second.LeftTop.Y)
                {
                    RightBottom.Y = first.LeftBottom.Y;
                    RightTop.Y = second.LeftTop.Y;
                    LeftBottom.Y = first.LeftBottom.Y;
                    LeftTop.Y = second.LeftTop.Y;
                }
                else if (first.LeftTop.Y <= second.LeftBottom.Y)
                {
                    RightBottom.Y = second.LeftBottom.Y;
                    RightTop.Y = first.LeftTop.Y;
                    LeftBottom.Y = second.LeftBottom.Y;
                    LeftTop.Y = first.LeftTop.Y;
                }
            }
            else if (first.LeftBottom.X <= second.RightBottom.X)
            {
                RightBottom.X = second.RightBottom.X;
                RightTop.X = second.RightBottom.X;
                LeftBottom.X = first.LeftBottom.X;
                LeftTop.X = first.LeftBottom.X;
                if (first.LeftBottom.Y >= second.LeftTop.Y)
                {
                    RightBottom.Y = first.LeftBottom.Y;
                    RightTop.Y = second.LeftTop.Y;
                    LeftBottom.Y = first.LeftBottom.Y;
                    LeftTop.Y = second.LeftTop.Y;
                }
                else if (first.LeftTop.Y >= second.LeftBottom.Y)
                {
                    RightBottom.Y = second.LeftBottom.Y;
                    RightTop.Y = first.LeftTop.Y;
                    LeftBottom.Y = second.LeftBottom.Y;
                    LeftTop.Y = first.LeftTop.Y;
                }
            }
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

        public void Draw(ILog logger)
        {

            for (var y = 0; y < LeftTop.Y; y++)
            {
                for (var x = 0; x < RightTop.X; x++)
                {
                    logger.Write(" ");
                }
                logger.Write("\n");
            }


            for (var y = LeftTop.Y; y < LeftBottom.Y; y++)
            {
                for (var x = 0; x < LeftTop.X; x++)
                {
                    logger.Write(" ");
                }
                for (var x = LeftTop.X; x < RightTop.X; x++)
                {
                    logger.Write("#");
                }
                logger.Write("\n");
            }
        }
    }
}
