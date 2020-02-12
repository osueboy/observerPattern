namespace ObserverPattern
{
    public interface IPublisher
    {
        void Notify();
        void AddObserver(IObserver observer);
    }
}
