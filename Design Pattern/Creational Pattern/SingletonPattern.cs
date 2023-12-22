using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SingletonPattern
{
    // 전역 변수를 사용하지 않고 하나의 객체만을 생성하도록 함
    // 어디에서든지 객체를 참조할 수 있도록 함

    public class Printer
    {
        static readonly object Instancelock = new object();
        static Printer instance = null;

        // Printer 객체를 가져올 수 있는 유일한 메소드
        public static Printer GetInstance()
        {
            // 다중 스레드에서 Printer 클래스를 이용할 때 인스턴스가 1개 이상 생성될 수 있음
            // 해결방법 1. 이를 방지하기 위해 lock 문을 사용
            // 해결방법 2. 정적 변수에 인스턴스를 만들어 바로 초기화한다
            /// static Printer instance = new Printer();
            lock(Instancelock)
            {
                if (instance == null)
                {
                    instance = new Printer();
                }
            }

            return instance;
        }

        // 생성자를 외부에서 호출할 수 없도록 private로 선언
        private Printer() { }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
