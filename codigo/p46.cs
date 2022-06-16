using System;
class Program
{
    static int Duplicar(int a)
    {
        return 2 * a;
    }
    
    static void Main()
    {
        int a = Duplicar(2);
        Console.WriteLine(a);
        
        a = Duplicar(7);
        Console.WriteLine(a);
        
        a = Duplicar(21);
        Console.WriteLine(a);
    }
}
