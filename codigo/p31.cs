using System;
class Program
{
    static void Main()
    {
        // mostrar los digitos de un numero
        int n = 123;
        int d = 0;
        Console.WriteLine(n / 10);
        Console.WriteLine(n % 10);
        Console.Write("Digitos de {0}: ", n);
        while(n > 0)
        {
            d = n % 10;
            n = n / 10;
            Console.Write("{0}, ", d);
        }
    }
}
