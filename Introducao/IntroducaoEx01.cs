namespace Introducao
{
    /*
     Crie um programa que solicite a idade de uma pessoa e
    informa se ela pe maior de idade ou não
     */
    internal class IntroducaoEx01
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("### VERIFICADOR DE IDADE ###");
            Console.WriteLine();
            Console.Write("Informe a sua idade: ");
            string? strIdade = Console.ReadLine();
            int intIdade = Convert.ToInt32(strIdade);

            if (intIdade >= 18)
            
                Console.WriteLine("Maior de Idade.");
            
            else
                Console.WriteLine("Maior de idade.");
                Console.Write("Pressione uma tecla para continuar...");
                Console.ReadKey();
        }
    }
}
