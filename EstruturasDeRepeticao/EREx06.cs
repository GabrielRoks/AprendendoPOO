namespace EstruturasDeRepeticao
{
    internal class EREx06
    {
        public static void IdentificacaoEx06()
        {
            Console.WriteLine("Exercício 06: Exiba os mútiplos de 5 no intervalo de 1 a 50");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx06()
        {
            Console.WriteLine("Estrutura while(true) { }");
            int numero = 1;
            while(numero <= 50)
            {
                if (numero % 5 == 0)
                {
                    Console.WriteLine($"{numero} é multiplo de 5");
                }
                numero++;
            }
        }
        public static void ExecutarComDoWhileEx06()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura do / while(true) { }");
            int numero = 1;
            do
            {
                if (numero % 5 == 0)
                {
                    Console.WriteLine($"{numero} é multiplo de 5");
                }
                numero++;
            }
            while (numero <= 50);
        }
        public static void ExecutarComForEx06()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura for () { }");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} é multiplo de 5");
                }
            }
        }
    }
}
