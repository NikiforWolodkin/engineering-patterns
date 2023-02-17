using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    public class Math
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

    public class Shape
    {
        public virtual void DrawShape() { }
    }

    public class Triangle : Shape
    { 
        public override void DrawShape()
        {
            Console.WriteLine(" # ");
            Console.WriteLine("###");
        }
    }

    public class Square : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("###");
            Console.WriteLine("# #");
            Console.WriteLine("###");
        }
    }

    public class Star : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine(" # ");
            Console.WriteLine("# #");
            Console.WriteLine(" # ");
        }
    }
}
