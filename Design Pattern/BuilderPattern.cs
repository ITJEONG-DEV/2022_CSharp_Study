using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.BuilderPattern
{
    // Product 클래스의 객체 생성은 반드시 ConcreteBuilder를 통해서만 할 수 있다
    // 클래스를 여러 번 인스턴스화 하는 경우 빌더를 재사용하여 객체를 찍어낼 수 있음
    // 클래스 생성자가 멤버가 수정되면 빌더 클래스도 수정해야 한다는 단점

    // 생성자의 매개변수가 많아지는 경우 유연하게 대응하기 위함
    // 필요한 데이터를 모두 설정한 이후 객체를 만드는 방법
    // setter 메소드가 없어 변경 불가능한 객체를 만들 수 있음

    // 필요한 데이터만 설정할 수 있음
    // 유연성을 확보할 수 있음

    public class Client
    {
        public static void main(string[] args)
        {
            Human.HumanBuilder humanBuilder = new Human.HumanBuilder();
            Human human = humanBuilder
                    .SetMoney(1000000000)
                    .SetName("Moon")
                    .SetHeight(180.0f)
                    .SetWeight(80f)
                    .SetAddress("Korea **city")
                    .SetPhone("010-0000-0000")
                    .SetCar(null)
                    .SetJob("Programmer")
                    .SetHobby(null)
                    .Build();
        }
    }

    public class Human
    {
        private int _money;
        private string _name;
        private float _height;
        private float _weight;
        private string _address;
        private string _phone;
        private string _car;
        private string _job;
        private string _hobby;

        /// 
        /// 빌더를 통해서 파라미터를 꺼내오는 생성자
        /// 
        private Human(HumanBuilder builder)
        {
            _money = builder.Money;
            _name = builder.Name;
            _height = builder.Height;
            _weight = builder.Weight;
            _address = builder.Address;
            _phone = builder.Phone;
            _car = builder.Car;
            _job = builder.Job;
            _hobby = builder.Hobby;
        }

        public class HumanBuilder
        {
            private int _money;
            private string _name;
            private float _height;
            private float _weight;
            private string _address;
            private string _phone;
            private string _car;
            private string _job;
            private string _hobby;

            public int Money
            {
                get { return _money; }
            }
            public string Name 
            {
                get { return _name; } 
            }
            public float Height 
            {
                get { return _height; }
            }
            public float Weight
            {
                get { return _weight; } 
            }
            public string Address 
            {
                get { return _address; } 
            }
            public string Phone {
                get { return _phone; }
            }
            public string Car
            {
                get { return _car; }
            }
            public string Job
            {
                get { return _job; }
            }
            public string Hobby
            {
                get { return _hobby; }
            }

            public HumanBuilder() { }

            public HumanBuilder SetMoney(int money)
            {
                _money = money;
                return this;
            }

            public HumanBuilder SetName(string name)
            {
                _name = name;
                return this;
            }

            public HumanBuilder SetHeight(float height)
            {
                _height = height;
                return this;
            }

            public HumanBuilder SetWeight(float weight)
            {
                _weight = weight;
                return this;
            }

            public HumanBuilder SetAddress(string address)
            {
                _address = address;
                return this;
            }

            public HumanBuilder SetPhone(string phone)
            {
                _phone = phone;
                return this;
            }

            public HumanBuilder SetCar(string car)
            {
                _car = car;
                return this;
            }

            public HumanBuilder SetJob(string job)
            {
                _job = job;
                return this;
            }

            public HumanBuilder SetHobby(string hoby)
            {
                _hobby = hoby;
                return this;
            }

            /// 
            /// Builder가 수집한 파라미터를 이용해 인스턴스화 하는 함수.
            /// 
            public Human Build()
            {
                return new Human(this);
            }
        }
    }
    
}
