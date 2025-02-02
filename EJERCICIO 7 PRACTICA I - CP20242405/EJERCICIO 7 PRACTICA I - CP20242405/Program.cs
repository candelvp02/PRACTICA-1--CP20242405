class ejercicio7
{
    static void Main()
    {
        Console.WriteLine("Ingrese a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese d: ");
        double d = Convert.ToDouble(Console.ReadLine());

        double resultado = (a + (b / c) + d) / a;

        Console.WriteLine($"Resultado: {resultado}");
    }
}