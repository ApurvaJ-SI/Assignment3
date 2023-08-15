using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    public interface IShape
    {
        void CalculateArea();

        void CalculatePerimeter();

    }

    class Circle : IShape
    {
        double Radius { get; set; }
        public void CalculateArea()
        {
            double area;
            Console.WriteLine("Area of Circle:");
            Console.WriteLine("Enter radius:");
            Radius = Convert.ToDouble(Console.ReadLine());
            area = 3.14 * Radius * Radius;
            Console.WriteLine($"Area of Circle is: {area}");
        }

        public void CalculatePerimeter()
        {
            double perimeter;
            perimeter = 2 * 3.14 * Radius;
            Console.WriteLine($"Perimeter of circle is: {perimeter}");
        }
    }

    class Triangle : IShape
    {
        double breadth { get; set; }
        double height { get; set; }
        public void CalculateArea()
        {
            double area;
            Console.WriteLine("Area of Triangle:");
            Console.WriteLine("Enter the breadth:");
            breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            height = Convert.ToDouble(Console.ReadLine());
            area = (breadth * height) / 2;
            Console.WriteLine($"Area of Traingle is: {area}");
        }

        public void CalculatePerimeter()
        {
            double perimeter;
            Console.WriteLine("Perimeter of Triangle:");
            Console.WriteLine("Enter side a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side c:");
            double c = Convert.ToDouble(Console.ReadLine());
            perimeter = a + b + c;
            Console.WriteLine($"Perimeter of triangle is: {perimeter}");
        }
    }

    class Rectangle : IShape
    {
        double length { get; set; }
        double breadth { get; set; }
        public void CalculateArea()
        {
            double area;
            Console.WriteLine("Area of Rectangle:");
            Console.WriteLine("Enter the length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            breadth = Convert.ToDouble(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine($"Area of Rectangle is: {area}");
        }

        public void CalculatePerimeter()
        {
            double perimeter;
            perimeter = 2 * (length + breadth);
            Console.WriteLine($"Perimeter of triangle is: {perimeter}");
        }
    }
}

    






