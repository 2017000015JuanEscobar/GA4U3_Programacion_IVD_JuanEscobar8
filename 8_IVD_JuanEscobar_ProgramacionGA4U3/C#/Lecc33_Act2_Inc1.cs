internal class Lecc33_Act2_Inc1
{
    private static void Main(string[] args)
    {
        string fra, f1 = "";
        int lf, i;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese una frase para invertirla");
        fra = Console.ReadLine();
        lf = fra.Length;

        for (i = lf - 1; i >= 0; i--)
        {
            f1 = f1 + fra.Substring(i, 1);
        }
        Console.WriteLine(f1);
    }