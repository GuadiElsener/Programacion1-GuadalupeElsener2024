// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese un número entero positivo:");
int numero;

    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
    {
        Console.WriteLine("Error, ingrese un número entero positivo válido.");
    }
    else
    {
        for (int i = 0; i <= numero; i += 2)
        {
            Console.WriteLine(i);
        }
    }
    Console.WriteLine("Los números enteros positivos pares hasta " + numero + ":");

