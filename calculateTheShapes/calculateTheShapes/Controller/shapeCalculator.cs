using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculateTheShapes.ShapeModel;

namespace calculateTheShapes.Controller
{
    class shapeCalculator
    {
        public static void Triangle()
        {
            try
            {
                Console.Write("Enter the value of a: ");
                ContextModel.triangle.a = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                ContextModel.triangle.b = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of c: ");
                ContextModel.triangle.c = double.Parse(Console.ReadLine());

                if (ContextModel.triangle.a < 0 || ContextModel.triangle.b < 0 || ContextModel.triangle.c < 0)
                {
                    Console.WriteLine("\nThe value should be positive!");
                }
                else
                {
                    ContextModel.triangle.s = (ContextModel.triangle.a + ContextModel.triangle.b + ContextModel.triangle.c) / 2;
                    ContextModel.triangle.area = Math.Sqrt(ContextModel.triangle.s * (ContextModel.triangle.s - ContextModel.triangle.a) * (ContextModel.triangle.s - ContextModel.triangle.b) * (ContextModel.triangle.s - ContextModel.triangle.c));
                    if (double.NaN.Equals(ContextModel.triangle.area))
                    {
                        Console.WriteLine("\nError!");
                    }
                    else
                    {
                        Console.WriteLine("\nThe area of triangle is " + ContextModel.triangle.area);
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Not an integer!");
            }
            Console.ReadLine();
        }
        public static void Square()
        {
            try 
            { 
                Console.Write("Enter value: ");
                ContextModel.square.s = double.Parse(Console.ReadLine());
                if (ContextModel.square.s < 0)
                {
                    Console.WriteLine("\nThe value should be positive!");
                }
                else 
                {
                    ContextModel.square.area = ContextModel.square.s * ContextModel.square.s;
                    Console.WriteLine("\nThe area of square is " + ContextModel.square.area);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Not an integer!");
            }
            Console.ReadLine();
        }
        public static void Rectangle()
        {
            try
            {
                Console.Write("Enter length: ");
                ContextModel.rectangle.l = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                ContextModel.rectangle.w = double.Parse(Console.ReadLine());
                if (ContextModel.rectangle.w < 0 || ContextModel.rectangle.l < 0)
                {
                    Console.WriteLine("\nThe value of width or length should be positive!");
                }
                else
                {
                    ContextModel.rectangle.area = ContextModel.rectangle.l * ContextModel.rectangle.w;
                    Console.WriteLine("\nThe area of rectangle is " + ContextModel.rectangle.area);
                }
                
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Not an integer!");
            }
            Console.ReadLine();
        }
        public static void Circle()
        {
            try
            {
                Console.Write("Enter radius: ");
                ContextModel.circle.r = double.Parse(Console.ReadLine());

                if(ContextModel.circle.r < 0)
                {
                    Console.WriteLine("\nThe value of radius should be positive ");
                }
                else 
                {
                    ContextModel.circle.area = (ContextModel.circle.r * ContextModel.circle.r) * Math.PI;
                    Console.WriteLine("\nThe area of circle is " + ContextModel.circle.area);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Not an integer!");
            }
            Console.ReadLine();
        }
    }
}
