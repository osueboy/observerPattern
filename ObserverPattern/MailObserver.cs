using System;

namespace ObserverPattern
{
    public class MailObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Existe una actualización de código Versión 1.1");
        }
    }
}
