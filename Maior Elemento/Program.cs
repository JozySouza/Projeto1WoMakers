
int maiorValor = int.MinValue;
int posicaoMaior = 0;

Console.WriteLine("=== Descobridor do Maior Número ===");
Console.WriteLine("Você precisará digitar 10 números.\n");

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > maiorValor)
    {
        maiorValor = numero;
        posicaoMaior = i;
    }
}

Console.WriteLine();
Console.WriteLine("--- Resultado ---");
Console.WriteLine($"O maior valor digitado foi: {maiorValor}");
Console.WriteLine($"Ele foi digitado na {posicaoMaior}ª posição.");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();