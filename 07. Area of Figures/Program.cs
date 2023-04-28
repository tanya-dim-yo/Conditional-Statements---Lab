using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areaSquare = a * a;
                Console.WriteLine("{0:f3}", areaSquare);
            }
            else if (figure == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double areaRectangle = x * y;
                Console.WriteLine("{0:f3}", areaRectangle);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * (r * r);
                Console.WriteLine("{0:f3}", areaCircle);
            }
            else if (figure == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areaTriangle = (c * h) / 2;
                Console.WriteLine("{0:f3}", areaTriangle);
            }
        }
    }
}