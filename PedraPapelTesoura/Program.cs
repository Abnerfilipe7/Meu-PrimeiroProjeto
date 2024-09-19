// See https://aka.ms/new-console-template for more information
﻿Random random = new Random();
        string[] opções = { "pedra", "papel", "tesoura" };

        while (true)
        {
            Console.Write("Escolha (Pedra, Papel ou Tesoura ): ");
            string escolhaJogador = Console.ReadLine().ToLower();

            if (escolhaJogador == "sair"){
                Console.WriteLine("Jogo Encerrado!!");
                break;
            }

           

            if (Array.IndexOf(opções, escolhaJogador) == -1)
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                continue;
            }

            string escolhaComputador = opções[random.Next(opções.Length)];
            Console.WriteLine($"Computador escolheu: {escolhaComputador}");

            if (escolhaJogador == escolhaComputador)
                Console.WriteLine("Empate!");
            else if ((escolhaJogador == "pedra" && escolhaComputador == "tesoura") ||
                     (escolhaJogador == "papel" && escolhaComputador == "pedra") ||
                     (escolhaJogador == "tesoura" && escolhaComputador == "papel"))
                Console.WriteLine("Você ganhou!");
            else
                Console.WriteLine("Você perdeu!");

            Console.WriteLine();
        }

