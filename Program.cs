namespace Assignment3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create first circle
            Console.Write("Enter the radius of the first circle: ");
            double radius1 = Convert.ToDouble(Console.ReadLine());
            Circle circle1 = new Circle(radius1);

            //create second circle
            Console.Write("Enter the radius of the second circle: ");
            double radius2 = Convert.ToDouble(Console.ReadLine());
            Circle circle2 = new Circle(radius2);

            //display circles 1 and 2
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);

            //perform operations for total area and difference 
            double totalArea = circle1 + circle2;
            double areaDifference = circle1 - circle2;

            Console.WriteLine($"The total area of the two circles is: {totalArea:F2}");
            Console.WriteLine($"The difference in the areas of the two circles is: {areaDifference:F2}");
        }
        class Circle
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            //property to calculate the area of the circle
            public double Area => Math.PI * Math.Pow(Radius, 2);

            //overload the "+" operator
            public static double operator +(Circle c1, Circle c2)
            {
                return c1.Area + c2.Area;
            }

            //overload the "-" operator
            public static double operator -(Circle c1, Circle c2)
            {
                return Math.Abs(c1.Area - c2.Area);
            }

            public override string ToString()
            {
                return $"Circle with Radius: {Radius}, Area: {Area:F2}";
            }
        }
    }
}
