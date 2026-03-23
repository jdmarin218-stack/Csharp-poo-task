namespace RemainderFinderApp
{
    class RemainderFinder
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise7();
                
                Console.WriteLine("\n¿Deseas realizar otro cálculo? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
                
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise7()
        {
            // Mensaje de solicitud para que sepas qué ingresar
            Console.Write("Ingresa los números : ");
            
            string entrada = Console.ReadLine() ?? "";
            string[] partes = entrada.Split('.', ','); // Permite separar por punto o coma

            if (partes.Length == 2)
            {
                // Usamos double para que acepte enteros y flotantes
                if (double.TryParse(partes[0].Trim(), out double a) && 
                    double.TryParse(partes[1].Trim(), out double b))
                {
                    if (b != 0)
                    {
                        // Residuo
                        Console.WriteLine($"Resultado: {a % b}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Debes separar los números con una coma.");
            }
        }
    }
}