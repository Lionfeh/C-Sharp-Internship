using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class Square
    {
        //Find square of circle
        public static double Circle(object radius)
        {
            if (!IsNumber(radius)) return -1;
            double rad = Convert.ToDouble(radius);
            double PI = 3.141_592_653;
            if (!IsFigure(rad)) return -1;
            return PI * rad * rad;
        }
        
        //Find square of triangle
        public static double Triangle(object firstSide, object secondSide, object thirdSide)
        {
            if (!(IsNumber(firstSide) && IsNumber(secondSide) && IsNumber(thirdSide))) return -1;
            double a = Convert.ToDouble(firstSide);
            double b = Convert.ToDouble(secondSide);
            double c = Convert.ToDouble(thirdSide);
            if (!IsFigure(a, b, c)) return -1;
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //Chek is it a right triangle
        public static bool IsRightTriangle(object firstSide, object secondSide, object thirdSide)
        {
            if (!(IsNumber(firstSide) && IsNumber(secondSide) && IsNumber(thirdSide))) return false;
            double a = Convert.ToDouble(firstSide);
            double b = Convert.ToDouble(secondSide);
            double c = Convert.ToDouble(thirdSide);
            if (!IsFigure(a, b, c)) return false;
            return a * a == (b * b) + (c * c) || b * b == (a * a) + (c * c) || c * c == (a * a) + (b * b);
        }

        //Find square of Unknown figure
        public static double UnknownSquare(object firstSide, object secondSide = null, object thirdSide = null)
        {
            if (secondSide == null) return Circle(firstSide);
            return Triangle(firstSide, secondSide, thirdSide);
        }

        //Chek is it figue
        private static bool IsFigure(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b && a > 0 && b > 0 && c > 0) return true;
            return false;
        }
        private static bool IsFigure(double a)
        {
            if (a > 0) return true;
            return false;
        }

        //Chek is object a number
        private static bool IsNumber(object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }
    }
}
