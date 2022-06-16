using System;
class Program
{
    static void Main()
    {
        int[] a1 = new int[] { 0, 2, 4, 6, 8 };
        int[] a2 = new int[] { 1, 3, 5, 7, 9 };
        
        for (int i = 0; i < a1.Length; i++)
        {
            Console.Write("{0}, ", a1[i]);
            Console.Write("{0}, ", a2[i]);
        }
    }
}
