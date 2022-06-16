using System;
class Program
{
    int d;
    
    void Zero()
    {
        d = 0;
    }
    
    static void Main()
    {
        Program p = new Program();
        p.d = 123;
        Console.WriteLine(p.d);
        p.Zero();
        Console.WriteLine(p.d);
    }
}
