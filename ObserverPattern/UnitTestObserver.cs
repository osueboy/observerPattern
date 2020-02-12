using System;

namespace ObserverPattern
{
    public class UnitTestObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
