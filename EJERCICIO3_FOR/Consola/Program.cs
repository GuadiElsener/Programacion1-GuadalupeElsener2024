// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el costo del producto y la cantidad de unidades que compró del mismo");

Double deuda = 0;
double subtotal = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Compra:{i}");

    Console.Write("Costo Unitario: ");
    if (double.TryParse(Console.ReadLine(), out double costounitario))
    {
        Console.Write("Cantidad comprada: ");
        if (int.TryParse(Console.ReadLine(), out int cantidad))
        { 
        subtotal = costounitario * cantidad;
        deuda += subtotal;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un número que sea válido");
        i--;
    }
}
Console.WriteLine("El total adeudado es de: " + deuda);

   
