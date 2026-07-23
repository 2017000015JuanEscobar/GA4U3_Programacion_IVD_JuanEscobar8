internal class Lecc32_Act3_Inc1
{
    private static void Main(string[] args)
    {
        double l1, l2, l3;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese la medida del lado 1:");
        l1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la medida del lado 2:");
        l2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la medida del lado 3:");
        l3 = double.Parse(Console.ReadLine());

        if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
        {
            if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("El triángulo es EQUILÁTERO");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("El triángulo es ISÓSCELES");
            }
            else
            {
                Console.WriteLine("El triángulo es ESCALENO");
            }
        }
        else
        {
            Console.WriteLine("Las medidas ingresadas no forman un triángulo.");
        }
    }
}