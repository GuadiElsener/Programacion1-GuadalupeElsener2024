// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese el lado del cuadrado: ");
Double lado1; 

if (!Double.TryParse(Console.ReadLine(), out lado1))
{
    Console.WriteLine("Error, ingrese una medida correcta");
}
else
{
    Double resultado = lado1 * lado1;
    Console.WriteLine("El área del cuadrado es de: " +  resultado);
}
   

