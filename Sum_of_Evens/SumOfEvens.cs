namespace SumOfEvensApp
{
    class SumOfEvens
    {
        static void Main(string[] args)
        {
            Exercise8();
        }

        static void Exercise8()
        {
            int sum = 0;
            // Suma los pares: 2, 4, 6... hasta 50
            for (int i = 2; i <= 50; i += 2) 
            {
                sum += i;
            }
            Console.WriteLine($"La suma de los números pares del 2 al 50 es: {sum}");
        }
    }
}