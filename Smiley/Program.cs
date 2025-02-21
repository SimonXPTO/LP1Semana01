using System;
using System.Text;

namespace Smiley
{
    public class Program
    {
        /// <summary>
        /// Program converts every Hexadecimal Number to a Unicode Character
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            Console.WriteLine("Insera um codigo Hexadecimal");

            string x = Console.ReadLine();
            int b = int.Parse(x, System.Globalization.NumberStyles.HexNumber);
            
            string c = char.ConvertFromUtf32(b);
            Console.WriteLine($"Unicode:{c}");



        }
    }
}
