internal class Lecc35_Act1_Inc3
{
    private static void Main(string[] args)
    {
        int opc, c;
        string jn;
        Random rnd = new Random();
        do
        {
            Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
            Console.WriteLine("IV Bachillerato D, clave 8");
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1- Piedra");
            Console.WriteLine("2- Papel");
            Console.WriteLine("3- Tijeras");
            opc = int.Parse(Console.ReadLine());
            c = rnd.Next(1, 4);

            if (c == 1)
            {
                Console.WriteLine("La computadora eligió: Piedra");
            }
            else if (c == 2)
            {
                Console.WriteLine("La computadora eligió: Papel");
            }
            else
            {
                Console.WriteLine("La computadora eligió: Tijeras");
            }

            if (opc == c)
            {
                Console.WriteLine("¡Es un empate!");
            }
            else
            {
                if ((opc == 1 && c == 3) || (opc == 2 && c == 1) || (opc == 3 && c == 2))
                {
                    Console.WriteLine("¡Usted Gano!");
                }
                else
                {
                    Console.WriteLine("¡Ganó la computadora! Que mal :(");
                }
            }
            Console.WriteLine("¿Quieres jugar de nuevo? (S/N):");
            jn = Console.ReadLine();

        } while (jn != "N" && jn != "n");
        Console.WriteLine("¡Gracias por jugar!");
    }
}