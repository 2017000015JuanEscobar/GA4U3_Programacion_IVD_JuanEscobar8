internal class Lecc34_Act1_Inc1
{
    private static void Main(string[] args)
    {
        int numd, r;
        string bin = "";
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Escriba un numero decimal");
        numd = int.Parse(Console.ReadLine());

        if (numd == 0)
        {
            bin = "0";
        }
        else
        {
            while (numd > 0)
            {
                r = numd % 2;
                bin = r.ToString() + bin;
                numd = numd / 2;
            }
        }
        Console.WriteLine("El numero convertido a binario es: " + bin);
    }
}