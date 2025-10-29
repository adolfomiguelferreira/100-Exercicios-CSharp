// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobreNome;

            Console.Write("Escreva o seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("Escreva o seu Sobrenome: ");
            sobreNome = Console.ReadLine();

            Console.WriteLine(string.Format("O seu Nome é {0} Sobrenome {1}.", nome, sobreNome));

            Console.ReadKey();
        }
    }
}

