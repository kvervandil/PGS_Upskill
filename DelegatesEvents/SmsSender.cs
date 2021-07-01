using System;
namespace DelegatesEvents_3
{
    public class SmsSender
    {
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine($"Sms Sender: SMS was sent !!! Data: {e.Agenda.AgendaDateTime}" +
                $", Nazwa: {e.Agenda.AgendaName}");
        }

        public void OnAddedAgendaShorter(object o, AgendaEventArgs e)
        {
            Console.WriteLine($"Sms Sender Short: SMS was sent !!! Data: {e.Agenda.AgendaDateTime}" +
                $", Nazwa: {e.Agenda.AgendaName}");
        }
    }
}
