using System;
class Program
{
    static void Main()
    {
        int i = 0;
        while(true)
        {
            Console.WriteLine(i);
            i = i + 1;
            if (i > 3) // si i > 3 rompe el ciclo
            {
                break;
            }
        }
    }
}
