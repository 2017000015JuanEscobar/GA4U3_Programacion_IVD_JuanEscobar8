internal class Lecc32_Act2_Inc1
{
    private static void Main(string[] args)
    {
        double m, d;
        Console.WriteLine("Nombre: Juan Pablo Escobar de Paz");
        Console.WriteLine("IV Bachillerato D, clave 8");
        Console.WriteLine("Ingrese su mes de nacimiento");
        m = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su dia de nacimiento");
        d = double.Parse(Console.ReadLine());

        if ((m == 3 && d >= 21) || (m == 4 && d <= 19))
        {
            Console.WriteLine("Su signo es Aries");
            Console.WriteLine("Su horoscopo es de que va a ser Famoso");
        }
        if ((m == 4 && d >= 20) || (m == 5 && d <= 20))
        {
            Console.WriteLine("Su signo es Tauro");
            Console.WriteLine("Su horoscopo es de tendra Salud");
        }
        if ((m == 5 && d >= 21) || (m == 6 && d <= 20))
        {
            Console.WriteLine("Su signo es Geminis");
            Console.WriteLine("Su horoscopo es usted una Persona con Valores");
        }
        if ((m == 6 && d >= 21) || (m == 7 && d <= 22))
        {
            Console.WriteLine("Su signo es Cancer");
            Console.WriteLine("Su horoscopo es de que va a ser Millonario");
        }
        if ((m == 7 && d >= 23) || (m == 8 && d <= 22))
        {
            Console.WriteLine("Su signo es Leo");
            Console.WriteLine("Su horoscopo es de que va a ser Envidioso");
        }
        if ((m == 8 && d >= 23) || (m == 9 && d <= 22))
        {
            Console.WriteLine("Su signo es Virgo");
            Console.WriteLine("Su horoscopo es de que usted es Humilde");
        }
        if ((m == 9 && d >= 23) || (m == 10 && d <= 22))
        {
            Console.WriteLine("Su signo es Libra");
            Console.WriteLine("Su horoscopo es de que sera Cineasta");
        }
        if ((m == 10 && d >= 23) || (m == 11 && d <= 21))
        {
            Console.WriteLine("Su signo es Escorpio");
            Console.WriteLine("Su horoscopo es de que va a entrar en una relacion");
        }
        if ((m == 11 && d >= 22) || (m == 12 && d <= 21))
        {
            Console.WriteLine("Su signo es Sagitario");
            Console.WriteLine("Su horoscopo es que usted es Narcisista");
        }
        if ((m == 12 && d >= 22) || (m == 1 && d <= 19))
        {
            Console.WriteLine("Su signo es Capricornio");
            Console.WriteLine("Su horoscopo es que sera un Sacerdote");
        }
        if ((m == 1 && d >= 20) || (m == 2 && d <= 18))
        {
            Console.WriteLine("Su signo es Acuario");
            Console.WriteLine("Su horoscopo es de que sera un Medico");
        }
        if ((m == 2 && d >= 19) || (m == 3 && d <= 20))
        {
            Console.WriteLine("Su signo es Psicis");
            Console.WriteLine("Su horoscopo es de que es alguien muy Respetuoso");
        }
    }
}