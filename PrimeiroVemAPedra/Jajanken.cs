namespace PrimeiroVemAPedra
{
    internal class Jajanken
    {
        public static void Main()
        {
            var random = new Random();

            while (true)
            {
                int playerScore = 0;
                int gonScore = 0;

                for (int round = 1; round <= 3; round++)
                {
                    Console.WriteLine($"\nRodada {round} de 3");
                    Console.WriteLine("1. Pedra");
                    Console.WriteLine("2. Papel");
                    Console.WriteLine("3. Tesoura");

                    int suaEscolha;
                    while (true)
                    {
                        Console.Write("Escolha (1-3): ");
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out suaEscolha) && suaEscolha >= 1 && suaEscolha <= 3)
                            break;
                        Console.WriteLine("Entrada inválida. Digite 1, 2 ou 3. ");
                    }

                    int gon = random.Next(1, 4);

                    Console.WriteLine($"Você escolheu: {(suaEscolha)}");
                    Console.WriteLine($"Gon escolheu: {(gon)}");

                    if (suaEscolha == gon)
                    {
                        Console.WriteLine("Empate nesta rodada!");
                        Console.WriteLine("");
                    }
                    else if (suaEscolha == 1 && gon == 3 || suaEscolha == 2 && gon == 1 || suaEscolha == 3 && gon == 2)
                    {
                        Console.WriteLine("Você ganhou esta rodada!");
                        playerScore++;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Gon ganhou esta rodada!");
                        gonScore++;
                        Console.WriteLine("");
                    }

                    Console.WriteLine($"Placar: Você {playerScore} x {gonScore} Gon");
                }

                Console.WriteLine("\nResultado final:");
                if (playerScore > gonScore)
                    Console.WriteLine("Parabéns! Você venceu o jogo!");
                else if (playerScore < gonScore)
                    Console.WriteLine("Gon venceu o jogo! Tente novamente.");
                else
                    Console.WriteLine("O jogo terminou empatado!");

                Console.Write("\nVocê deseja jogar novamente? (s/n): ");
                var resposta = Console.ReadLine()?.Trim().ToLower();
                if (resposta == "s" || resposta == "sim")
                {
                    Console.WriteLine("Reiniciando o jogo...\n");
                    continue; // reinicia as 3 rodadas
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
