namespace EstruturasDeRepeticao
{
    internal class EREx09
    {
        public static void IdentificacaoEx09()
        {
            Console.WriteLine("Exercício 09: Solicite dois números, determine o maior e o menor, " +
                "e exiba os números neste intervalo em ordem decrescente.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx09()
        {
            Console.WriteLine("Estrutura while(true) { }");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            while (maior >= menor)
            {
                Console.WriteLine(maior);
                maior--;
            }
        }
        public static void ExecutarComDoWhileEx09()
        {
            Console.WriteLine("Estrutura do / while(true) { }");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            do
            {
                Console.WriteLine(maior);
                maior--;
            }
            while (maior >= menor);
        }
        public static void ExecutarComForEx09()
        {
            Console.WriteLine("Estrutura for(true) { }");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            for (int i = maior; i >= menor; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
