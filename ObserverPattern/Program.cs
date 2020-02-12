using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommitPublisher commitPublisher = new CommitPublisher();

            Menu menu = new Menu(commitPublisher);

            menu.ReadOption();

        }
    }
}
