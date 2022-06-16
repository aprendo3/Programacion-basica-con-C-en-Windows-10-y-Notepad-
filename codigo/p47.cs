using System;
class Program
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }
    
    static void Main()
    {
        int r = Sumar(1, 2);
        Console.WriteLine(r);
        
        r = Sumar(10, 5);
        Console.WriteLine(r);
        
        Console.WriteLine(Sumar(50, 1));
    }
}
