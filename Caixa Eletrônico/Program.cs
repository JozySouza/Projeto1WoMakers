
Console.WriteLine("=== Caixa Eletrônico ===");
Console.WriteLine("Notas disponíveis: R$ 100, R$ 50, R$ 20, R$ 10, R$ 5, R$ 2");
Console.Write("Digite o valor que deseja sacar: R$ ");

int valorSaque = Convert.ToInt32(Console.ReadLine());

int[] notas = { 100, 50, 20, 10, 5, 2 };

Console.WriteLine();
Console.WriteLine("--- Notas Entregues ---");

for (int i = 0; i < notas.Length; i++)
{
    int quantidadeNotas = valorSaque / notas[i];

    if (quantidadeNotas > 0)
    {
        Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {notas[i]}");

        valorSaque = valorSaque % notas[i];
    }
}

if (valorSaque > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Aviso: Não foi possível sacar R$ {valorSaque} por falta de notas de R$ 1.");
}

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();