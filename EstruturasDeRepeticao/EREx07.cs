namespace EstruturasDeRepeticao
{
    internal class EREx07
    {
        public static void IdentificacaoEx07()
        {
            Console.WriteLine("Exercício 07: Exiba os números de 100 a 1 em ordem decrescente");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx07()
        {
            Console.WriteLine("Estrutura while(true) { }");
            int numero = 100;
            while (numero > 0)
            {
                Console.WriteLine(numero);
                numero--;
            }
        }
        public static void ExecutarComDoWhileEx07()
        {
            Console.WriteLine("Estrutura do / while(true) { }");
            int numero = 100;
            do
            {
                Console.WriteLine(numero);
                numero--;
            }
            while (numero > 0);
        }
        public static void ExecutarComForEx07()
        {
            Console.WriteLine("Estrutura for(true) { }");
            for (int numero = 100; numero > 0; numero--)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
