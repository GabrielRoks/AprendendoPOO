namespace Introducao
{
    internal class Triangulo
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Calcular a area do triângulo");
            Console.WriteLine();
            Console.WriteLine("Informe a medida da Base: ");
            string? strBase = Console.ReadLine();
            int intBase = Convert.ToInt32(strBase);
            Console.WriteLine("Informe a altura do triângulo: ");
            string? strAltura = Console.ReadLine();
            int intAltura = Convert.ToInt32(strAltura);
            float FloatArea = intBase * intAltura / 2;
            Console.WriteLine($"A área do triângulo é: {FloatArea}");
            Console.WriteLine("Precione qualque tecla");
            Console.ReadKey();
        }
    }
}
