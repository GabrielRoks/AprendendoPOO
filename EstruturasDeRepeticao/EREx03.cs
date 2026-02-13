namespace EstruturasDeRepeticao
{
    internal class EREx03
    {
        public static void IdentificacaoEx03()
        {
            Console.WriteLine("Exercício 03: Exiba os números pares de 1 a 20.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx03()
        {
            Console.WriteLine("Estrutura while(true) { }");
            int contador = 1;
            while(contador <= 20)
            {
                if (contador %  2 == 0)
                {
                    Console.Write($"{contador} é par.");
                    Console.WriteLine("");
                }
                contador++;
            }
        }
        public static void ExecutarComDoWhileEx03()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura do / while(true) { }");
            int contador = 1;
            do
            {
                if (contador % 2 == 0)
                {
                    Console.Write($"{contador} é par.");
                    Console.WriteLine("");
                }
                contador++;
            }
            while (contador <= 20);
        }
        public static void ExecutarComForEx03()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura for() { }");
            int contador = 1;
            for (contador = 1; contador <= 20; contador++)
            {
                if(contador % 2 == 0)
                {
                    Console.Write($"{contador} é par.");
                    Console.WriteLine("");
                }
            }

        }
    }
}
