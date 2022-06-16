using System;
class Program
{
    static void Main()
    {
        int[] n = new int[] { 1, 2, 3, 4, 5 };
        
        // for en decremento o invertido
        for (int i = n.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}, ", n[i]);
        }
    }
}
