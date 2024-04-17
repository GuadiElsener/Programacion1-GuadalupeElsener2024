// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese el nombre del cliente y el total que gastó");
String ClienteMayorGasto = "";
Double mayor = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Compra:{i}");

    Console.Write("Nombre del cliente: ");
    String nombre = Console.ReadLine();
    
    
    Console.Write("Total de compra: ");
    if (Double.TryParse(Console.ReadLine()?.Replace(".",","), out Double total))
    {
         if (total > mayor)
         { 
             mayor = total; 
             ClienteMayorGasto = nombre;
         }

    }
    else
    {
        Console.WriteLine("Error, ingrese un número que sea válido");
        i--;
    }
}
Console.WriteLine("El cliente que gastó más es " + ClienteMayorGasto + " con un total de: "+ mayor);
