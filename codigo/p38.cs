using System;
class Program
{
    static void Main()
    {
        int[] n = new int[] { 2, 1, 4, 3, 1 };
        int pares = 0;
        
        // contar los numeros par en un arreglo
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 2 == 0)
            {
                pares++;
            }
        }
        
        Console.Write("Total de pares: {0}", pares);
    }
}
