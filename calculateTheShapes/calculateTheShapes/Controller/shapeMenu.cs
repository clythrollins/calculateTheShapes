using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateTheShapes.Controller
{
    class shapeMenu
    {
        public string input = Console.ReadLine();
        public static void shapemenu()
        {
            Console.Clear();
            ArrayList shapes = new ArrayList();
            shapes.Add("[1] Triangle");
            shapes.Add("[2] Square");
            shapes.Add("[3] Rectangle");
            shapes.Add("[4] Circle");

            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }
            Console.Write("\nChoose a shape: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                shapeCalculator.Triangle();
                shapemenu();
            }
            if (input == "2")
            {
                Console.Clear();
                shapeCalculator.Square();
                shapemenu();
            }
            if (input == "3")
            {
                Console.Clear();
                shapeCalculator.Rectangle();
                shapemenu();
            }
            if (input == "4")
            {
                Console.Clear();
                shapeCalculator.Circle();
                shapemenu();
            }
            else
            {
                Console.WriteLine("Please input correct menu option!");
                shapemenu();
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}
