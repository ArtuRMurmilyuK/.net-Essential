using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Classes
{
    internal class Rectangle(double side1, double side2)
    {
        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * side1 + 2 * side2;
        }
    }
}
