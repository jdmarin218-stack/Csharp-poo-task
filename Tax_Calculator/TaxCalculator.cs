namespace TaxCalculatorApp
{
    class TaxCalculator
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise6();
                Console.WriteLine("\n¿Deseas calcular otro impuesto? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise6()
        {
            Console.WriteLine("--- Calculadora de Impuestos (15% sobre excedente de 12,000) ---");
            Console.Write("Ingrese su salario anual: ");
            
            // TryParse es mejor para evitar errores si el usuario escribe algo mal
            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                if (salary > 12000)
                {
                    double baseGravable = salary - 12000;
                    double impuesto = baseGravable * 0.15;
                    Console.WriteLine($"Monto excedente: {baseGravable:C}");
                    Console.WriteLine($"Impuesto a pagar (15%): {impuesto:C}");
                }
                else
                {
                    Console.WriteLine("Resultado: No debe impuestos (Ingresos menores o iguales a 12,000).");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
        }
    }
}