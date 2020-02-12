using System;

namespace ObserverPattern
{
    public class InstalerObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
