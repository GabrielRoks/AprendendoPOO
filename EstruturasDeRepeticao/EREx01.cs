namespace EstruturasDeRepeticao
{
    internal class EREx01
    {
        public static void Identificacao()
        {
            Console.WriteLine("Exercício 01: Contar de 1 a 10.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public static void ExecutarComWhile()
        {
            Console.WriteLine("Estrutura while(true) { }");
            int contador = 0;
            Console.WriteLine("Contagem: ");
            while (contador < 10)
            {
                contador++;
                Console.Write(contador + "  ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            
        }
        public static void ExecutarComDoWhile()
        {
            Console.WriteLine("Estrutura do / while(true) { }");
            int contador = 0;
            Console.WriteLine("Contagem: ");
            do
            {
                contador++;
                Console.Write(contador + "  ");
            } while (contador < 10);
            Console.WriteLine("");
        }
        public static void ExecutarComFor()
        {
            int contador = 0;
            Console.WriteLine("");
            Console.WriteLine("Estrutura de repetição for(inicialização; teste; atualização) { }");
            Console.WriteLine("Contagem: ");
            for (contador = 1; contador <= 10; contador++)
            {
                Console.Write(contador + "  ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
