
Console.WriteLine("=== Verificador de Segurança de Senha ===");
Console.WriteLine("Digite a sua senha:");

string senha = Console.ReadLine();

Console.WriteLine();

if (senha.Length >= 8)
{
    Console.WriteLine("Senha válida! Ela possui pelo menos 8 caracteres.");
}
else
{
    Console.WriteLine($"Senha inválida! Ela possui apenas {senha.Length} caracteres. É necessário ter no mínimo 8.");
}

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();