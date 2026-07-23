internal class Lecc34_Act1_Inc2
{
    private static void Main(string[] args)
    {
        double m, p, h;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese su peso (kilogramos)");
        p = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su altura (metros)");
        h = double.Parse(Console.ReadLine());

        m = p / Math.Pow(h, 2);

        Console.WriteLine("Su cantidad de masa corporal es de: " + m);
    }
}