using System;
class Program
{
    static void Main()
    {
        // Factorial
        int n = 7;
        int f = 1;
        for (int i = 2; i <= n; i++)
        {
            f = f * i; // 1 * 2 * 3 * 4 * 5
        }
        Console.Write("Factorial de {0}: {1}", n, f);
    }
}
