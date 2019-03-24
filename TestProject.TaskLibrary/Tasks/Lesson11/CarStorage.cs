using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    [Serializable]
    public class CarStorage : IEnumerable<Car>
    {
        List<Car> Cars = new List<Car>();

        public CarStorage() { }

        public CarStorage(List<Car> cars)
        {
            Cars = cars;
        }

        public void Add(object car)
        {
            Cars.Add((Car)car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
    }
}
