using System;
class Program
{
    static void Main()
    {
        // intercalar 2 arreglos
        int[] a1 = new int[] { 0, 2, 4, 6, 8 };
        int[] a2 = new int[] { 1, 3, 5, 7, 9 };
        
        int[] a3 = new int[a1.Length + a2.Length];
        int j = 0;
        
        for (int i = 0; i < a1.Length; i++, j++)
        {
            a3[j] = a1[i];
            j++;
            a3[j] = a2[i];
        }
        
        for (j = 0; j < a3.Length; j++)
        {
            Console.Write("{0}, ", a3[j]);
        }
    }
}
