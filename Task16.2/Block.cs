using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._2
{
    public class Block
    {
        public int side1;
        private int side2;
        private int side3;
        private int side4;

        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Block);
        }

        public bool Equals(Block block)
        {
            return side1 == block.side1 &&
                   side2 == block.side2 &&
                   side3 == block.side3 &&
                   side4 == block.side4;
        }

        public override string ToString()
        {
            return $"Сторона 1 = {side1}\n" +
                   $"Сторона 2 = {side2}\n" +
                   $"Сторона 3 = {side3}\n" +
                   $"Сторона 4 = {side4}\n";
        }
    }
}
