using System;
using System.Globalization;


        Console.WriteLine("Digite o valor em dinheiro:");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.WriteLine("Digite a taxa de conversão (ex: 5,40):");
            if (decimal.TryParse(Console.ReadLine(), out decimal taxa))
            {
                decimal resultado = valor * taxa;
                Console.WriteLine($"Valor convertido: {resultado.ToString("C", CultureInfo.CurrentCulture)}");
            }
            else
            {
                Console.WriteLine("Taxa inválida.");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
   