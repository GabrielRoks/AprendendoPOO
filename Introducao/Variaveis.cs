using System;

namespace Introducao
{
    internal class Variaveis
    {
        public static void ExecutarVariaveis()
        {
            Console.Clear();
            Console.WriteLine("Escreva um algoritmo que armazene um valor em uma variável A e outro em" +
                "uma variável B. Em seguida, utilizando apenas atribuições entre variáveis, troque os conteúdos" +
                "das varáveis, fazendo o valor que está em A passe para B e vice-versa. Ao final, escreva" +
                "os valores que ficaram armazenados nas variáveis");

            Console.WriteLine("\nDigite um valor para a variável A: ");
            string variavelA = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Digite um valor para a variável B: ");
            string variavelB = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("\nValores antes da troca:");
            Console.WriteLine($"A = {variavelA}");
            Console.WriteLine($"B = {variavelB}");

            // Troca utilizando apenas atribuições entre variáveis (variável temporária)
            string auxiliar = variavelA;
            variavelA = variavelB;
            variavelB = auxiliar;

            Console.WriteLine("\nValores após a troca:");
            Console.WriteLine($"A = {variavelA}");
            Console.WriteLine($"B = {variavelB}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
