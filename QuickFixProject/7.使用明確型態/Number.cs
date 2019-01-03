using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public static class Number
    {
        public static void DisplayOddNumber()
        {
            var cat = new List<int>
            {1, 2, 6, 7, 9};

            // This example display odd numbers.
            // Returns IEnumerable<T> (where T is int).
            var items = from item in cat
                        where (item % 2 == 1)
                        select item;

            // Each item is an int.
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
