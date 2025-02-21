using System;
using System.Text;

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
            Console.OutputEncoding = Encoding.UTF8;
            double xx = 1.23456;
            int ii = 19;

            string xx1 = $"{xx:f2}, {xx:p1}";
            string ii1= $"{ii:x} e {ii:c}";

            string Ola = "Ola pessoal!";
            string nomeIdade = "Eu sou o Simão \nTenho 19 anos\u0021";

            string x = "a" + 2;
            string conca1 = "abc" + x;

            int a= 3;
            int b= 2;

            string Inter = $"valor de x é {a}";
            string Interpol = $"{a} mais {b} é igual a {a+b}";


            Console.WriteLine(xx1);
            Console.WriteLine(ii1);
            Console.WriteLine(Ola);
            Console.WriteLine(nomeIdade);

            Console.WriteLine(x);
            Console.WriteLine(conca1);

            Console.WriteLine(Inter);
            Console.WriteLine(Interpol);

        }
    }
}
