using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public class Dog
    {        
        public void Eat()
        {
            Console.WriteLine("狗狗在吃飯...。");
        }

        public void Drink(int bowl)
        {
            Console.WriteLine("狗狗喝了 " + bowl + " 碗水");
        }

        public int Sleep()
        {
            int hour = 8;
            Console.WriteLine("狗狗睡了 " + hour + " 小時");
            return hour;
        }
    }
}
