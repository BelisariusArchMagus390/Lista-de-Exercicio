namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine($"\n NÚMEROS ÍMPARES ENTRE 100 E 200");
            Console.WriteLine("\n ---------------------------------------------");
            showOddNumbers();
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static void showOddNumbers()
        {
            for (int number = 100; number <= 200; number++)
            {
                if (number % 2 != 0)
                    Console.WriteLine($" {number}");
            }
        }
    }
}
