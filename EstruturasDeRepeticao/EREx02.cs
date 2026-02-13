namespace EstruturasDeRepeticao
{
    internal class EREx02
    {
        public static void IdentificacaoEx02()
        {
            Console.WriteLine("Exercício 02: Some de 1 a 50 e exiba a soma.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx02()
        {
            Console.WriteLine("Estrutura while(true) { }");
            int contador = 1;
            int soma = 0;
            while (contador <= 50)
            {
                soma += contador;
                contador++;
            }
            Console.Write($"A soma entre os números de 1 a 50 é: {soma}");
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public static void ExecutarComDoWhileEx02()
        {
            Console.WriteLine("Estrutura do / while(true) { }");
            int contador = 1;
            int soma = 0;
            do
            {
                soma += contador;
                contador++;
                
            } while (contador <= 50);
            Console.Write(soma);
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public static void ExecutarComForEx02()
        {
            Console.WriteLine("Estrutura for() { }");
            int contador = 1;
            int soma = 0;
            for (contador = 1; contador <= 50; contador++)
            {
                soma += contador;
            }
            Console.Write($"A soma entre os números de 1 a 50 é: {soma}");
            Console.WriteLine("");

        }
    }
}
