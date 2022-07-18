using System;

namespace CSharp.Event
{
    public delegate void MyEventHandler(string message);

    public class Publisher
    {
        public event MyEventHandler MyEventHandler;

        public void Do(int number)
        {
            if (MyEventHandler != null)
            {
                if (number % 10 == 0)
                    MyEventHandler("Active " + number);
                else
                    Console.WriteLine(number);
            }
        }
    }

    public class Subscriber
    {
        static void main(string[] args)
        {
            Publisher p = new Publisher();
            p.MyEventHandler += new MyEventHandler(doAction);

            for (int i = 0; i < 50; i++)
            {
                p.Do(i);
            }
        }

        static public void doAction(string message)
        {
            Console.WriteLine(message);
        }
    }
}
