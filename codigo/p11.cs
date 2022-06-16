using System;
class Program
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        if (a == b)
        {
            Console.WriteLine("{0} == {1}", a, b);
        }
        else if (a > b)
        {
            Console.WriteLine("{0} > {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} < {1}", a, b);
        }
    }
}
