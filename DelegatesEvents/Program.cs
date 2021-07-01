using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents_3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var manager = new AgendaManager();
            var smsSender = new SmsSender();

            manager.AddedAgenda += smsSender.OnAddedAgenda;
            manager.AddedAgenda += smsSender.OnAddedAgendaShorter;
            manager.AddedAgendaShorter += smsSender.OnAddedAgendaShorter;
            manager.AddedAgendaShorter += smsSender.OnAddedAgenda;

            manager.AddAgenda(new Agenda
            {
                AgendaDateTime = DateTime.Now.AddDays(2),
                AgendaName = "Kubuś Puchatek i przyjaciele"
            });

            Console.Read();
        }
    }
}
