using System;
class Program
{
    static void Main()
    {
        int[] n = new int[] { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Longitud: {0}, ", n.Length);
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write("{0}, ", n[i]);
        }
    }
}
