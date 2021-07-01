using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents_2
{
    class Program
    {
        static void DisplayInformation(string info)
        {
            Console.WriteLine(info);
        }
        public static void Main(string[] args)
        {
            DelegateOnBoardComputerEvent carComputerEvent = new DelegateOnBoardComputerEvent();

            carComputerEvent.CarsComputerEventLog += new DelegateOnBoardComputerEvent.CarsComputerHandler(DisplayInformation);

            carComputerEvent.LogProcess();
            Console.ReadKey();
        }
    }
}
