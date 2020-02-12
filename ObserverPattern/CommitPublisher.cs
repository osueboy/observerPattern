using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class CommitPublisher : IPublisher
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            if (!_observers.Any())
            {
                Console.WriteLine("No se encontraron suscriptores");
            }
            foreach(IObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
