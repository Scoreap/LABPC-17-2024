﻿class T2SACP1185324E1
{
    static void Main(string[] args)
    {
        double vi = 0;
        double a = 0;
        double t = 0;
        double vf = 0;

        
        Console.WriteLine("Ingrese la velocidad inicial: ");
        vi = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la aceleración: ");
        a =double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tiempo: ");
        t = double.Parse(Console.ReadLine());
        vf = vi + (a * t);

        Console.WriteLine("La velocidad final = " + vf);

        Console.ReadKey();
    } 
}