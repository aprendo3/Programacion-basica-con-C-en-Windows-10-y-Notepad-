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
            
            Console.Write("{0}, ", i);
            
            if (i == 7)
            {
                break;
            }
        }
    }
}
