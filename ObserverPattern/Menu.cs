using System;

namespace ObserverPattern
{
    public class Menu
    {
        protected IPublisher _publisher;
        public Menu(IPublisher publisher)
        {
            _publisher = publisher;
        }
        public void PrintMenu()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("1 Para hacer commit");
            Console.WriteLine("2 Añadir Observador a Commit");
            Console.WriteLine("3 Añadir Observador a Compilación");
            Console.WriteLine("4 Añadir Observador a Pruebas unitarias");
            Console.WriteLine("5 Añadir Observador a Instalación");
            Console.WriteLine("6 Añadir Observador a Mailer");
        }
        public void ReadOption()
        {
            
            int option;
            do
            {
                Console.Clear();
                PrintMenu();
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    _publisher.Notify();
                }
                else if (option == 2)
                {
                    _publisher.AddObserver(new CommitObserver());
                }
                else if (option == 3)
                {
                    _publisher.AddObserver(new CompileObserver());
                }
                else if (option == 4)
                {
                    _publisher.AddObserver(new UnitTestObserver());
                }
                else if (option == 5)
                {
                    _publisher.AddObserver(new InstalerObserver());
                }
                else if (option == 6)
                {
                    _publisher.AddObserver(new MailObserver());
                }
                Console.ReadKey();
            } while (option != 0);

        }
    }
}
