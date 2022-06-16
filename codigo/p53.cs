using System;
class Persona
{
    public string nombre;
    public int edad;
}

class Program
{
    static void Main()
    {
        Persona juan = new Persona();
        juan.nombre = "Juan";
        juan.edad = 30;
        
        Persona pedro = new Persona();
        pedro.nombre = "Pedro";
        pedro.edad = 20;
        
        Console.WriteLine("Nombre: {0}, Edad: {1}", 
            juan.nombre, juan.edad);
        
        Console.WriteLine("Nombre: {0}, Edad: {1}", 
            pedro.nombre, pedro.edad);
    }
}
