// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Ingrese la cantidad de numeros a la que desea sacar su factorial");
int cantidad;
for (int j = 1; j < 2;)
{
    if (int.TryParse(Console.ReadLine(), out cantidad))
    {
        j++;
        Console.WriteLine("Ingrese un número para calcular su factorial");
        int numero;

        for (int x = 1; x <= cantidad; x++)
        {
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("El factorial del número " + numero + " es: " + factorial);
            }
            else
            {
                Console.WriteLine("Error, ingrese un número que sea válido");
                x--;
            }
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un número que sea válido");
    }
}