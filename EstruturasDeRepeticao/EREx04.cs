namespace EstruturasDeRepeticao
{
    internal class EREx04
    {
        public static void IdentificacaoEx04()
        {
            Console.WriteLine("Exercício 04: Solicite um número de 1 a 10 e monte sua tabuada.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void ExecutarComWhileEx04()
        {
            Console.WriteLine("Estrutura while(true) { }");
            Console.Write("Digite um número de 1 a 10: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 0;
            if (Numero <= 10)
            {
                while (Contador < 10)
                {
                    Contador++;
                    int Tabuada = Numero * Contador;
                    Console.WriteLine($"{Numero} x {Contador} = {Tabuada}");
                }
            }
            else
            {
                Console.WriteLine("O numero precisa estar entre 1 e 10");
            }
        }
        public static void ExecutarComDoWhileEx04()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura do / while(true) { }");
            Console.Write("Digite um número de 1 a 10: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 0;
            if (Numero <= 10)
            {
                do
                {
                    Contador++;
                    int Tabuada = Numero * Contador;
                    Console.WriteLine($"{Numero} x {Contador} = {Tabuada}");
                }
                while (Contador < 10);
            }
            else
            {
                Console.WriteLine("O numero precisa estar entre 1 e 10");

            }
        }
        public static void ExecutarComForEx04()
        {
            Console.WriteLine("");
            Console.WriteLine("Estrutura for() { }");
            Console.Write("Digite um número de 1 a 10: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 0;
            if (Numero <= 10)
            {
                for (Contador = 0; Contador <= 10; Contador++)
                {
                    int Tabuada = Numero * Contador;
                    Console.WriteLine($"{Numero} x {Contador} = {Tabuada}");
                }
            }
            else
            {
                Console.WriteLine("O numero precisa estar entre 1 e 10");

            }
        }
    }
}
