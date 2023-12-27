using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralPattern.ChainofResponsibilityPattern
{
    // 클라이언트로부터 요청을 처리할 수 있는 처리객체를 집합(Chain)으로 만들어 부여함. > 결합이 느슨해짐

    // 요청의 발신자와 수신자를 분리하는 경우
    // 요청을 처리할 수 있는 객체가 여러개일 때 그 중 하나에 요청을 보내려는 경우
    // 코드에서 처리객체를 명시적으로 지정하고 싶지 않은 경우

    // 집합 내의 처리 순서를 변경하거나 처리객체를 추가/삭제할 수 있어 유연성이 향상됨
    // 새로운 요청에 대한 처리객체 생성이 매우 편리해짐

    // 요청이 반드시 수행된다는 보장이 없음
    // 충분한 디버깅을 거치지 않았을 경우 집합 내부에서 사이클이 발생할 수 있음
    // 디버깅 및 테스트 어려움

    public interface Chain
    {
        void SetNext(Chain nextInChain);
        void Process(Number request);
    }

    public class Number
    {
        int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }
    }

    public class NegativeProcessor : Chain
    {
        Chain nextInChain;

        public void SetNext(Chain nextInChain)
        {
            this.nextInChain = nextInChain;
        }

        public void Process(Number request)
        {
            if(request.GetNumber() < 0)
            {
                Console.WriteLine($"NegativeProcessor: {request.GetNumber()}");
            }
            else
            {
                nextInChain.Process(request);
            }
        }

    }

    public class ZeroProcessor : Chain
    {
        Chain nextInChain;

        public void SetNext(Chain nextInChain)
        {
            this.nextInChain = nextInChain;
        }

        public void Process(Number request)
        {
            if(request.GetNumber() == 0)
            {
                Console.WriteLine($"ZeroProcessor: {request.GetNumber()}");
            }
            else
            {
                nextInChain.Process(request);
            }
        }
    }

    public class PositiveProcessor: Chain
    {
        Chain nextInChain;

        public void SetNext(Chain nextInChain)
        {
            this.nextInChain = nextInChain;
        }

        public void Process(Number request)
        {
            if (request.GetNumber() > 0)
            {
                Console.WriteLine($"PositiveProcessor: {request.GetNumber()}");
            }
            else
            {
                nextInChain.Process(request);
            }
        }
    }

    public class Main
    {
        public static void main(string[] args)
        {
            Chain c1 = new NegativeProcessor();
            Chain c2 = new ZeroProcessor();
            Chain c3 = new PositiveProcessor();

            c1.SetNext(c2);
            c2.SetNext(c3);

            c1.Process(new Number(90));
            c1.Process(new Number(-50));
            c1.Process(new Number(0));
            c1.Process(new Number(91));
        }
    }
}
