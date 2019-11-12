using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5._2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 12);
            Rectangle rectangle = new Rectangle(22, 15);
            Square square = new Square(15);

            Shape[] shapes = new Shape[3];
            shapes[0] = triangle;
            shapes[1] = rectangle;
            shapes[2] = square;

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CallculateSurface());
            }

            Console.ReadLine();      
        }
    }
}
