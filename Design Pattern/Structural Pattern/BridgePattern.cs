using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.BridgePattern
{
    // 기능을 처리하는 클래스와 구현을 담당하는 추상 클래스로 구별
    // 구현 뿐 아니라 추상화도 독립적으로 변경이 필요할 때 브리지 패턴을 사용함

    // 기존 시스템에 부수적인 새로운 기능들을 지속적으로 추가할 때 유용함

    // 분리된 추상 계층과 구현 계층은 독립적인 확장이 가능함
    // 런타임 시점에 어떤 방식으로 기능을 구현할 지 선택할 수 있음
    // 상세한 기능을 외부로부터 숨기는 은닉 효과도 얻을 수 있음

    // 코드 디자인 설계가 복잡해지는 단점

    // Abstract class : Commonality Analysis
    /// Shape와 Drawing 자체는 변하지 않음

    // Concrete class : Variability Analysis
    /// Shape의 concrete와 Drawing의 concrete는 변할 수 있음

    public class BridgeTest
    {
        public static void Main(string[] args)
        {
            Drawing drawingTool = AdvancedDrawing.GetInstance();

            Shape rectangle = new Rectangle.RectangleBuilder()
                .SetColor(new Red())
                .Build();

            rectangle.Draw();

            Shape circle = new Circle.CircleBuilder()
                .SetDrawingTool(drawingTool)
                .SetColor(new Blue())
                .SetRadius(10)
                .SetCenter(new Vector2(5, 5))
                .Build();

            circle.Draw();
        }
    }

    #region Vector
    public class Vector2
    {
        public int x;
        public int y;

        public Vector2(int x=0, int y=0)
        {
            this.x = x;
            this.y = y;
        }
    }
    #endregion

    #region Shape
    public abstract class Shape
    {
        protected Color color;

        public abstract void Draw();
        public virtual void SetColor(Color color)
        {
            this.color = color;
        }
    }

    public class Rectangle : Shape
    {
        Drawing drawingTool;

        Vector2[] point;

        Rectangle(RectangleBuilder rectangleBuilder)
        {
            drawingTool = rectangleBuilder.DrawingTool;
            point = rectangleBuilder.Points;
            color = rectangleBuilder.Color;
        }

        public class RectangleBuilder
        {
            Color color = null;

            Drawing drawingTool=null;

            Vector2[] points=null;

            public Drawing DrawingTool
            {
                get { return drawingTool; }
            }

            public Vector2[] Points
            {
                get { return points; }
            }

            public Color Color
            {
                get { return color; }
            }

            public RectangleBuilder() { }

            public RectangleBuilder SetDrawingTool(Drawing drawingTool)
            {
                this.drawingTool = drawingTool;
                return this;
            }

            public RectangleBuilder SetPoints(Vector2[] points)
            {
                this.points = points;
                return this;
            }

            public RectangleBuilder SetPoints(Vector2 a, Vector2 b, Vector2 c, Vector2 d)
            {
                this.points = new Vector2[4] { a, b, c, d };
                return this;
            }

            public RectangleBuilder SetColor(Color color)
            {
                this.color = color;
                return this;
            }

            public Rectangle Build()
            {
                if(color == null)
                    color = new Black();

                if (drawingTool == null)
                    drawingTool = DefaultDrawing.GetInstance();

                if (points == null)
                    points = new Vector2[4] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0), new Vector2(1, 1) };

                return new Rectangle(this);
            }
        }

        public override void Draw()
        {
            for(int i=0; i<point.Length; i++)
            {
                drawingTool.DrawLine(point[i%point.Length], point[(i+1)%point.Length], color);
            }
        }
    }

    public class Circle: Shape
    {
        Drawing drawingTool;

        Vector2 point;
        int radius; 

        Circle(CircleBuilder circleBuilder)
        {
            drawingTool = circleBuilder.DrawingTool;
            point = circleBuilder.Point;
            radius = circleBuilder.Radius;
        }

        public class CircleBuilder
        {
            Color color=null;

            Drawing drawingTool=null;

            Vector2 point = null;
            int radius = 0;

            public Drawing DrawingTool
            {
                get { return drawingTool; }
            }

            public Vector2 Point
            {
                get { return point; }
            }

            public int Radius
            {
                get { return radius; }
            }

            public Color Color
            {
                get { return color; }
            }

            public CircleBuilder() { }

            public CircleBuilder SetDrawingTool(Drawing drawingTool)
            {
                this.drawingTool = drawingTool;
                return this;
            }

            public CircleBuilder SetCenter(Vector2 point)
            {
                this.point = point;
                return this;
            }

            public CircleBuilder SetRadius(int radius)
            {
                this.radius = radius;
                return this;
            }

            public CircleBuilder SetColor(Color color)
            {
                this.color = color;
                return this;
            }

            public Circle Build()
            {
                if (color == null)
                    color = new Black();

                if (drawingTool == null)
                    drawingTool = DefaultDrawing.GetInstance();

                if(point == null)
                    point = new Vector2(0,0);

                if (radius == 0)
                    radius = 1;

                return new Circle(this);
            }

        }


        public override void Draw()
        {
            drawingTool.DrawCircle(point, radius, color);
        }
    }
    #endregion

    #region Drawing
    public abstract class Drawing
    {
        public abstract void DrawLine(Vector2 a, Vector2 b, Color color);
        public abstract void DrawCircle(Vector2 center, int r, Color color);
    }

    public class DefaultDrawing : Drawing
    {
        static readonly object instanceLock = new object();
        static DefaultDrawing instance;
        
        public static DefaultDrawing GetInstance()
        {
            lock(instanceLock)
            {
                if(instance == null)
                    instance= new DefaultDrawing();
            }

            return instance;
        }

        DefaultDrawing() { }
        
        public override void DrawCircle(Vector2 center, int r, Color color)
        {
            Console.WriteLine($"DrawCircle> center: {center}, r: {r}, color: {color.GetColorCode()}");
        }

        public override void DrawLine(Vector2 a, Vector2 b, Color color)
        {
            Console.WriteLine($"DrawCircle> a: {a}, b: {b}, color: {color.GetColorCode()}");
        }
    }

    public class AdvancedDrawing : Drawing
    {
        static readonly object instanceLock = new object();
        static AdvancedDrawing instance = new AdvancedDrawing();

        public static AdvancedDrawing GetInstance()
        {
            lock(instanceLock)
            {
                if(instance == null)
                {
                    instance = new AdvancedDrawing();
                }
            }

            return instance;
        }

        AdvancedDrawing() { }

        public override void DrawCircle(Vector2 center, int r, Color color)
        {
            Console.WriteLine($"Advanced DrawCircle> center: {center}, r: {r}, color: {color.GetColorCode()}");
        }

        public override void DrawLine(Vector2 a, Vector2 b, Color color)
        {
            Console.WriteLine($"Advanced DrawCircle> a: {a}, b: {b}, color: {color.GetColorCode()}");
        }
    }
    #endregion

    #region Color
    public abstract class Color
    {
        public abstract string GetColorCode();
    }

    public class Black : Color
    {
        public override string GetColorCode()
        {
            return "#000000";
        }
    }

    public class Red : Color
    {
        public override string GetColorCode()
        {
            return "#FF0000";
        }
    }

    public class Blue: Color
    {
        public override string GetColorCode()
        {
            return "#0000FF";
        }
    }

    public class Green: Color
    {
        public override string GetColorCode()
        {
            return "#00FF00";
        }
    }
    #endregion
}
