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
            System.Threading.Thread.Sleep(1000);
        }
    }
}
