using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has seleccionado Suma");
                break;
            case 2:
                Console.WriteLine("Has seleccionado Resta");
                break;
            case 3:
                Console.WriteLine("Has seleccionado Multiplicación");
                break;
            case 4:
                Console.WriteLine("Has seleccionado División");
                break;
            case 5:
                Console.WriteLine("Saliendo de la Calculadora...");
                return;
        }
        Console.WriteLine("Operación no válida. Por favor, intente de nuevo.");

        // TODO: Implementar la lógica de menú
    }
    
    
    {
        
        default:
    }


    // TODO: Implementar funciones de suma, resta, multiplicación, división
}