using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point point1 = new Point(11, 5, 10);
            Point point2 = new Point(10, 2, 1);

            Console.WriteLine($"Координати першої точки: ({point1.X},{point1.Y},{point1.Z})");
            Console.WriteLine($"Координати другої точки: ({point2.X},{point2.Y},{point2.Z})");
            Console.WriteLine($"Координати третьої точки: ({(point1+point2).X},{(point1 + point2).Y},{(point1 + point2).Z})");
            Console.ReadLine();
        }
    }
}
