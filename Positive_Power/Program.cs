namespace Positive_Power {
    

    class Program {
        static void Main(string[] args) {
        
            Exercise1();
        }

        static void Exercise1()
        {
            Console.Write("Ingresa un número: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)       Console.WriteLine($"Resultado: {n * n}");
            else if (n == 0) Console.WriteLine("Resultado: 0");
            else             Console.WriteLine("Resultado: Número negativo.");
        }
    }
}