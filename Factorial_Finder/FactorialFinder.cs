namespace FactorialFinderApp
{
    class FactorialFinder
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise14();
                
                Console.Write("\n¿Deseas calcular otro factorial? (s/n): ");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise14()
        {
            Console.Write("Ingresa un número para calcular su factorial: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n < 0)
                {
                    Console.WriteLine("Error: El factorial no está definido para números negativos.");
                    return;
                }

                long factorial = 1;
                // El ciclo multiplica 1 * 2 * 3... hasta n
                for (int i = 2; i <= n; i++) 
                {
                    factorial *= i;
                }

                Console.WriteLine($"Resultado (!{n}): {factorial}");
            }
            else
            {
                Console.WriteLine("Error: Por favor ingresa un número entero válido.");
            }
        }
    }
}