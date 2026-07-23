internal class Lecc32_Act1_Inc1
{
    private static void Main(string[] args)
    {
        double me, op, res;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("====CONVERSOR====");
        Console.WriteLine("Ingrese una cantidad de metros");
        me = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1- milimetros");
        Console.WriteLine("2- centimetros");
        Console.WriteLine("3- decimetros");
        Console.WriteLine("4- hectometros");
        Console.WriteLine("5- kilometros");
        op = double.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                res = me * 1000;
                Console.WriteLine(me + " metros equivale a " + res + " milimetros");
                break;
            case 2:
                res = me * 100;
                Console.WriteLine(me + " metros equivale a " + res + " centimetros");
                break;
            case 3:
                res = me * 10;
                Console.WriteLine(me + " metros equivale a " + res + " decimetros");
                break;
            case 4:
                res = me / 100;
                Console.WriteLine(me + " metros equivale a " + res + " hectometros");
                break;
            case 5:
                res = me / 1000;
                Console.WriteLine(me + " metros equivale a " + res + " kilometros");
                break;
            default:
                Console.WriteLine("Opcion invalida...");
                break;
        }
    }
}
