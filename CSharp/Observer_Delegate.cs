using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ObserverUsingDelegate
{
    public delegate void NotifyObserver(string title, string news);

    public interface Observer
    {
        void Update(string title, string news);
    }

    public abstract class Publisher
    {
        public event NotifyObserver NotifyObserverEvent;

        public void Add(NotifyObserver observer)
        {
            NotifyObserverEvent += observer;
        }
        public void Delete(NotifyObserver observer)
        {
            NotifyObserverEvent -= observer;
        }
        public void Notify(string title, string news)
        {
            if(NotifyObserverEvent != null)
            {
                NotifyObserverEvent(title, news);
            }
        }
    }

    public class NewsMachine : Publisher
    {
    }

    public class AnnualSubscriber : Observer
    {
        private string news;
        private Publisher publisher;

        public AnnualSubscriber(Publisher publisher)
        {
            this.publisher = publisher;
            this.publisher.Add(Update);
        }

        public void Update(string title, string news)
        {
            this.news = title + "\n -------- \n " + news;
            Display();
        }

        private void Display()
        {
            Console.WriteLine("\n\n오늘의 뉴스\n============================\n\n" + this.news);
        }
    }

    public class EventSubscriber : Observer
    {
        private string news;
        private Publisher publisher;

        public EventSubscriber(Publisher publisher)
        {
            this.publisher = publisher;
            this.publisher.Add(Update);
        }

        public void Update(string title, string news)
        {
            this.news = title + "\n -------- \n " + news;
            Display();
        }

        public void Withdraw()
        {
            publisher.Delete(Update);
        }

        private void Display()
        {
            Console.WriteLine("\n\n=== 이벤트 유저 ===");
            Console.WriteLine("\n\n" + this.news);
        }

    }

    public class ObserverExample
    {
        static void main(string[] args)
        {
            NewsMachine newsMachine = new NewsMachine();
            AnnualSubscriber annualSubscriber = new AnnualSubscriber(newsMachine);
            EventSubscriber eventSubscriber = new EventSubscriber(newsMachine);

            newsMachine.Notify("오늘 한파", "전국 영하 18도");

            eventSubscriber.Withdraw();
            newsMachine.Notify("벚꽃 축제", "벚꽃 구경");

        }
    }
}
