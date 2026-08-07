
int soma = 0;
int numero;

Console.WriteLine("=== Somador de Números ===");
Console.WriteLine("Digite os números que deseja somar.");
Console.WriteLine("Para encerrar e ver o resultado, digite 0.");
Console.WriteLine("-----------------------------------");

do
{
    Console.Write("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine();
Console.WriteLine($"Programa encerrado! A soma de todos os valores digitados é: {soma}");

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();