using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents_2
{
    public class DelegateOnBoardComputerEvent
    {
        public delegate void CarsComputerHandler(string info);
        public event CarsComputerHandler CarsComputerEventLog;

        public void LogProcess()
        {
            string information = "OK";

            CarsComputer oc = new CarsComputer(80, 12);

            int t = oc.GetTemperature();
            int p = oc.GetPressure();

            if (t > 70 || p> 15)
            {
                information = "Dokonaj dokładnego przeglądu";
            }

            OnCarsComputerEventLog("Zapisywanie informacji: \n");
            OnCarsComputerEventLog("Temperatura: " + t + "| Ciśnienie: " + p);
            OnCarsComputerEventLog("Informacja: " + information);
        }

        protected void OnCarsComputerEventLog(string information)
        {
            if (CarsComputerEventLog != null)
            {
                CarsComputerEventLog(information);
            }
        }
    }
}
