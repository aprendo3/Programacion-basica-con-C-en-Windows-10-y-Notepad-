using System;
class Program
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        bool c = a < b;
        Console.WriteLine(c);
        if (c)
        {
            Console.WriteLine("{0} > {1}", a, b);
        }
    }
}
