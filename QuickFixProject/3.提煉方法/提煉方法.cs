using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public static class 提煉方法
    {
        public static void CalcArea(double radius)
        {
            double Area = radius * radius;

            Console.WriteLine("Area : " + Area);
        }
    }
}
