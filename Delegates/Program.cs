using System;

namespace Delegates
{
    class Program
    {
        public delegate void SomeMethodDel();

        static void Main(string[] args)
        {
            SomeMethodDel someDel = SomeMethod;
            someDel.Invoke();
        }

        public static void SomeMethod()
        {
            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}
