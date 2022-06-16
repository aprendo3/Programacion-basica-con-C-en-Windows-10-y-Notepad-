using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
        
        if (args.Length > 0)
        {
            Console.WriteLine(args[0]);
        }
        
        if (args.Length > 1)
        {
            Console.WriteLine(args[1]);
        }
        
        if (args.Length > 2)
        {
            Console.WriteLine(args[2]);
        }
    }
}
