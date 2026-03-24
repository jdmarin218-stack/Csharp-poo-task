namespace InRangeValidatorApp
{
    class InRangeValidator
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise15();
                
                Console.Write("\n¿Deseas validar otro número? (s/n): ");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise15()
        {
            Console.Write("Ingresa un número para validar si está entre 10 y 20: ");
            
            // Leemos la entrada y la convertimos a entero
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // Validamos si n está en el rango [10, 20] usando un operador ternario
                string resultado = (n >= 10 && n <= 20) 
                    ? "Resultado: Está en el rango." 
                    : "Resultado: Fuera del rango.";
                
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Error: Por favor ingresa un número entero válido.");
            }
        }
    }
}