﻿using Curse;

namespace Curse
{
    class Program
    {
        static void Main(string[] srgs)
        {
            Aluguel[] quartos = new Aluguel[10];

            Console.WriteLine("Quantos aluguéis serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do " + i + "° aluguel: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Aluguel(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }

        }
    }
}
