class ejercicio5
{
    static void Main()
    {
        Console.WriteLine("Ingrese a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double resultado = (a + b + c) / (a + (b / c));

        Console.WriteLine($"Resultado: {resultado}");
    }
}