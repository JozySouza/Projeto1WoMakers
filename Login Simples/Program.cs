string senhaCorreta = "123456";//senha para comparar com a digitada pelo usuário

Console.WriteLine("=== Sistema de Login ===");

Console.WriteLine("Digite o usuário:");
string usuario = Console.ReadLine();

Console.WriteLine("Digite a senha:");
string senha = Console.ReadLine();

while (senha != senhaCorreta)
{
    Console.WriteLine();
    Console.WriteLine("Senha incorreta! Tente novamente.");

    Console.WriteLine("Digite a senha:");
    senha = Console.ReadLine(); // Lê a nova tentativa
}

Console.WriteLine();
Console.WriteLine($"Acesso concedido! Bem-vindo(a), {usuario}.");

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();