namespace VowelCounterApp
{
    class VowelCounter
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise13();
                
                Console.Write("\n¿Deseas contar las vocales de otra palabra? (s/n): ");
                opcion = Console.ReadLine()?.ToLower() ?? "";
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }

        static void Exercise13()
        {
            Console.Write("Ingresa una palabra o frase: ");
            // Convertimos a minúsculas para no tener que validar "A, E, I, O, U" por separado
            string word = Console.ReadLine()?.ToLower() ?? "";
            
            int count = 0;
            // Definimos qué caracteres consideramos vocales
            string vocales = "aeiouáéíóú";

            foreach (char c in word)
            {
                // Si el caracter actual está en nuestra lista de vocales, sumamos 1
                if (vocales.Contains(c)) 
                {
                    count++;
                }
            }

            Console.WriteLine($"Resultado: {count} vocales encontradas.");
        }
    }
}