using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTraining
{
    class Program
    {
        public static List<int> Numbers = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FillNumbers();

            Console.WriteLine(Numbers.Count());

            var even = Numbers.Where(x => x % 2 == 0);

            Console.WriteLine($"first: {even.First()}, last: {even.Last()}");

            var nthElement = Numbers.Skip(4).First();

            Console.WriteLine(nthElement);

            var result = Numbers.Select(x => x > 15).Any();
            var result1 = Numbers.Find(x => x > 15);
            var result2 = Numbers.Exists(x => x > 15);

            var lessThan15 = Numbers.Select(x => x < 15).Any();

            var min = Numbers.Min();

            var max = Numbers.Max();

            var avg = Numbers.Average();

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);

            Console.Read();
        }

        public static void FillNumbers()
        {
            for (int i = 1; i < 21; i++)
            {
                Numbers.Add(i);
            }
        }
    }
}
