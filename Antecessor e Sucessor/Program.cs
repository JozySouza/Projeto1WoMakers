Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int antecessor = numero - 1;
int sucessor = numero + 1;

Console.WriteLine($"O antecessor de {numero} é {antecessor}");
Console.WriteLine($"O sucessor de {numero} é {sucessor}");