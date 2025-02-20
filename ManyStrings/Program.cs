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
            Console.WriteLine(Ola);
            Console.WriteLine(nomeIdade);
        }
    }
}
