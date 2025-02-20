using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insera um numero inteiro.");

            string str = Console.ReadLine();
            int x = int.Parse(str); //Conversão de str para int

            Console.WriteLine("Insera um numero real.");

            string str1 = Console.ReadLine();
            float y = float.Parse(str1);


        }
    }
}
