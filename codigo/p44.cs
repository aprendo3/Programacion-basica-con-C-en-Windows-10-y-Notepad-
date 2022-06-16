using System;
class Program
{
    static void Main()
    {
        // ordenar un arreglo
        int[] a = new int[] { 4, 1, 5, 3, 2};
        int d;

        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    d = a[i];
                    a[i] = a[j];
                    a[j] = d;
                }
            }
        }
        
        for (int j = 0; j < a.Length; j++)
        {
            Console.Write("{0}, ", a[j]);
        }
    }
}
