using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson17
{
    public class Task1 : IRunnable
    {
        const int THREADS_AMOUNT = 4;
        private static long Sum { get; set; }

        public void Run()
        {
            var arr = GetRandomArray(1000000);

            List<Thread> threads = new List<Thread>();
            for (var i = 0; i < THREADS_AMOUNT; i++)
            {
                threads.Add(new Thread(PartSum));
            }

            for (var i = 0; i < threads.Count; i++)
            {
                int intervalLength = arr.Length / threads.Count;
                threads[i].Start(new Tuple<int[], int, int>(arr, i * intervalLength, (i + 1) * intervalLength));
                threads[i].Join();
            }

            Logger.Write($"Time in {THREADS_AMOUNT} threads is {Sum}");
        }


        public int[] GetRandomArray(int number)
        {
            var random = new Random();
            var arr = new int[number];
            for (var i = 0; i < number; i++)
            {
                arr[i] = random.Next();
            }
            return arr;
        }

        static void PartSum(object part)
        {
            var convertedPart = part as Tuple<int[], int, int>;
            double sum = 0;
            var watch = new Stopwatch();

            watch.Start();
            for (var i = convertedPart.Item2; i < convertedPart.Item3; i++)
            {
                sum += convertedPart.Item1[i];
            }
            watch.Stop();

            Sum += watch.ElapsedMilliseconds;
            Logger.Write(watch.ElapsedMilliseconds + "\n");
        }
    }
}
