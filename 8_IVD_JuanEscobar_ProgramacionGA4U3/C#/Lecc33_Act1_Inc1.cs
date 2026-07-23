internal class Lecc33_Act1_Inc1
{
    static string[,] num = new string[10, 2];
    private static void Main(string[] args)
    {
        int opcion;
        do
        { 
            Console.Clear();
            Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
            Console.WriteLine("IV Bachillerato D, clave 8");
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Registrar Numero");
            Console.WriteLine("2. Mostrar Numero");
            Console.WriteLine("3. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("===REGISTRAR NUMEROS===");
                    RegistrarN();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("===MOSTRAR NUMEROS===");
                    MostrarN();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 3);
    }
    static void RegistrarN()
    {
        for (int i = 0; i < 10; i++)
        {
            if (string.IsNullOrEmpty(num[i, 0]))
            {
                Console.WriteLine("Nombre:");
                num[i, 0] = Console.ReadLine();
                Console.WriteLine("Numero:");
                num[i, 1] = Console.ReadLine();
                Console.WriteLine("Numero registrado.");
                return;
            }
        }
        Console.WriteLine("Matriz llena.");
    }
    static void MostrarN()
    {
        Console.WriteLine("NOMBRE          NUMERO");
        for (int i = 0; i < 10; i++)
        {
            if (!string.IsNullOrEmpty(num[i, 0]))
            {
                Console.WriteLine(num[i, 0] + "          " + num[i, 1]);
            }
        }
    }
}