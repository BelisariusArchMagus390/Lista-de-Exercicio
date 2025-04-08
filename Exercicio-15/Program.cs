namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine($"\n MOSTRANDO MÚLITPLOS DE 3 E 5");
            Console.WriteLine("\n ---------------------------------------------");
            showNumbers();
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static void showNumbers()
        {
            for (int number = 1; number <= 100; number++)
            {
                if ((number % 3 == 0) && (number % 5 == 0))
                    Console.WriteLine(" FizzBuzz"); 
                else if (number % 3 == 0)
                    Console.WriteLine(" Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine(" Buzz");
                else
                    Console.WriteLine($" {number}");
            }
        }
    }
}
