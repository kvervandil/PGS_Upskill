using System;
using System.Dynamic;

namespace ExpandoAndDynamicObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic bag = new ExpandoObject();

            bag.FirstName = "Kuba";
            bag.LastName = "Glinski";

            bag.Print = (Action)(() =>
            {
                Console.WriteLine(bag.FirstName);
                Console.WriteLine(bag.LastName);
                Console.WriteLine(bag.Tiger.Name);
            }
            );

            bag.Print();

            dynamic wrapper = new CustomWrapper();

            Console.WriteLine(wrapper.FirstName);
            Console.WriteLine(wrapper.LastName);
        }
    }
}
