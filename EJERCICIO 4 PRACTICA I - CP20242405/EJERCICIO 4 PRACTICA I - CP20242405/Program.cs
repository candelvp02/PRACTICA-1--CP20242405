﻿class ejercicio4
{
    static void Main()
    {
        Console.WriteLine("Ingrese a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double numerador = a + (b / (a + b + (b / c)));
        double denominador = (a + (b / c)) / (c + a);

        double x = numerador / denominador;

        Console.WriteLine("El valor de x es: " + x);
    }
}