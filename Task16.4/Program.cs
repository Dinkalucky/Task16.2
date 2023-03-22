using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            Date date2 = new Date();

            date1.date = DateTime.Now;
            date2.date = new DateTime(2023,03,20);
            Console.WriteLine((date1.date - date2.date).Days);
            Console.WriteLine((date1.date.Day + 10));
            Console.ReadLine();
        }
    }
}
