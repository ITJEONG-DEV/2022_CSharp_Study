using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.FlyweightPattern
{
    // 어떤 클래스의 인스턴스 한 개만 가지고 여러 개의 가상 인스턴스를 제공하고 싶을 때 사용
    // 인스턴스를 공유시켜 new 연산자를 통한 메모리 낭비를 줄일 수 있음

    // intrinsic한 객체: 장소나 상황에 의존하지 않아 값이 고정되어 공유할 수 있는 객체
    // extrinsic한 객체: 장소나 상황에 의존하여 매번 값이 바뀌어 공유할 수 없는 객체

    // 어플리케이션에 의해 생성되는 객체의 수가 많아 저장 비용이 높아질 때
    // 생성된 객체가 메모리에 오랫동안 상주하여 사용되는 횟수가 많을 때
    // 공통적인 인스턴스를 많이 생성하는 로직이 포함된 경우
    // 임베디드와 같이 메모리를 최소한으로 사용해야 하는 경우

    // 어플리케이션에서 사용하는 메모리를 줄일 수 있음
    // 코드의 복잡도가 증가함

    // 나무 렌더링을 완료하고 더 이상 나무를 생성할 일이 없다면 TreeModelFactory에 잔조해있는 Flyweight Pool을 비워야 함
    // 비우지 않으면 TreeModel 데이터가 메모리에 잔존하게 됨.

    class Memory
    {
        public static long size = 0;
        public static void Print()
        {
            Console.WriteLine($"메모리 사용량: {Memory.size} MB");
        }
    }

    // ConcreteFlyweight
    class TreeModel
    {
        long objSize = 90;

        string type;

        object mesh;
        object texture;

        public string Type
        {
            get { return type; }
        }

        public object Mesh
        {
            get { return mesh; }
        }

        public object Texture
        {
            get { return texture; }
        }

        public TreeModel(string type, object mesh, object texture)
        {
            this.type = type;
            this.mesh = mesh;
            this.texture = texture;

            Memory.size += this.objSize;
        }
    }

    // UnsharedConcreteFlyweight
    class Tree
    {
        long objSize = 10;

        float x;
        float y;

        TreeModel mode;

        public float X
        {
            get { return x; }
        }

        public float Y
        {
            get { return y; }
        }

        public Tree(TreeModel model, float x, float y)
        {
            this.mode = model;
            this.x = x;
            this.y = y;

            Memory.size += this.objSize;
        }
    }

    // FlyweightFactory
    class TreeModelFactory
    {
        static Dictionary<string, TreeModel> cache = new Dictionary<string, TreeModel>();

        public static TreeModel GetInstance(string key)
        {
            if(cache.ContainsKey(key)) return cache[key];

            TreeModel model = new TreeModel(key, new object(), new object());
            Console.WriteLine($"Create new TreeModel. Key: {key}");

            cache[key] = model;

            return model;
        }
    }

    class Terrain
    {
        static readonly int CANVAS_SIZE = 10000;

        public void Render(string type, object mesh, object texture, float x, float y)
        {
            TreeModel model = TreeModelFactory.GetInstance(type);

            Tree tree = new Tree(model, x, y);

            Console.WriteLine($"({tree.X}, {tree.Y})에 {type} 나무 생성");
        }
    }
}
