using System;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            return;
        }
        //1 + 2
        int a = int.Parse(args[0]);
        int b = int.Parse(args[2]);
        string op = args[1];
        int r = 0;
        
        switch(op)
        {
            case "+": 
                r = Sum(a, b);
                break;
            case "-": 
                r = Sub(a, b);
                break;
            case "*": 
                r = Mul(a, b);
                break;
            case "/": 
                r = Div(a, b);
                break;
        }
        
        Console.WriteLine("{0} {1} {2} = {3}", a, op, b, r);
    }
    
    static int Sum(int a, int b)
    {
        return a + b;
    }
    
    static int Sub(int a, int b)
    {
        return a - b;
    }
    
    static int Mul(int a, int b)
    {
        return a * b;
    }
    
    static int Div(int a, int b)
    {
        return a / b;
    }
}
