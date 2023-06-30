using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Csharp.Collection
{
    class TestConcurrentDictionary
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>();
        static ConcurrentDictionary<string, int> dictConcu = new ConcurrentDictionary<string, int>();

        static void Main(string[] args)
        {

            Thread th1 = new Thread(new ThreadStart(InsertData));
            Thread th2 = new Thread(new ThreadStart(InsertData));
            th1.Start();
            th2.Start();
            th1.Join();
            th2.Join();

            Thread th3 = new Thread(new ThreadStart(InsertDataConcu));
            Thread th4 = new Thread(new ThreadStart(InsertDataConcu));
            th3.Start();
            th4.Start();
            th3.Join();
            th4.Join();

            Console.WriteLine(string.Format("Result in Dictionary : {0}", dict.Values.Count));
            Console.WriteLine("********************************************");
            Console.WriteLine(string.Format("Result in Concurrent Dictionary : {0}", dictConcu.Values.Count));
            Console.ReadKey();
        }

        static public void InsertData()
        {
            for(int i=0; i<100; i++)
            {
                dict.Add(Guid.NewGuid().ToString(), i);
            }
        }
        static public void InsertDataConcu()
        {
            for(int i=0; i<100; i++)
            {
                dictConcu.TryAdd(Guid.NewGuid().ToString(), i);
            }
        }
    }
}
