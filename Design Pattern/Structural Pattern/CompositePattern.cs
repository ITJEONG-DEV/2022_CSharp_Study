using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPattern.StructuralPattern.BridgePattern;

namespace DesignPattern.StructuralPattern.CompositePattern
{
    // 작은 클래스들을 상속과 합성을 이용해 더 큰 클래스를 생성하는 방법을 제공함

    // 독립적으로 개발한 클래스 라이브러리를 마치 하나인 양 사용할 수 있음
    // 여러 인터페이스를 합성하여 서로 다른 인터페이스들의 통일된 추상을 제공함

    // 중요한 포인트는 인터페이스나 구현을 복합하는 것이 아닌, 객체를 합성하는 방법을 제공한다는 것.
    // 런타임 단계에서 복합 방법이나 대상을 변경할 수 있다는 점에서 유연성을 갖음

    public class CompositeTest
    {
        public static void Main(string[] args)
        {
            Shape rectangle = new Rectangle.RectangleBuilder()
                .SetPoints(new Vector2(1, 1), new Vector2(2, 2), new Vector2(0, 0), new Vector2(0, 3))
                .Build();

            Shape circle = new Circle.CircleBuilder()
                .SetCenter(new Vector2(5, 5))
                .SetRadius(3)
                .Build();

            Shape circle2 = new Circle.CircleBuilder()
                .SetCenter(new Vector2(0, 0))
                .SetRadius(5)
                .Build();

            CompositeShape compositeShape = new CompositeShape();
            compositeShape.Add(rectangle);
            compositeShape.Add(circle);
            compositeShape.Add(circle2);

            compositeShape.SetColor(new Red());
            compositeShape.Draw();
        }
    }

    public class CompositeShape : Shape
    {
        List<Shape> childShapes = new List<Shape>();

        public override void Draw()
        {
            for(int i=0; i<childShapes.Count; i++)
            {
                childShapes[i].Draw();
            }
        }

        public override void SetColor(Color color)
        {
            for(int i=0; i<childShapes.Count;i++)
            {
                childShapes[i].SetColor(color);
            }
        }

        public void Add(Shape shape)
        {
            childShapes.Add(shape);
        }

        public void Remove(Shape shape)
        {
            childShapes.Remove(shape);
        }
    }
}
