
// gerador de números aleatórios
Random gerador = new Random();

int numeroSorteado = gerador.Next(1, 101);
int palpite = 0;

Console.WriteLine("=== Jogo da Adivinhação ===");
Console.WriteLine("Eu pensei em um número entre 1 e 100.");
Console.WriteLine("Tente adivinhar qual é!\n");

while (palpite != numeroSorteado)
{
    Console.Write("Digite o seu palpite: ");
    palpite = Convert.ToInt32(Console.ReadLine());

    if (palpite < numeroSorteado)
    {
        Console.WriteLine("O número que eu pensei é MAIOR. Tente novamente!\n");
    }
    else if (palpite > numeroSorteado)
    {
        Console.WriteLine("O número que eu pensei é MENOR. Tente novamente!\n");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("PARABÉNS! Você acertou!");
    }
}

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();