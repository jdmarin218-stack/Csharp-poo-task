namespace StringLengthApp
{
    class StringLength
    {
        static void Main(string[] args)
        {
            
            string opcion;
            do
            {
                Exercise10();
                
                Console.WriteLine("\n¿Deseas Ingresar otro String? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
                
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }
        

        static void Exercise10()
        {
            Console.Write("Ingresa una palabra: ");
            string word = Console.ReadLine() ?? "";
            Console.WriteLine($"Resultado: {word.Length}");
        }
    }
}