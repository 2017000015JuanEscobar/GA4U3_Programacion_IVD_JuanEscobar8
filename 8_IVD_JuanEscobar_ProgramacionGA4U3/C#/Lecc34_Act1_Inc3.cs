internal class Lecc34_Act1_Inc3
{
    private static void Main(string[] args)
    {
        double c, f, k;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese una cantidad en grados centigrados: ");
        c = double.Parse(Console.ReadLine());

        f = (c * 1.8) + 32;
        k = c + 273.15;

        Console.WriteLine("La cantidad en grados farhenheit es de: " + f);
        Console.WriteLine("La cantidad en grados celsius es de: " + c);
        Console.WriteLine("La cantidad en grados kelvin es de: " + k);
    }
}