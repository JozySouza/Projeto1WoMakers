
Console.WriteLine("=== Inversor de Números ===");

int[] numeros = new int[10];

Console.WriteLine("Digite 10 números abaixo:\n");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("--- Números na ordem inversa ---");

// 2º LAÇO: Para EXIBIR os números de trás para frente
// Começa na última posição válida do vetor (tamanho - 1, ou seja, 9)
// Continua enquanto o 'i' for maior ou igual a 0
// A cada volta, diminui 1 (i--)
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();