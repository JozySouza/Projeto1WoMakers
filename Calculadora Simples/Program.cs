
Console.WriteLine("Digite o primeiro número:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação (+, -, *, /):");
char operacao = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;
bool valido = true;

switch (operacao)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            resultado = num1 / num2;
        else
        {
            Console.WriteLine("Erro: Divisão por zero!");
            valido = false;
        }
        break;
    default:
        Console.WriteLine("Operação inválida!");
        valido = false;
        break;
}

if (valido)
{
    Console.WriteLine($"O resultado é: {resultado}");
}

Console.ReadKey();
    