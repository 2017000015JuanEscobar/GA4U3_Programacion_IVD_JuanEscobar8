internal class Lecc35_Act1_Inc2
{
    private static void Main(string[] args)
    {
        double pre, pag, c, r, m, b200, b100, b50, b20, residuo;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese el precio del producto");
        pre = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el billete con el que pago el cliente");
        pag = double.Parse(Console.ReadLine());

        if (pag < pre)
        {
            Console.WriteLine("EL dinero es insuficiente para la compra");
        }
        else
        {
            c = pag - pre;
            Console.WriteLine("El cambio total es de: Q" + c);
            r = c;
            b200 = Math.Truncate(r / 200);
            r = r % 200;
            b100 = Math.Truncate(r / 100);
            r = r % 100;
            b50 = Math.Truncate(r / 50);
            r = r % 50;
            b20 = Math.Truncate(r / 20);
            residuo = r % 20;
            m = residuo;
            Console.WriteLine("================================================");
            Console.WriteLine("Cambio");
            if (b200 > 0) Console.WriteLine("Billetes de 200: " + b200);
            if (b100 > 0) Console.WriteLine("Billetes de 100: " + b100);
            if (b50 > 0) Console.WriteLine("Billetes de 50: " + b50);
            if (b20 > 0) Console.WriteLine("Billetes de 20: " + b20);
            if (m > 0) Console.WriteLine("El cambio restante es de Q: " + m);
            Console.WriteLine("================================================");
        }
    }
}