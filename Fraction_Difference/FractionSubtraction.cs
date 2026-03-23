namespace FractionApp
{
    class FractionSubtraction
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Exercise9();
                
                Console.WriteLine("\n¿Deseas realizar otra fracción? (s/n):");
                opcion = Console.ReadLine()?.ToLower() ?? "";
                
            } while (opcion == "s");

            Console.WriteLine("¡Programa finalizado!");
        }
    

        static void Exercise9()
        {
            Console.Write("Ingresa la primera fracción (ej: 1/2): ");
            string[] f1 = Console.ReadLine().Split('/');
            
            Console.Write("Ingresa la segunda fracción (ej: 1/4): ");
            string[] f2 = Console.ReadLine().Split('/');

            int n1 = int.Parse(f1[0]);
            int d1 = int.Parse(f1[1]);
            int n2 = int.Parse(f2[0]);
            int d2 = int.Parse(f2[1]);

            int numResult = n1 * d2 - n2 * d1;
            int denResult = d1 * d2;

            int gcd = GCD(Math.Abs(numResult), Math.Abs(denResult));

            if (numResult == 0) Console.WriteLine("Resultado: 0");
            else Console.WriteLine($"Resultado: {numResult / gcd}/{denResult / gcd}");
        }

        static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
    }
}