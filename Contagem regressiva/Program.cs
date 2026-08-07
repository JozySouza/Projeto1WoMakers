for (int i = 50; i >= 1; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(100); // Pausa de 0,1 segundo para conseguir ver os números descendo
}

Console.WriteLine("Fim da contagem!");
Console.ReadKey();