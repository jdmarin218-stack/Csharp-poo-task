namespace CirclePerimeterApp
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise4();
                Console.WriteLine("\n¿Deseas calcular otro perímetro? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise4()
        {
            Console.WriteLine("--- Cálculo del Perímetro de un Círculo ---");
            Console.Write("Radio del círculo: ");
            
            if (double.TryParse(Console.ReadLine(), out double r))
            {
                double perimetro = 2 * Math.PI * r;
                Console.WriteLine($"Resultado: {perimetro:F2}");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }
        }
    }
}