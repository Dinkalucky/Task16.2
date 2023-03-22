using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task16._4
{
    public class Date
    {
        public DateTime date = new DateTime();
        public static int operator -(Date date1, Date date2)
        {
            return date1 - date2;
        }

        public static int operator +(Date date1, int days)
        {
            return date1 + days;
        }
    }
}
