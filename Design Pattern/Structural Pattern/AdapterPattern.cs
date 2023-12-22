using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.AdapterPattern
{
    // 클래스의 인터페이스를 사용자가 기대하는 다른 인터페이스로 변환하는 패턴
    // 호환성이 없는 인터페이스 때문에 함께 동작할 수 없는 클래스들이 함께 작동하도록 해줌

    // 외부 라이브러리 클래스의 인터페이스가 다른 코드와 호환되지 않을 때 사용
    // 여러 자식 클래스가 있는데, 부모 클래스를 수정하기에 호환성이 문제가 될 때 해결 가능

    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    public class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
}
