using System;

class Program
{
    static void Main()
    {
        while (true)



        {

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado;


            Console.WriteLine("\nBienvenido a la Calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
                continue;
            }

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo de la Calculadora...");
                break;
            }
            switch (opcion)
            {
                case 1:
                    resultado = Sumar(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                    resultado = Restar(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    resultado = Multiplicar(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine("Error: División por cero.");
                    else
                    {
                        resultado = Dividir(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
     static double Sumar(double a, double b) => a + b;
    static double Restar(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b) => a / b;
}
