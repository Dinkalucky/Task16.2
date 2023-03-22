using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(5, 2, 4, 3);
            Block block2 = new Block(6,2,4,3);

            Console.WriteLine(block2.Equals(block1));
            Console.WriteLine("\nBlock 1:");
            Console.WriteLine(block1.ToString());
            Console.WriteLine("Block 2:");
            Console.WriteLine(block2.ToString());
            Console.ReadLine();
        }
    }
}
