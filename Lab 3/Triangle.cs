using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Triangle
    {
        public bool IsIsosceles(int side1, int side2, int side3)
        {
            // An isosceles triangle has two sides equal
            return side1 == side2 || side2 == side3 || side1 == side3;
        }
    }

}
