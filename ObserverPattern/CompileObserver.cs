using System;

namespace ObserverPattern
{
    public class CompileObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
