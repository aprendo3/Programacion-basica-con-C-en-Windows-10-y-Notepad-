using System;
class Program
{
    static void Par(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("{0} es par", a);
        }
        else
        {
            Console.WriteLine("{0} es impar", a);
        }
    }
    
    static void Main()
    {
        Par(2);
        Par(3);
        Par(50);
        Par(111);
        Par(1024);
    }
}
