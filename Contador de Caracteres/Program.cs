
Console.WriteLine("=== Contador de Caracteres ===");
Console.WriteLine("Digite uma palavra ou frase:");

string texto = Console.ReadLine();

int quantidadeDeCaracteres = texto.Length;

Console.WriteLine();
Console.WriteLine($"O texto que você digitou possui {quantidadeDeCaracteres} caracteres.");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();