// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese 8 números:");

Double suma = 0;
Double promedio = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"Valor {i}: ");
    if (Double.TryParse(Console.ReadLine(), out double numero))
    {
        suma += numero;

    }
    else
    {
        Console.WriteLine("Error, ingrese un número válido");
        i--;
    }
}

promedio = suma / 8;
Console.WriteLine("El promedio es de: "+ promedio);