using System;
class Program
{
    static void Main()
    {
        int a = 2;
        if (a % 2 == 0)
        {
            Console.WriteLine("{0} es par", a);
        }
        else
        {
            Console.WriteLine("{0} es impar", a);
        }
        
        a = 3;
        if (a % 2 == 0)
        {
            Console.WriteLine("{0} es par", a);
        }
        else
        {
            Console.WriteLine("{0} es impar", a);
        }
        
        a = 50;
        if (a % 2 == 0)
        {
            Console.WriteLine("{0} es par", a);
        }
        else
        {
            Console.WriteLine("{0} es impar", a);
        }
    }
}
