namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.Clear();

                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine($"\n IDENTIFICAÇÃO DO NÚMERO SE É PAR OU ÍMPAR");
                Console.WriteLine("\n ---------------------------------------------");

                string numberStr = "";

                Console.Write("\n Digite um número (apenas inteiros): ");
                numberStr = Console.ReadLine();

                if (int.TryParse(numberStr, out number))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Erro! O que foi digitado não é número inteiro.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");

            if ((number % 2) == 0)
                Console.WriteLine("\n Esse número é par!");
            else
                Console.WriteLine("\n Esse número é ímpar!");
            
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
