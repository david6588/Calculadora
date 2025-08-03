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
            //Parte de Omar toledo


            //entre este espacio ponelo despues borras estas guiass
        }
    }
    //PARTE DE DANY Toledo 
   
    
    //Ponelo aca adentro y despues borras estas barras
}
