using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    [Serializable]
    public class Car
    {
        public int CarId;
        public decimal Price;
        public int Quantity;
        public decimal Total;
        public Car() { }
        public Car(int i, double p, int q)
        {
            CarId = i;
            Price = (decimal)p;
            Quantity = q;
            Total = (decimal)p * q;
        }
    }
}
