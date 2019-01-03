using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public class Square
    {
        public double side;

        public void CalcSquare()
        {
            double square = side * side;
            Console.WriteLine("Square : " + side);
        }
    }
}
