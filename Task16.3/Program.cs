using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var flat = new Flat(20000);
            var house1 = new House(100000, 5,flat);
            var house2 = (House)house1.Clone();
            house2.Area = 50000;
            house2.NumberOfRooms = 10;
            Console.WriteLine($"Площа першого будинку: {house1.Area} кв.м\n" +
                              $"Кількість кімнат: {house1.NumberOfRooms}");
            Console.WriteLine($"Площа другого будинку: {house2.Area} кв.м\n" +
                              $"Кількість кімнат: {house2.NumberOfRooms}");
            Console.WriteLine($"Площа квартири: {house2.MyFlat.Area} кв.м\n");
            Console.ReadLine();
        }
    }
}
