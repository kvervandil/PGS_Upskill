using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents_1
{
    public class EventsTesting
    {
        public int value;
        public delegate void NumberManipulationHandler();

        public event NumberManipulationHandler ChangeNumber;

        public virtual void OnNumberChanged()
        {
            if (ChangeNumber != null)
            {
                ChangeNumber();
            }
            else
            {
                Console.WriteLine("Zdarzenie");
            }
        }

        public EventsTesting(int i)
        {
            SetValue(i);
        }

        public void SetValue(int i)
        {
            if (value != i)
            {
                value = i;
                OnNumberChanged();
            }
        }
    }
}
