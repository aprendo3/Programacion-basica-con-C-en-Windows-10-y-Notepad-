using System;
class Program
{
    static void Main()
    {
        // contar del 0 al 7, sin el 5
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            
            if (i == 7)
            {
                break;
            }
            
            Console.Write("{0}, ", i);
        }
    }
}
