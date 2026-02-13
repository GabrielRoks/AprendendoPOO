namespace EstruturasDeRepeticao
{
    internal class EREx05
    {
        public static void IdentificacaoEx05()
        {
            Console.WriteLine("Exercício 05: Solicite um número inteiro e some seus números ímpares de 1 a N.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx05()
        {
            Console.WriteLine("Estrutura while(true) { }");
            Console.Write("Digite um número inteiro: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 1;
            int Soma = 0;
            while (Contador <= Numero)
            {
                if (Contador % 2 != 0)
                {
                    Soma += Contador;
                }
                Contador++;
            }
            Console.WriteLine(Soma);
        }
        public static void ExecutarComDoWhileEx05()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura do / while(true) { }");
            Console.Write("Digite um número inteiro: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 1;
            int Soma = 0;
            do
            {
                if (Contador % 2 != 0)
                {
                    Soma += Contador;
                }
                Contador++;
            }
            while (Contador <= Numero);
            Console.WriteLine(Soma);
        }
        public static void ExecutarComForEx05()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura for() { }");
            Console.Write("Digite um número inteiro: ");
            int Numero = int.Parse(Console.ReadLine());
            int Soma = 0;
            for (int i = 1; i <= Numero; i++)
            {
                if (i % 2 != 0)
                {
                    Soma += i;
                }
            }
            Console.WriteLine(Soma);
        }
    }
}
