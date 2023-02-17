using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    public class Polymorphism
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static string Add(string string1, string string2)
        {
            return $"{string1} {string2}";
        }
    }
}
