using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public static class Swap
    {
        public static void swapit(int a, int b)
        {
            //swapping
            int x = a;
            int y = b;
            int temp = a;
            x = b;
            y = temp;

            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + x);
            Console.WriteLine("b=" + y);
        }        
    }
}
