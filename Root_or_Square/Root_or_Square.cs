namespace RootOrSquareApp
{
    class RootOrSquare
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise3();

                Console.WriteLine("\n¿Deseas consultar otro número? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";

            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise3()
        {
            Console.Write("\nIngresa un número: ");
            // Usamos double para permitir decimales y raíces exactas
            double n = double.Parse(Console.ReadLine() ?? "0");

            if (n > 0)
            {
                // Calcula la raíz cuadrada
                Console.WriteLine($"Resultado (Raíz): {Math.Sqrt(n)}");
            }
            else if (n == 0)
            {
                Console.WriteLine("Resultado: 0");
            }
            else
            {
                // Calcula el cuadrado para números negativos
                Console.WriteLine($"Resultado (Cuadrado): {n * n}");
            }
        }
    }
}