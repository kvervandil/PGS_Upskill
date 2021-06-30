using System;

namespace Training_aggregation_composition_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            //out
            int value;

            SetToFive(out value);

            //boxing
            //10x slower
            object valueBoxed = value;

            //unboxing
            //5x slower
            //must be cast to the same type as type wrapped
            value = (int)valueBoxed;

            //aggregation
            var engine = new Engine();
            var wheelRightFront = new Wheel("Right Front");
            var wheelRightRear = new Wheel("Right Rear");
            var wheelLeftFront = new Wheel("Left Front");
            var wheelLeftRear = new Wheel("Left Rear");

            var car = new Car(engine, wheelLeftFront, wheelLeftRear, wheelRightFront, wheelRightRear);

            //composition
            var person = new Person();

            Console.Read();
        }

        private static void SetToFive(out int value)
        {
            //has to be initialized, not only modified
            value = 5;
        }
    }
}
