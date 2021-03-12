//随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。
using System;
namespace hoemwork3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += Factory.shapeMaker().Area;
            }
            Console.WriteLine($"the sum of area is : {sum}");
        }

        class Factory
        {
            public static Shape shapeMaker()
            {
                int rand = random.Next(4);
                switch (rand)
                {
                    case 0:
                        return new Rectangle(random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 1:
                        return new Square(random.Next(1, 10));
                        break;
                    case 2:
                         return new Circle(random.Next(1, 10));
                        break;
                    default:
                        int a = random.Next(1, 10), b = random.Next(2, 10);
                        int c = a + b - 1;
                        return new Triangle(a, b, c);
                        break;
                }
            }
            private static readonly Random random = new Random();
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