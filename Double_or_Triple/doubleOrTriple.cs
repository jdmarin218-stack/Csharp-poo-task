namespace DoubleOrTripleApp
{
    class DoubleOrTriple
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise2();

                Console.WriteLine("\n¿Deseas consultar otros números? (Presiona 's' para seguir o 'n' para salir):");
                opcion = Console.ReadLine()?.ToLower() ?? "";

                // Si no presiona 's' ni 'n', podemos avisar que la opción no es válida
                if (opcion != "s" && opcion != "n")
                {
                    Console.WriteLine("Opción no reconocida. Saliendo del programa...");
                    break; // Rompe el ciclo si no es ninguna de las dos
                }

            } while (opcion == "s"); // AHORA: Solo repite si la opción es EXACTAMENTE 's'

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise2()
        {
            Console.Write("\nPrimer número: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            
            Console.Write("Segundo número: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine($"Resultado: {(a >= b ? a * 2 : b * 3)}");
        }
    }
}