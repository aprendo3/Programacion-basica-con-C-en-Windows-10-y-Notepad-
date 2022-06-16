using System;
class A
{
    int d = 123;
    
    public void Zero()
    {
        d = 0;
    }
    
    public int D()
    {
        return d;
    }
}

class Program
{
    static void Main()
    {
        A p = new A();
        Console.WriteLine(p.D());
        p.Zero();
        Console.WriteLine(p.D());
    }
}
