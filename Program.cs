using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNasceu;
            int anoAtual;
            int podeVotar;


            Console.WriteLine("Digite o ano em que você nasceu: ");
            anoNasceu = int.Parse(Console.ReadLine());

            anoAtual = DateTime.Now.Year;

            podeVotar = anoAtual - anoNasceu;

            if (podeVotar < 16)
            {
                Console.WriteLine("Você não pode votar esse ano");
            }

            else
            {
                Console.WriteLine("Você pode votar esse ano");
            }
        }
    }
}
