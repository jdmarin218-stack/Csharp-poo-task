namespace SmallestOfFiveApp
{
    class SmallestOfFive
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise12();
                
                Console.Write("\n¿Deseas buscar otro número menor? (s/n): ");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise12()
        {
            // Pedimos el primer número para tener un punto de comparación inicial
            Console.Write("Número 1: ");
            if (!int.TryParse(Console.ReadLine(), out int min)) min = 0;

            // El ciclo for pide los 4 números restantes
            for (int i = 2; i <= 5; i++)
            {
                Console.Write($"Número {i}: ");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    // Si el nuevo número es menor al que ya teníamos, actualizamos min
                    if (n < min) min = n;
                }
            }
            
            Console.WriteLine($"Resultado (el menor es): {min}");
        }
    }
}