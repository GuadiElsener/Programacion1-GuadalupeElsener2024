// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número");
Double numero;

if (!Double.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Error, ingrese un numero que sea correcto");
}
else
{
    if (numero >= 0)
    {
        Console.WriteLine("El número es positivo");
    }
    else
    {
        Console.WriteLine("El número es negativo");
    }
}
