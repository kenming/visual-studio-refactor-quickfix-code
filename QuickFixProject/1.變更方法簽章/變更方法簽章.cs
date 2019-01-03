using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata.refactor.quickfix
{
    public static class 變更方法簽章
    {
        public static void DisplayName(string firstName, string lastName)
        {
            ChangeName(firstName, lastName);
        }

        private static void ChangeName(string firstName, string lastName)
        {
            Console.WriteLine("FirstName :" + firstName);
            Console.WriteLine("LastName :" + lastName);
        }
    }
}
