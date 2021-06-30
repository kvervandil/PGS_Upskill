using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    public class CarsComputer
    {
        private int temperature;
        public int pressure;

        public CarsComputer(int p, int t)
        {
            temperature = t;
            pressure = p;
        }

        public int GetTemperature()
        {
            return temperature;
        }
        public int GetPressure()
        {
            return pressure;
        }
    }
}
