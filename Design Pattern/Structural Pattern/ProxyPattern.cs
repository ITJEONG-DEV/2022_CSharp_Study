using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.ProxyPattern
{
    // 어떤 객체를 사용할 때, 직접적으로 참조하는 것이 아닌 해당 객체를 대항하는 객체를 통해 대상 객체에 접근함
    // 해당 객체가 메모리에 존재하지 않아도 기본적인 정보를 참조하거나 설정할 수 있으며, 실제 객체의 기능이 필요한 시점까지 객체 생성을 미룰 수 있음

    // 사이즈가 큰 객체가 로딩되기 전에 프록시를 통해 참조할 수 있음
    // 실제 객체의 public, protected 메소드를 숨기고 인터페이스를 통해 노출시킬 수 있음
    // 원래 객체의 접근에 대한 사전처리 할 수 있음

    // 객체 생성 시 추가적인 단계를 거치게 되므로, 빈번한 객체 생성이 필요한 경우 성능이 저하될 수 있음
    // 프록시 내부에서 객체 생성을 위해 스레스 생성, 동기화가 구현되어야 하는 경우 성능이 저하될 수 있음
    // 로직이 난해해져 가독성이 떨어질 수 있음

    #region 기본형 프록시 (Normal Proxy)
    public interface ISubject
    {
        void Action();
    }

    public class RealSubject : ISubject
    {
        public void Action()
        {
            Console.WriteLine("RealSubject Action");
        }
    }

    public class NormalProxy : ISubject
    {
        RealSubject subject;

        public NormalProxy(RealSubject subject)
        {
            this.subject = subject;
        }

        public void Action()
        {
            subject.Action();
            Console.WriteLine("Normal Proxy Action");
        }
    }
    #endregion

    #region 가상 프록시 (Virtual Proxy)
    /// 지연 초기화 방식
    /// 실제 객체의 생성에 많은 자원이 소모되지만 사용 빈도는 낮을 때 사용
    /// 서비스가 시작될 때 객체를 생성하는 대신, 객체 초기화가 실제로 필요한 시점에 초기화될 수 있도록 지연

    public class VirtualProxy:ISubject
    {
        RealSubject subject;

        public VirtualProxy() { }

        public void Action()
        {
            if(subject == null)
                subject = new RealSubject();

            subject.Action();
            Console.WriteLine("Virtual Proxy Action");
        }
    }
    #endregion

    #region 보호 프록시 (Protection Proxy)
    /// 프록시가 대상 객체에 대한 자원으로의 액세스 제어 (접근 권한)
    /// 특정 클라이언트만 서비스  객체를 사용할 수 있도록 하는 경우에 사용
    /// 클라이언트의 자격 증명이 기준과 일치하는 경우에만 서비스 객체에 요청 전달

    public class ProtectionProxy:ISubject
    {
        RealSubject subject;
        bool access;

        public ProtectionProxy(RealSubject subject, bool access)
        {
            this.subject = subject;
            this.access = access;
        }

        public void Action()
        {
            if (access)
            {
                subject.Action();
                Console.WriteLine("Protection Proxy Action");
            }
        }
    }
    #endregion

    #region 로깅 프록시 (Logging Proxy)
    /// 대상 객체에 대한 로깅을 추가하는 경우
    /// 프록시는 서비스 메서드를 실행하기 전에 로깅하는 기능을 추가하여 재정의

    public class LoggingProxy : ISubject
    {
        RealSubject subject;

        public LoggingProxy(RealSubject subject)
        {
            this.subject = subject;
        }

        public void Action()
        {
            Console.WriteLine("Logging . . . ");

            subject.Action();

            Console.WriteLine("Loggin Proxy Action");

            Console.WriteLine("Logging . . . ");
        }
    }
    #endregion

    #region 원격 프록시 (Remote Proxy)
    /// 프록시 클래스는 로컬에 있고, 대상 객체는 원격 서버에 존재하는 경우
    /// 프록시 객체는 네트워크를 통해 클라이언트의 요청을 전달, 네트워크와 관련된 불필요한 작업들을 처리하고 결과값만 반환
    /// 프록시를 통해 객체를 이용함 > 클라이언트 입장에서는 원격이든 로컬이든 신경 쓸 필요가 없음.
    /// 로컬 환경에 존재하며, 원격 객체에 대한 대변자 역할을 객체나 서로 다른 주소 공간에 있는 객체에 대해 마치 같은 주소 공간에 있는 것처럼 동작하게 하는 패턴
    #endregion

    #region 캐싱 프록시 (Caching Proxy)
    /// 데이터가 큰 경우 캐싱하여 재사용을 유도
    /// 클라이언트의 요청 결과를 캐시하고 캐시의 수명 주기를 관리함
    #endregion
}
