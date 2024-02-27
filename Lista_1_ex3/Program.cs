using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu sexo? (digite M ou F)");
            char n = char.Parse(Console.ReadLine());
            if (n == 'm' || n == 'f' || n == 'M' || n == 'F')
                Console.WriteLine("sexo valido");
            else Console.WriteLine("sexo não valido");
        }
    }
}
