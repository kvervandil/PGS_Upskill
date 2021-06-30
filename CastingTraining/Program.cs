using System;
using System.Collections.Generic;
using System.Dynamic;

namespace CastingTraining
{
    class Program
    {
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

            Console.Read();

            var anonym = new { Name = "Kuba", Age = 23 };

            var name = anonym.Name;

            dynamic dummy = "dummy";

            //dummy *= 3;

            Console.Read();
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
