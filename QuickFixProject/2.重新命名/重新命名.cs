using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public static class 重新命名
    {
        public static void CalcArea(double r)
        {
            double Area = r * r;

            Console.WriteLine("Area : " + Area);
        }
    }
}
