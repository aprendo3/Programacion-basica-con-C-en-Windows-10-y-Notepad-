using System;
class Program
{
    static void Main()
    {
        int[] n = new int[5];
        
        // iniciar el arreglo
        for (int i = 0; i < n.Length; i++)
        {
            n[i] = i;
        }
        
        // mostrar el arreglo
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write("{0}, ", n[i]);
        }
    }
}
