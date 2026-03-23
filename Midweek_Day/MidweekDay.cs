namespace MidweekDayApp
{
    class MidweekDay
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise5();
                Console.WriteLine("\n¿Deseas consultar otro día? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise5()
        {
            Console.WriteLine("--- Verificador de Días Laborales ---");
            Console.Write("Ingresa un número (1-7): ");
            
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                // Arreglo con los días de lunes a viernes
                string[] days = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

                // Si el número está entre 1 y 5 (Lunes a Viernes)
                if (day >= 1 && day <= 5)
                {
                    Console.WriteLine($"Resultado: {days[day - 1]}");
                }
                // Si es 6 o 7 (Sábado o Domingo) o fuera de rango
                else if (day == 6 || day == 7)
                {
                    Console.WriteLine("Resultado: Es fin de semana (no es día laboral).");
                }
                else
                {
                    Console.WriteLine("Resultado: Número fuera del rango (1-7).");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
            }
        }
    }
}