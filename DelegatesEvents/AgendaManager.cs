using System;
using System.Threading;

namespace DelegatesEvents_3
{
    public class AgendaManager
    {
        public delegate void AddedAgentEventHandler(object o, AgendaEventArgs e);
        public event AddedAgentEventHandler AddedAgenda;

        //EventHandler
        //EventHandler<TEventArgs>

        public event EventHandler<AgendaEventArgs> AddedAgendaShorter;

        /// <summary>
        /// Event publisher powinien być (konwencja)
        /// 1. protected
        /// 2. virtual
        /// 3. void
        /// 4. Nazwa powinna się zaczynać od "On"
        /// </summary>
        /// <param name="newAgenda"></param>
        public virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null)
            {
                AddedAgenda(this, new AgendaEventArgs { Agenda = newAgenda });
            }
        }

        protected virtual void OnAddedAgendaShorter(Agenda newAgenda)
        {
            AddedAgendaShorter?.Invoke(this, new AgendaEventArgs { Agenda = newAgenda });
        }

        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam dodawać ...");
            Thread.Sleep(3000);
            //Tu poinfmujemy SmsSender, że dodawanie zostało zakończone
            OnAddedAgenda(newAgenda);
            OnAddedAgendaShorter(newAgenda);
            Console.WriteLine("AddAgenda: Skończyłem dodawać ...");
        }
    }
}