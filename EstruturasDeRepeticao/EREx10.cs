namespace EstruturasDeRepeticao
{
    internal class EREx10
    {
        public static void IdentificacaoEx10()
        {
            Console.WriteLine("Exercício 10: Solicite um número e exiba seu fatorial (N!).");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx10()
        {
            Console.WriteLine("Estrutura while(true) { }");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;
            int contador = 1;
            while (contador <= numero)
            {
                fatorial *= contador;
                contador++;
            }
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
        public static void ExecutarComDoWhileEx10()
        {
            Console.WriteLine("Estrutura do / while(true) { }");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;
            int contador = 1;
            do
            {
                fatorial *= contador;
                contador++;
            }
            while (contador <= numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
        public static void ExecutarComForEx10()
        {
            Console.WriteLine("Estrutura for(true) { }");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int contador = 1; contador <= numero; contador++)
            {
                fatorial *= contador;
            }
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }
}
