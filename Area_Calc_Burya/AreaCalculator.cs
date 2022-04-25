using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calc_Burya
{
    public static class AreaCalculator
    {

        public static double GetSquareArea(int side)
        {
            return side * side;
        }

        public static double GetSquareArea(string side)
        {
            try
            {
                Dictionary<string, int> num = new Dictionary<string, int>();
                num.Add("one", 1);
                num.Add("two", 2);
                num.Add("three", 3);
                num.Add("four", 4);
                num.Add("five", 5);
                num.Add("six", 6);
                num.Add("seven", 7);
                num.Add("eight", 8);
                num.Add("nine", 9);
                num.Add("ten", 10);

                return num[side] * 2;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static double GetRectangleArea(int width, int height)
        {
            return width * height;
        }
        public static double GetTriangleArea(int Base, int height)
        {
            return (Base * height) / 2;
        }
        public static double GetParallelogramArea(int Base, int height)
        {
            return Base * height;
        }
        public static double GetCircleRadius(int diameter)
        {
            return diameter / 2;
        }
        public static double GetCircleDiameter(int radius)
        {
            return radius * 2;
        }

    }
}
