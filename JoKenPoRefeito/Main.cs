namespace JoKenPoRefeito
{
    internal class Main
    {
        public static void game()
        {
            Console.WriteLine("Bem-vindo ao jogo de JoKenPo!");
            Console.WriteLine("Vamos começar!");
            string[] opcoes = new[] { "Pedra", "Papel", "Tesoura" };
            while (true)
            {
                int playerScore = 0;
                int computadorScore = 0;
                Console.WriteLine("\nIniciando uma nova partida...");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nEscolha 1- Pedra, 2- Papel ou 3- Tesoura:");
                    int playerChoice = int.Parse(Console.ReadLine());
                    if (playerChoice < 1 || playerChoice > 3)
                    {
                        Console.WriteLine("Escolha inválida. Por favor, escolha 1, 2 ou 3.");
                        i--; // Decrementa para repetir a rodada
                        continue;
                    }
                    Random random = new Random();
                    int computerChoice = random.Next(1, 4);
                    Console.WriteLine("");
                    Console.WriteLine($"Você escolheu: {opcoes[playerChoice - 1]}");
                    Console.WriteLine("");
                    Console.WriteLine($"Computador escolheu: {opcoes[computerChoice - 1]}");
                    
                    if (computerChoice == playerChoice)
                    {
                        Console.WriteLine("\nEmpate!");
                        Console.WriteLine("");
                        continue;
                    }
                    else if (computerChoice == 1 && playerChoice == 3 || computerChoice == 2 && playerChoice == 1 || computerChoice == 3 && playerChoice == 2)
                    {
                        Console.WriteLine("\nComputador ganhou esta rodada!");
                        computadorScore++;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("\nVocê ganhou esta rodada!");
                        playerScore++;
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"\nPlacar final: Você {playerScore} x {computadorScore} Computador");
                }
                if (playerScore > computadorScore)
                    Console.WriteLine("Parabéns! Você venceu o jogo!");
                else if (playerScore < computadorScore)
                    Console.WriteLine("Computador venceu o jogo! Tente novamente.");
                else
                    Console.WriteLine("O jogo terminou empatado!");
                Console.Write("\nVocê deseja jogar novamente? (s/n): ");
                var resposta = Console.ReadLine()?.Trim().ToLower();
                if (resposta == "s" || resposta == "sim")
                {
                    Console.WriteLine("Reiniciando o jogo...\n");
                    continue; 
                }
                else
                {
                    Console.WriteLine("Obrigado por jogar comigo! Até a próxima.");
                    break;
                }

            }
        }
    }
}
