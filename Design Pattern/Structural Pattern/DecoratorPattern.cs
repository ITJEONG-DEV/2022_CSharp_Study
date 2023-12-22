using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern
{
    // 객체의 결합을 통해 기능을 동적으로 유연하게 확장할 수 있게 해주는 패턴
    // 기본 기능에 추가할 수 있는 기능의 종류가 많은 경우 각 추가 기능을 Decorator 클래스로 정의 후 필요한 Decorator 객체를 조합하여 추가 기능의 조합을 설계

    // 추가 기능별로 개별적인 클래스를 설계하고
    // 기능을 조합할 때 각 클래스의 객체 조합을 이용

    #region Road Display Example
    public class Client
    {
        public static void Main(string[] args)
        {
            // 기본 도로 표시
            Display road = new RoadDisplay();
            road.Draw();

            // 기본 도로 표시 + 차선 표시
            Display roatWithLane = new LaneDecorator(new RoadDisplay());
            roatWithLane.Draw();

            // 기본 도로 표시 + 교통량 표시
            Display roadWithTraffic = new TrafficDecorator(new RoadDisplay());
            roadWithTraffic.Draw();

            // 기본 도로 표시 + 차선 표시 + 교통량 표시 + 교차로 표시
            Display roadWithCrossingLaneAndTraffic = new LaneDecorator(new TrafficDecorator(new CrossingDecorator(new RoadDisplay())));
            roadWithCrossingLaneAndTraffic.Draw();
        }
    }

    public abstract class Display
    {
        public abstract void Draw();
    }

    public class RoadDisplay:Display
    {
        public override void Draw()
        {
            Console.WriteLine($"기본 도로 표시");
        }
    }

    public class DisplayDecorator:Display
    {
        Display decoratedDisplay;

        public DisplayDecorator(Display decoratedDisplay)
        {
            this.decoratedDisplay = decoratedDisplay;
        }

        public override void Draw()
        {
            decoratedDisplay.Draw();
        }
    }

    public class LaneDecorator : DisplayDecorator
    {
        public LaneDecorator(Display decoratedDisplay): base(decoratedDisplay) { }

        public override void Draw()
        {
            base.Draw();
            DrawLane();
        }

        void DrawLane()
        {
            Console.WriteLine($"차선 표시");
        }
    }

    public class TrafficDecorator : DisplayDecorator
    {
        public TrafficDecorator(Display decoratedDisplay) : base(decoratedDisplay) {}

        public override void Draw()
        {
            base.Draw();
            DrawTraffic();
        }

        void DrawTraffic()
        {
            Console.WriteLine($"교통량 표시");
        }
    }

    public class CrossingDecorator : DisplayDecorator
    {
        public CrossingDecorator(Display decoratedDisplay): base(decoratedDisplay) { }

        public override void Draw()
        {
            base.Draw();
            DrawCrossing();
        }

        void DrawCrossing()
        {
            Console.WriteLine($"교차로 표시");
        }
    }
    #endregion

    #region Coffee Example
    public abstract class Beverage
    {
        protected int cost;
        protected string description;

        public abstract int GetCost();
        public virtual string GetDescription()
        {
            return description;
        }
    }

    public class Americano : Beverage
    {
        public Americano():base()
        {
            cost = 2500;
            description = "아메리카노";
        }

        public override int GetCost()
        {
            return cost;
        }
    }

    public class CaffeLatte : Beverage
    {
        public CaffeLatte():base()
        {
            cost = 3500;
            description = "카페라떼";
        }

        public override int GetCost()
        {
            return cost;
        }
    }

    public abstract class CodimentDecorator : Beverage
    {
    }

    public class Whip:CodimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage):base()
        {
            this.beverage = beverage;

            description = ", 휘핑크림";
            cost = 500;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + description;
        }
    }

    public class Shot : CodimentDecorator
    {
        Beverage beverage;

        public Shot(Beverage beverage):base()
        {
            this.beverage = beverage;

            description = ", 샷";
            cost = 500;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + description;
        }
    }

    public class Cream:CodimentDecorator
    {
        Beverage beverage;

        public Cream(Beverage beverage) :base()
        {
            this.beverage = beverage;

            description = ", 크림";
            cost = 500;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + description;
        }
    }

    public class JavaChip : CodimentDecorator
    {
        Beverage beverage;

        public JavaChip(Beverage beverage) : base()
        {
            this.beverage = beverage;

            description = ", 자바칩";
            cost = 600;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + description;
        }
    }

    public class Customer
    {
        public static void main(String[] args)
        {
            Beverage customCoffee = new CaffeLatte();
            customCoffee = new Shot(customCoffee);
            customCoffee = new Shot(customCoffee);
            customCoffee = new Cream(customCoffee);
            customCoffee = new Whip(customCoffee);
            customCoffee = new JavaChip(customCoffee);

            Console.WriteLine($"메뉴: {customCoffee.GetDescription()}, 가격: {customCoffee.GetCost()}");
        }
    }
    #endregion
}
