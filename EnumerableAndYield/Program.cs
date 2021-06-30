using System;
using System.Collections.Generic;

namespace EnumerableAndYield
{
    class Program
    {
        public static List<int> MyList { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyList = new List<int>();

            FillMyList();

            /*foreach (var item in GetTotal())
            {
                Console.WriteLine(item);
            }*/

            foreach (var item in ReturnGreaterThanThree())
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> ReturnGreaterThanThree()
        {
            foreach (var item in MyList)
            {
                if (item > 3)
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<int> GetTotal()
        {
            int result = 0;

            foreach (var item in MyList)
            {
                result += item;
                yield return result;
            }
        }

        private static void FillMyList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
    }
}
