using System;

namespace DelegatesEvents_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var test = new EventsTesting(5);

            test.SetValue(5);
            test.SetValue(8);
            test.SetValue(19);
            test.SetValue(19);

            Console.ReadKey();
        }
    }
}
