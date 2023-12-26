using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.FacadePattern
{
    // 유지보수에 용이하지 않음
    // Client에 여러 객체들이 강하게 결합되는 것을 방지
    // Client에서는 ViewMovie() 만을 호출하여 영화보기 동작을 수행함
    // 메서드의 의미 또한 명확하게 알 수 있음

    // 낮은 결합도 : SubSystem의 코드를 몰라도 사용할 수 있음. SubSystem들간의 복잡한 결합도를 낮출 수 있음
    // 가독성 상승 : 하나의 객체만을 호출하여 사용할 수 있음. 객체의 네이밍 또한 간단 명료함
    // 최대한 연관성 있는 객체들끼리 계층화시켜 고수준 객체를 설계할 수 있음

    // 시스템이 복잡할 때 사용할 수 있음
    // 시스템을 사용하는 외부와의 결합도가 너무 높을 때 사용할 수 있음

    // Facade 클래스 자체가 서브 시스템에 대한 의존성을 가지게 됨. (의존성을 완전히 피할 수는 없음)
    // 추가적인 코드가 늘어나는 것으로, 유지보수 측면에서 공수가 더 많이 들게 됨.

    public class RemoteControl
    {
        public void TurnON()
        {
            Console.WriteLine("TV ON");
        }

        public void TurnOFF()
        {
            Console.WriteLine("TV OFF");
        }
    }

    public class Movie
    {
        private string name = "";

        public Movie(string name)
        {
            this.name = name;
        }

        public void SearchMovie()
        {
            Console.WriteLine($"Find {name}");
        }

        public void ChargeMovie()
        {
            Console.WriteLine($"Charge {name}");
        }

        public void PlayMovie()
        {
            Console.WriteLine($"Play {name}");
        }
    }

    public class Beverage
    {
        private string name = "";

        public Beverage(string name)
        {
            this.name = name;
        }

        public void Prepare()
        {
            Console.WriteLine($"{name} 준비");
        }
    }

    public class Facade
    {
        private string beverageName = "";
        private string movieName = "";

        public Facade(string beverageName, string movieName)
        {
            this.beverageName = beverageName;
            this.movieName = movieName;
        }

        public void ViewMovie()
        {
            Beverage beverage = new Beverage(beverageName);
            RemoteControl remoteControl = new RemoteControl();
            Movie movie = new Movie(movieName);

            beverage.Prepare();
            remoteControl.TurnON();
            movie.SearchMovie();
            movie.ChargeMovie();
            movie.PlayMovie();
        }
    }
}
