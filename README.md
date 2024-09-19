# Pedra Papel e Tesoura 
## o que é ?
 Pedra, papel e tesoura, também chamado em algumas regiões do Brasil de jokenpô, é um jogo de mãos recreativo e simples para duas ou mais pessoas, que não requer equipamentos nem habilidade.
## como funciona?
Nele, o jogador faz uma escolha entre as três opções (pedra, papel e tesoura), e o computador escolhe outra aleatoriamente, o jogo compara as opções escolhidas e seguindo a regra proposta do jogo da o resultado do vencedor (pedra ganha de tesoura, tesoura ganha de papel, papel ganha de pedra).
 ## como foi construído o jogo?
 O jogo foi desenvolvido em C# 
 Iniciamos um gerador de opções aleatórias do jogo.
 Usamos o Random, ele vai escolher opções aleatórias que estão dentro do Array (pedra, papel e tesoura).
 O loop while (true) faz o jogo continuar executando infinitamente, até que o jogador decida sair.
 Usando o Console.WriteLine, quando o código e executado aparece na tela à mensagem Escolha (Pedra, Papel ou Tesoura) ou digite 'sair' para encerrar.
 Para não ocorrer erros de letras maiúsculas ou minúsculas é usado o "ToLower".
 Se o jogador digita alguma palavra que esteja fora do array será exibido à mensagem de erro e solicita uma nova entrada.
 Após o jogador escolher sua opção, o computador aleatoriamente escolhe uma opção usando o random.next() que também vai usar uma das opções do array.
 Após todas essas fases o jogo compara as opções escolhidas.
 Se as escolhas forem iguais, o jogo declara empate.
 Se a combinação de escolhas resultarem em vitória do jogador, uma mensagem de vitória é exibida.
 Caso contrário, o jogo exibe que o jogador perdeu.
 Se o jogador digitar "sair", o loop é interrompido, e o jogo exibe uma mensagem de encerramento antes de terminar.

<img src="pedra papel e tesoura.png" alt="Print jogo funcinando">


