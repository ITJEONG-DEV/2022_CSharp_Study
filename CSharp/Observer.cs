using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Observer
{
    public interface Observer
    {
        void Update(string title, string news);
    }

    public interface Publisher
    {
        void Add(Observer observer);
        void Delete(Observer observer);
        void Notify();
    }

    public class NewsMachine : Publisher
    {
        private List<Observer> observers;
        private string title;
        private string news;

        public string Title { get; }
        public string News { get; }

        public NewsMachine()
        {
            observers = new List<Observer>();
        }

        public void Add(Observer observer)
        {
            observers.Add(observer);
        }

        public void Delete(Observer observer)
        {
            var result = observers.Remove(observer);

            if (result)
                Console.WriteLine("observer 제거됨");
            else
                Console.WriteLine("존재하지 않는 observer");
        }

        public void Notify()
        {
            foreach(Observer observer in observers)
            {
                observer.Update(title, news);
            }
        }

        public void SetNewsInfo(string title, string news)
        {
            this.title = title;
            this.news = news;
            Notify();
        }
    }

    public class AnnualSubscriber : Observer
    {
        private string news;
        private Publisher publisher;

        public AnnualSubscriber(Publisher publisher)
        {
            this.publisher = publisher;
            this.publisher.Add(this);
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
            this.publisher.Add(this);
        }

        public void Update(string title, string news)
        {
            this.news = title + "\n -------- \n " + news;
            Display();
        }

        public void Withdraw()
        {
            publisher.Delete(this);
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

            newsMachine.SetNewsInfo("오늘 한파", "전국 영하 18도");

            eventSubscriber.Withdraw();
            newsMachine.SetNewsInfo("벚꽃 축제", "벚꽃 구경");

        }
    }
}
