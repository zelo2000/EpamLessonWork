using System;
using System.Diagnostics;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Point Center { get; set; }

        public Circle()
        {

        }

        public Circle(Point c, double r)
        {
            Center = c;
            Radius = r;
        }

        public void Draw()
        {
            double thickness = 0.4;

            for (var i = 0; i <= Center.Y * thickness; i++)
            {
                Logger.Write("\n");
            }

            double rIn = Radius - thickness;
            double rOut = Radius + thickness;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (var i = 0; i <= Center.X; i++)
                    Logger.Write(" ");
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Logger.Write("*");
                    }
                    else
                    {
                        Logger.Write(" ");
                    }
                }
                Logger.Write("\n");
            }
        }

        public void Move(Tuple<int, int> vector)
        {
            Center.X += vector.Item1;
            Center.Y += vector.Item2;
        }

        public void Resize(int howMany)
        {
            Radius *= howMany;
        }
    }
}