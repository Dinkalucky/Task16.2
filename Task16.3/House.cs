using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task16._3
{
    public class Flat
    {
        private int area;

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public Flat(int area)
        {
            Area = area;
        }
    }
    public class House
    {
        private int area;
        private int numberOfRooms;
        public Flat MyFlat { get; set; }

        public int Area
        {
            get { return area;}
            set { area = value; }
        }
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }

        public House(int area, int numberOfRooms, Flat flat)
        {
            Area = area;
            NumberOfRooms = numberOfRooms;
            MyFlat = flat;
        }

        public object Clone()
        {
            return new House(Area, NumberOfRooms, new Flat(MyFlat.Area));
        }
    }
}
