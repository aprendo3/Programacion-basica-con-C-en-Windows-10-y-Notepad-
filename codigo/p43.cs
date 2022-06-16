using System;
class Program
{
    static void Main()
    {
        // invertir un arreglo
        int[] a = new int[] { 1, 2, 3, 4, 5};
        int d;
        int j = a.Length - 1;

        for (int i = 0; i < a.Length / 2; i++, j--)
        {
            d = a[i];
            a[i] = a[j];
            a[j] = d;
        }
        
        for (j = 0; j < a.Length; j++)
        {
            Console.Write("{0}, ", a[j]);
        }
    }
}
