using System;

namespace Delegates
{
    public class SomeLongRunningData
    {
        public void SomeMethod()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadKey();
        }
    }
}
