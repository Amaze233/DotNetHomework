//编写面向对象程序实现长方形、正方形、三角形等形状的类。
//每个形状类都能计算面积、判断形状是否合法。
//请尝试合理使用接口/抽象类、属性来实现。

using System;
using System.Dynamic;

namespace homework3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Square square = new Square(6);
            Circle circle = new Circle(7);
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Area: {rectangle.Area}, ifShape: {rectangle.ifShape()}");
            Console.WriteLine($"Area: {square.Area}, ifShape: {square.ifShape()}");
            Console.WriteLine($"Area: {circle.Area}, ifShape: {circle.ifShape()}");
            Console.WriteLine($"Area: {triangle.Area}, ifShape: {triangle.ifShape()}");
        }

        interface Shape
        {
            double Area { get; }
            bool ifShape();
        }

        class Rectangle : Shape
        {
            public Rectangle(double len, double wid)
            {
                this.width = wid;
                this.length = len;
            }

            public double width { get; set; }
            public double length { get; set; }
            public virtual double Area
            {
                //求长方形的面积
                get => width * length;
            }

            public virtual bool ifShape()
            {
                //判断长方形是否合法：长宽大于0
                if (width >  0 && length > 0)
                {
                     return true;
                }
                return false;
                throw new NotImplementedException();
            }
        }

        class Square : Rectangle
        {
            public Square (double side) : base(side,side){}
            public double side { get; set; }
            //求正方形面积(运用父类长方形中的方法)
            public override double Area
            {
                get => side * side;
            }
            public override bool ifShape()
            {
                ////判断正方形是否合法：长宽大于0且长宽相等
                if (width >  0 && length > 0 && length == width)
                {
                    return true;
                }
                return false;
            }
        }

        class Circle : Shape
        {
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double radius{ get; set; }
            public double Area
            {
                //圆形求面积
                get => Math.PI * radius * radius;
            }

            public bool ifShape()
            {//判断圆形是否合法：半径
                if (radius > 0)
                {
                    return true;
                }

                return false;
                throw new NotImplementedException();
            }
        }

        class Triangle : Shape
        {
            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            public double side1 { get; set; }
            public double side2 { get; set; }
            public double side3 { get; set; }
            
            public double Area
            {
                get
                {
                    //三角形求面积
                    double sum = (side1 + side2 + side3) / 2;
                    return Math.Sqrt(sum * (sum - side1) * (sum - side2) * (sum - side3));
                }
            }

            public bool ifShape()
            {
                //判断三角形是否合法：各边大于0
                if (side1 <= 0 && side2 <= 0 && side3 <= 0)
                {
                    return false;
                }
                //判断三角形是否合法：任意两边之和大于第三边
                if (side1 + side2 <= side3 && side1 + side3 <= side2 && side2 + side3 <= side1)
                {
                    return false;
                }
                return true;
            }
        }
    }
}