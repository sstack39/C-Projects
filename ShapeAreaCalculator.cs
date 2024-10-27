


using System.Globalization;

namespace ShapeAreaCalculator
{

    internal class Program
    {
        public static List<Shape>shapes = new List<Shape>();

        static void Main(string[] args)
        {
            shapes.Add(new Circle(7, 4));
            shapes.Add(new Square(4));
            shapes.Add(new Triangle(5,3.5,3,4,2));
            shapes.Add(new Rectangle(2, 3));
            shapes.Add(new Parallelogram(4, 6, 8));

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].ShapeName);
                Console.WriteLine("Area");
                Console.WriteLine(shapes[i].calculateArea());
                Console.WriteLine("Perimeter");
                Console.WriteLine(shapes[i].calculatePerimeter());
              
            }
            Console.ReadLine();
        }    // Abstract Shape class
        public abstract class Shape
        {
            // Abstract methods to calculate area and perimeter
            public abstract double calculateArea();
            public abstract double calculatePerimeter();
            private string shapeName; 
            private double width;
            private double height;

            public double Width
            {
                get { return width; }
                set { width = value; }
            }
            public double Height 
            { 
                get { return height; } 
                set { height = value; }
            }
            public string ShapeName
            {
                get { return shapeName; }
                set { shapeName = value; }
            }
        }

        // Circle subclass
        class Circle : Shape
        {
            private double radius;


            // Constructor
            public Circle(double width, double height)
            {
                this.radius = width / 2;
                this.ShapeName = "Circle";
            }

            // Override abstract methods

            public override double calculateArea()
            {
                return Math.PI * radius * radius;
            }


            public override double calculatePerimeter()
            {
                return 2 * Math.PI * radius;
            }
        }

        // Rectangle subclass
        class Rectangle : Shape
        {
            

            // Constructor
            public Rectangle(double length, double width)
            {
                this.Height = length;
                this.Width = width;
                this.ShapeName = "Rectangle";
            }

            // Override abstract methods

            public override double calculateArea()
            {
                return Height * Width;
            }


            public override double calculatePerimeter()
            {
                return 2 * (Height + Width);
            }
        }
        // Triangle subclass
        class Triangle : Shape
        {
            private double b;
            private double s1;
            private double s2;
            private double s3;

            // Constructor
            public Triangle(double h, double b, double s1, double s2, double s3)
            {
                this.Height = h;
                this.b = b;
                this.s1 = s1;
                this.s2 = s2;
                this.s3 = s3;
                this.ShapeName = "Triangle";
            }

            // Override abstract methods

            public override double calculateArea()
            {
                return .5 * Height * b;
            }


            public override double calculatePerimeter()
            {
                return (s1 + s2 + s3);
            }
        }
        // Square subclass
        class Square : Shape
        {
            private double side;


            // Constructor
            public Square(double side)
            {
                this.side = side;
                this.ShapeName = "Square";

            }

            // Override abstract methods

            public override double calculateArea()
            {
                return Math.Pow(side, 2);
            }


            public override double calculatePerimeter()
            {
                return 4 * side;
            }
        }
        // Parallelogram subclass
        class Parallelogram : Shape
        {
            private double side;
            private double b;
            

            // Constructor
            public Parallelogram(double side, double b, double h)
            {
                this.side = side;
                this.b = b;
                this.Height = h;
                this.ShapeName = "Parallelogram";
            }

            // Override abstract methods

            public override double calculateArea()
            {
                return b * Height;
            }


            public override double calculatePerimeter()
            {
                return 2 * (side + b);
            }
        }

    }
}





