internal class Lecc35_Act1_Inc1
{
    private static void Main(string[] args)
    {
        double Q, do_, eu, yen, pChi, pCom;
        double cdo = 0.13, ceu = 0.11, cyen = 21.16, cpChi = 121.80, cpCom = 426.03;
        string r;
        do
        {
            Console.Clear();
            Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
            Console.WriteLine("IV Bachillerato D, clave 8");
            Console.WriteLine("===CONVERTIDOR DE MONEDAS===");
            Console.WriteLine("Ingrese la cantidad de su moneda");
            Q = double.Parse(Console.ReadLine());

            do_ = Q * cdo;
            eu = Q * ceu;
            yen = Q * cyen;
            pChi = Q * cpChi;
            pCom = Q * cpCom;

            Console.WriteLine("========================================");
            Console.WriteLine("El equivalente en dolares es de: " + do_);
            Console.WriteLine("El equivalente en Euros es de: " + eu);
            Console.WriteLine("El equivalente en Yenes es de: " + yen);
            Console.WriteLine("El equivalente en Pesos Chilenos es de: " + pChi);
            Console.WriteLine("El equivalente en Pesos Colombanos: " + pCom);
            Console.WriteLine("========================================");
            Console.WriteLine("Desea hacer otra convercion");
            r = Console.ReadLine();
        } while (r != "No" && r != "no");
    }
}