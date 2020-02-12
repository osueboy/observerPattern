using System;

namespace ObserverPattern
{
    public class CommitObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
        }
    }
}
