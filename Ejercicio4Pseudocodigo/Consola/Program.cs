// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese un número: ");
double num1,num2,num3;

if (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Error, ingrese un número que sea correcto");
}
else
{
    Console.WriteLine("Ingrese otro número:");
}
    if (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Error, ingrese un número que sea correcto");
    }
    else
    {
    Console.WriteLine("Ingrese otro número: ");
    }
        if (!double.TryParse(Console.ReadLine(), out num3))
        {
            Console.WriteLine("Error, ingrese un número que sea correcto");
        }
        else
        { 
            Double Promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("El promedio de los tres números es de: " + Promedio);
        }