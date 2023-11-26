using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 7, 1, 9, 5, 3 };

            Task<int> minTask = Task.Run(() => FindMin(array));
            Task<int> maxTask = Task.Run(() => FindMax(array));
            Task<double> averageTask = Task.Run(() => CalculateAverage(array));
            Task<int> sumTask = Task.Run(() => CalculateSum(array));

            Task.WaitAll(minTask, maxTask, averageTask, sumTask);

            Console.WriteLine($"Min: {minTask.Result}, Max: {maxTask.Result}, Average: {averageTask.Result}, Sum: {sumTask.Result}");
            Console.ReadLine();
        }
        static int FindMin(int[] array)
        {
            return array.Min();
        }

        static int FindMax(int[] array)
        {
            return array.Max();
        }

        static double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        static int CalculateSum(int[] array)
        {
            return array.Sum();
        }
    }
}
