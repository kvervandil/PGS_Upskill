using System;
using System.Collections.Generic;
using System.Dynamic;

namespace CastingTraining
{
    class Program
    {
        public static List<int> MyList { get; set; }
        static void Main(string[] args)
        {
            Animal tiger = new Tiger();

            if (tiger is Animal)
            {
                Console.WriteLine("tiger is animal");
            }

            if (tiger is IMammal)
            {
                Console.WriteLine("Tiger is mammal");
            }

            CastTigerAsAnimal(tiger as Tiger);
            CastTigerAsAnimal((Tiger)tiger);


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

            Console.Read();

            var anonym = new { Name = "Kuba", Age = 23 };

            var name = anonym.Name;

            dynamic dummy = "dummy";

            //dummy *= 3;

            dynamic bag = new ExpandoObject();

            bag.FirstName = "Kuba";
            bag.LastName = "Glinski";
            bag.Tiger = tiger;

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

            Console.Read();
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

        public static void CastTigerAsAnimal(Tiger animal)
        {
            var animalInside = nameof(animal);
            Console.WriteLine(animalInside);
        }

        public static void ViewBag(dynamic bag)
        {
            Console.WriteLine(bag.FirstName);
            Console.WriteLine(bag.LastName);
        }

    }
}
