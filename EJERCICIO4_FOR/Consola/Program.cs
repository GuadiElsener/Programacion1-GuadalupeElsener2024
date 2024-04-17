// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese 8 números:");

Double mayor = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"Valor {i}: ");
    if (Double.TryParse(Console.ReadLine().Replace(".",","), out double numero))
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un número válido");
        i--;
    }
}
Console.WriteLine("El mayor número es: "+ mayor);

