
Console.WriteLine("=== Cálculo de Média do Vetor ===");

double[] notas = new double[8];
double soma = 0;

Console.WriteLine("Digite as 8 notas abaixo:\n");

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Digite a {i + 1}ª nota: ");

    notas[i] = Convert.ToDouble(Console.ReadLine());

    soma += notas[i];
}

double media = soma / notas.Length;

Console.WriteLine();
Console.WriteLine("--- Resultado ---");
Console.WriteLine($"A soma total das notas é: {soma}");
Console.WriteLine($"A média final é: {media:N2}");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();