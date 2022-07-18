using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ActionExample
    {
        static void main(string[] args)
        {
            Action<string> _action1 = Print;
            _action1("1. 기본 메서드 지정 방식");

            Action<string, string> _action2 = delegate (string msg, string error)
            {
                Console.WriteLine(msg, error);
            };
            _action2("2. 무명 메서드 지정", "Inform");

            // 3. 람다식 사용
            Action<int, int> _action3 = (x, y)
                => Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            _action3(4, 8);
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class FuncExample
    {
        static void main(string[] args)
        {
            Func<string, string> _func1 = Print;
            Console.WriteLine(_func1("1. 기존 메서드 지정"));

            Func<int, int, int> _func2 = Sum;
            string msg = string.Format("x + y = {0} 입니다.", _func2(4, 8));

            Console.WriteLine("2. 무명 메서드 지정");
            Func<int, int, int> _func3 = delegate (int x, int y)
            {
                return x + y;
            };
            string msg2 = string.Format("x + y = {0}", _func3(5, 10));
            Console.WriteLine(msg2);

            Console.WriteLine("3. 람다식 사용");
            Func<int, string> _func4 = x
                => { return "반환값은 : " + x + " 입니다."; };
            Console.WriteLine(_func4(100));
        }

        public static string Print(string msg)
        {
            return msg;
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
