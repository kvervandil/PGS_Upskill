using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {

            //out
            int value;

            SetToFive(out value);

            Console.WriteLine(value);

            int value2 = 1;
            //always has to be initialized before passed to a method
            Increment(ref value2);
        }

        private static void SetToFive(out int value)
        {
            //has to be initialized, not only modified
            value = 5;
        }

        private static void Increment(ref int value2)
        {
            value2++;
        }
    }
}
