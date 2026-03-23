namespace AverageOfFourApp
{
    class AverageOfFour
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise11();
                
                Console.Write("\n¿Deseas calcular otro promedio? (s/n): ");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise11()
        {
            double sum = 0;
            // El ciclo for pide exactamente 4 números
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Número {i}: ");
                
                // Leemos la entrada y la convertimos a double (para aceptar decimales)
                string entrada = Console.ReadLine() ?? "0";
                
                if (double.TryParse(entrada, out double numero))
                {
                    sum += numero;
                }
                else
                {
                    Console.WriteLine("Error: Eso no es un número. Se contará como 0.");
                }
            }

            // Calculamos el promedio dividiendo la suma total entre 4
            double promedio = sum / 4;
            Console.WriteLine($"Resultado: {promedio}");
        }
    }
}