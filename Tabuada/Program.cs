


Console.WriteLine("Digite um número para ver a sua tabuada:");


int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(); 
Console.WriteLine($"--- Tabuada do {numero} ---");


for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;

    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.WriteLine("---------------------");
Console.WriteLine("Pressione qualquer tecla para sair...");

Console.ReadKey();