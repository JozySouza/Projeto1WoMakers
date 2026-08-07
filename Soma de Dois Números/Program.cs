
Console.WriteLine("=== Soma de Dois Números ===");

Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;

Console.WriteLine();
Console.WriteLine("--- Resultado ---");
Console.WriteLine($"A soma de {numero1} + {numero2} é igual a: {soma}");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();