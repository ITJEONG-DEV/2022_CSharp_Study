using System;

namespace Design_Pattern.AbstractFactoryPattern
{
    // FactoryMethod에서 creator가 생성하는 객체의 종류가 추가되면 기존에 구현해 둔 Create 메소드를 모두 수정해야 함

    // AbstractFactory는 하나의 Factory에서 지정된 컴포넌트들을 골라 생산하는 방식으로, 객체의 종류가 추가돼도 기존 코드 수정 필요 없음
    // 새로운 Factory를 만들어 대응이 가능함.
    // 하지만, Factory에서 생산하는 컴포넌트의 종류가 추가되는 경우, 모든 Factory에 컴포넌트 생성 메소드를 추가해야 함.
    // 추상 팩토리 객체는 호출되면 객체를 생성하는 역할만 수행하므로, 싱글톤을 적용하는 것이 좋다

    public class ShoesTest
    {
        public static void main(string[] args)
        {
            ShoesStore jpStore = new JPShoesStore();
            ShoesStore frStore = new FRShoesStore();

            Shoes shoes = jpStore.OrderShoes("blackShoes");

            Shoes newShoes = frStore.OrderShoes("blackShoes");
        }
    }

    // abstract factory
    #region abstract class : ShoesStore
    public abstract class ShoesStore
    {
        public Shoes OrderShoes(string name)
        {
            Shoes shoes;

            shoes = MakeShoes(name);

            shoes.Assembling();

            shoes.Prepare();
            shoes.Packing();

            return shoes;
        }

        protected abstract Shoes MakeShoes(string name);
    }
    #endregion

    // concreate factory (실제로 주문, 생산을 진행하는 클래스)
    #region ShoesStore class
    public class JPShoesStore : ShoesStore
    {
        protected override Shoes MakeShoes(string name)
        {
            Shoes shose = null;
            IShoesIngredientFactory shoesIngredientFactory = JPShoesIngredientFactory.GetInstance();

            if(name.Equals("blackShoes"))
            {
                shose = new BlackShoes(shoesIngredientFactory);
                shose.SetName("일본 스타일의 검은 신발");
            }
            else if(name.Equals("brownShoes"))
            {
                shose = new BrownShoes(shoesIngredientFactory);
                shose.SetName("일본 스타일의 갈색 신발");
            }

            return shose;
        }
    }

    public class FRShoesStore : ShoesStore
    {
        protected override Shoes MakeShoes(string name)
        {
            Shoes shose = null;
            IShoesIngredientFactory shoesIngredientFactory = FRShoesIngredientFactory.GetInstance();

            if (name.Equals("blackShoes"))
            {
                shose = new BlackShoes(shoesIngredientFactory);
                shose.SetName("프랑스 스타일의 검은 신발");
            }
            else if (name.Equals("brownShoes"))
            {
                shose = new BrownShoes(shoesIngredientFactory);
                shose.SetName("프랑스 스타일의 갈색 신발");
            }

            return shose;
        }
    }
    #endregion

    // product a (Product의 부품 중 하나)
    #region Bottom class
    public interface IBottom
    {
        string GetName();
    }

    public class RubberBottom : IBottom
    {
        public string GetName()
        {
            return "고무 밑창";
        }
    }

    public class PlasticAndRubberBottom : IBottom
    {
        public string GetName()
        {
            return "합성 고무 밑창";
        }
    }
    #endregion

    // product b (Product의 부품 중 하나)
    #region Leather class
    public interface ILeather
    {
        string GetName();
    }

    public class LeatherOfCows : ILeather
    {
        public string GetName()
        {
            return "소가죽";
        }
    }

    public class LeatherOfSheeps:ILeather
    {
        public string GetName()
        {
            return "양가죽";
        }
    }
    #endregion

    // Product 생산을 도와주는 IngredientFactory class
    #region ShoesIngredientFactory class
    public interface IShoesIngredientFactory
    {
        IBottom MakeBottm();
        ILeather MakeLeather();
        bool HasPattern();
    }

    public class JPShoesIngredientFactory : IShoesIngredientFactory
    {
        static JPShoesIngredientFactory instance = null;

        public static JPShoesIngredientFactory GetInstance()
        {
            if(instance == null)
                instance = new JPShoesIngredientFactory();

            return instance;
        }

        private JPShoesIngredientFactory() { }

        public bool HasPattern()
        {
            return false;
        }

        public IBottom MakeBottm()
        {
            return new RubberBottom();
        }

        public ILeather MakeLeather()
        {
            return new LeatherOfCows();
        }
    }

    public class FRShoesIngredientFactory : IShoesIngredientFactory
    {
        static FRShoesIngredientFactory instance = null;

        public static FRShoesIngredientFactory GetInstance()
        {
            if (instance == null)
                instance = new FRShoesIngredientFactory();

            return instance;
        }

        private FRShoesIngredientFactory() { }

        public bool HasPattern()
        {
            return true;
        }

        public IBottom MakeBottm()
        {
            return new PlasticAndRubberBottom();
        }

        public ILeather MakeLeather()
        {
            return new LeatherOfSheeps();
        }
    }
    #endregion

    // abstract product
    #region abstract class : Shoes
    public abstract class Shoes
    {
        protected string name;
        protected IBottom bottom;
        protected ILeather leather;
        protected bool hasPattern;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public abstract void Assembling();

        public void Prepare()
        {
            Console.WriteLine($"Preparing Shoes. . .");
        }
        public void Packing()
        {
            Console.WriteLine($"Packing Shoes. . . ");
        }
    }
    #endregion

    #region Shoes class
    public class BlackShoes : Shoes
    {
        IShoesIngredientFactory shoesIngredientFactory;

        public BlackShoes(IShoesIngredientFactory shoesIngredientFactory)
        {
            this.shoesIngredientFactory= shoesIngredientFactory;
        }

        public override void Assembling()
        {
            leather = this.shoesIngredientFactory.MakeLeather();
            bottom = this.shoesIngredientFactory.MakeBottm();
            hasPattern = this.shoesIngredientFactory.HasPattern();
        }
    }

    public class BrownShoes: Shoes
    {
        IShoesIngredientFactory shoesIngredientFactory;

        public BrownShoes(IShoesIngredientFactory shoesIngredientFactory)
        {
            this.shoesIngredientFactory = shoesIngredientFactory;
        }

        public override void Assembling()
        {
            leather = this.shoesIngredientFactory.MakeLeather();
            bottom = this.shoesIngredientFactory.MakeBottm();
            hasPattern = this.shoesIngredientFactory.HasPattern();
        }
    }
    #endregion
}
