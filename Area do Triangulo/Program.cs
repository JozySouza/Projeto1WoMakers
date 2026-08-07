Console.Write("Digite a Base do Triângulo: ");
double TriagBase = double.Parse(Console.ReadLine());
Console.Write("Digite a Altura do Triângulo: ");
double TriagAltura = double.Parse(Console.ReadLine());

double TriagArea = (TriagBase * TriagAltura) / 2;

Console.WriteLine($"A área do triângulo é {TriagArea}");