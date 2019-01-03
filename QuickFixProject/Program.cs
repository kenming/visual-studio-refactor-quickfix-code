using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. 變更方法簽章
            //變更方法簽章.DisplayName("Jenny", "Wang");

            //2. 重新命名
            //重新命名.CalcArea(1.25);

            //3. 提煉方法
            //提煉方法.CalcArea(2.5);

            //4. 提煉方法
            //ExtractInterface();

            //5. 封裝欄位
            //EncapsulateField();

            //6. 移除暫存變數
            //Swap.swapit(12, 8);

            //7. 使用明確型態
            //Number.DisplayOddNumber();

            Console.WriteLine("\nPress any key to stop...");
            Console.ReadKey();
        }

        private static void ExtractInterface()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Drink(2);
            dog.Sleep();
        }

        private static void EncapsulateField()
        {
            Square square = new Square();
            square.side = 3.6;
            square.CalcSquare();
        }
    }
}
