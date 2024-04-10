// See https://aka.ms/new-console-template for more information

Double lado1, lado2, lado3;

Console.WriteLine("Ingrese el primer lado: ");
if(!Double.TryParse(Console.ReadLine(), out lado1))
{
    Console.WriteLine("Error, ingrese un número que sea correcto");
}
else
{
    Console.WriteLine("Ingrese el segundo lado");
    if(!Double.TryParse(Console.ReadLine(),out lado2))
    {
        Console.WriteLine("Error, ingrese un número que sea correcto");
    }
    else
    {
        Console.WriteLine("Ingrese el tercer lado");
        if (!Double.TryParse(Console.ReadLine(),out lado3))
        {
            Console.WriteLine("Error, ingrese un número que sea correcto");
        }
        else
        {
            Double Perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("El perímetro es de: " +  Perimetro + "cm");
        }

    }
}
