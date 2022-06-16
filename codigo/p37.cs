using System;
class Program
{
    static void Main()
    {
        int[] n = new int[] { 2, 1, 4, 3, 1 };
        int suma = 0;
        
        // sumar un arreglo
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(" + {0}", n[i]);
            suma += n[i];
        }
        
        Console.Write(" = {0}", suma);
    }
}
