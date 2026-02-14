using System;

namespace Introducao
{
    internal class Idade
    {
        public static void ExecutarIdade()
        {
            Console.Clear();
            Console.Write("Digite a sua idade em anos: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int idade) || idade < 0)
            {
                Console.WriteLine("Entrada inválida. Informe um número inteiro maior ou igual a zero.");
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            int meses = idade * 12;
            int dias = idade * 365; // considera ano com 365 dias

            Console.WriteLine($"\nVocê tem aproximadamente {meses} meses, ou {dias} dias de idade.");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
