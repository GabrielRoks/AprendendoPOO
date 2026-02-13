namespace EstruturasDeRepeticao
{
    internal class EREx08
    {
        public static void IdentificacaoEx08()
        {
            Console.WriteLine("Exercício 08: Solicite dois número e exiba os números no intervalo entre eles");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx08()
        {
            Console.WriteLine("Estrutura while(true) { }");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            while (menor <= maior)
            {
                Console.WriteLine(menor);
                menor++;
            }
        }
        public static void ExecutarComDoWhileEx08()
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
                Console.WriteLine(menor);
                menor++;
            }
            while (menor <= maior);
        }
        public static void ExecutarComForEx08()
        {
            Console.WriteLine("Estrutura for(true) { }");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            for (int i = menor; i <= maior; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
