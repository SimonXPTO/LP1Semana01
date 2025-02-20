using System;

namespace ManyStrings
{
    public class Program
    {
        /// <summary>
        /// Program starts here and presents myself with some string variables
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            string Ola = "Ola pessoal!";
            string nomeIdade = "Eu sou o Simão \nTenho 19 anos\u0021";
            string x = "a" + 2;
            string conca1 = "abc" + x;
            int a= 3;
            int b= 2;
            string Inter = $"valor de x é {a}";
            string Interpol = $"{a} mais {b} é igual a {a+b}";



            Console.WriteLine(Ola);
            Console.WriteLine(nomeIdade);
            Console.WriteLine(x);
            Console.WriteLine(conca1);
            Console.WriteLine(Inter);
            Console.WriteLine(Interpol);

        }
    }
}
