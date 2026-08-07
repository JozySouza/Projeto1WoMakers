
int quantidadePares = 0; //contador

Console.WriteLine("=== Contador de Números Pares ===");
Console.WriteLine("Você precisará digitar 20 números.\n");

for (int i = 1; i <= 20; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    // Verifica se o resto da divisão por 2 é zero 
    if (numero % 2 == 0)
    {
        // Adiciona +1 ao nosso contador de pares
        quantidadePares++;
    }
}

Console.WriteLine();
Console.WriteLine("--- Resultado ---");
Console.WriteLine($"Você digitou {quantidadePares} números pares no total.");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();