class ejercicio3
{
    static void Main()
    {
        Console.WriteLine("Ingrese a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double numerador = a / (a + b);
        double denominador = a / (a / b);

        double x = numerador / denominador;

        Console.WriteLine("El valor de x es:"+x);
    }
}