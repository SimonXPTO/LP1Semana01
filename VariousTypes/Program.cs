using System;

namespace VariousTypes
{
    public class Program
    {

        private static void Main(string[] args)
        {
            int firstNumber = 4;
            int secondNumber = 1;
            char firstChar = '\u00A9';
            char secondChar = '\uF0A9';
            float firstfloat = 1.1234f;
            double firstdouble = 5.99;
            long firstlong=8354610239563L;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            Console.WriteLine(firstdouble);
            Console.WriteLine(firstfloat);
            Console.WriteLine(firstlong);
        }
    }
}
