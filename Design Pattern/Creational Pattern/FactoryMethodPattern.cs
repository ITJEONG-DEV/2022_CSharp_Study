using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.FactoryMethodPattern
{
    // 객체 생성을 위한 인터페이스를 정의함 (MakeShoes)
    // 어떤 클래스의 인스턴스를 생성하는지 결정하는 것은 자식 클래스가 구현

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


    // creator class
    #region abstract class : ShoesStore
    public abstract class ShoesStore
    {
        public Shoes OrderShoes(string name)
        {
            Shoes shoes;

            shoes = MakeShoes(name);

            shoes.Prepare();
            shoes.Packing();

            return shoes;
        }

        protected abstract Shoes MakeShoes(string name);
    }
    #endregion

    #region ShoesStore class
    public class JPShoesStore: ShoesStore
    {
        protected override Shoes MakeShoes(string name)
        {
            if(name.Equals("blackShoes"))
            {
                return new JPStyleBlackShoes();
            }
            else if(name.Equals("brownShoes"))
                    {
                return new JPStyleBrownkShoes();
            }
            else
            {
                return null;
            }
        }
    }

    public class FRShoesStore: ShoesStore
    {
        protected override Shoes MakeShoes(string name)
        {
            if (name.Equals("blackShoes"))
            {
                return new FRStyleBlackShoes();
            }
            else if (name.Equals("brownShoes"))
            {
                return new FRStyleBrownShoes();
            }
            else
            {
                return null;
            }
        }
    }
    #endregion


    // product class
    #region abstract class : Shoes
    public abstract class Shoes
    {
        protected string name;
        protected string bottom;
        protected string leather;
        protected bool hasPattern;

        public String getName()
        {
            return name;
        }

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
    public class JPStyleBlackShoes : Shoes
    {
        public JPStyleBlackShoes()
        {
            this.name = "일본 스타일의 검은 구두";
            this.bottom = "검은색 고무 밑창";
            this.leather = "소가죽";
            hasPattern = false;
        }
    }

    public class FRStyleBlackShoes : Shoes
    {
        public FRStyleBlackShoes()
        {
            this.name = "프랑스 스타일의 검은 구두";
            this.bottom = "옅은 검은색의 플라스틱과 고무 혼용";
            this.leather = "양가죽";
            this.hasPattern = true;
        }
    }

    public class JPStyleBrownkShoes : Shoes
    {
        public JPStyleBrownkShoes()
        {
            this.name = "일본 스타일의 갈색 구두";
            this.bottom = "진 갈색 고무 밑창";
            this.leather = "소가죽";
            hasPattern = false;
        }
    }

    public class FRStyleBrownShoes : Shoes
    {
        public FRStyleBrownShoes()
        {
            this.name = "프랑스 스타일의 갈색 구두";
            this.bottom = "밝은 갈색의 플라스틱과 고무 혼용";
            this.leather = "양가죽";
            this.hasPattern = true;
        }
    }
    #endregion
}
