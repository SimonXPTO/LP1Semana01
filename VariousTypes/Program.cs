using System;

namespace VariousTypes
{
    public class Program
    {
        
        /// <summary>
        /// Program starts here.
        /// Multiple literais variables
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int firstNumber = 4;
            int secondNumber = 1;
            char firstChar = '\u00A9';
            char secondChar = '\uF0A9';
            float firstfloat = 1.1234f;
            double firstdouble = 5.99;
            long firstlong=8354610239563L;
            bool condition= 5<3;
            bool tCond=14.33<15.33;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            Console.WriteLine(firstdouble);
            Console.WriteLine(firstfloat);
            Console.WriteLine(firstlong);
            Console.WriteLine(condition);
            Console.WriteLine(tCond);
        }
    }
}
