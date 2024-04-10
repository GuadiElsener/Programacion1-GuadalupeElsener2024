// See https://aka.ms/new-console-template for more information
int num1, num2;

Console.WriteLine("Ingrese el primer número: ");
if(!Int32.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Error, ingrese un número correcto");
}
else
{
    Console.WriteLine("Ingrese el segundo número: ");
    if(!Int32.TryParse(Console.ReadLine(),out num2))
    {
        Console.WriteLine("Error, ingrese un número correcto");
    }
    else
    {
        if (num1 < num2)
        {
            Console.WriteLine("El número: " + num2 + " es mayor");
        }
        else
        {
            if (num2 < num1)
            {
                Console.WriteLine("El número: " + num1 + " es mayor");
            }
            else
            {
                Console.WriteLine("Los números son iguales");
            }
        }
    }
}