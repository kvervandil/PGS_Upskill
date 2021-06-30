using System;
using System.Threading;

namespace DelegatesEvents
{
    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, EventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        protected virtual void OnAddedAgenda()
        {
            if (AddedAgenda != null)
            {
                AddedAgenda(this, EventArgs.Empty);
            }
        }
        public void AddAgenda(AgendaManager newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam dodawać ...");
            Thread.Sleep(3000);
            OnAddedAgenda();
            Console.WriteLine("AddAgenda: Skończyłem dodawać ...");
        }
    }
}