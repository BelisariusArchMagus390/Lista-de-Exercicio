namespace Exercicio_13
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
                Console.WriteLine($"\n FATORIAL DE UM NÚMERO");
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
                    Console.WriteLine("\n Erro! O que foi digitado não é um número inteiro.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");

            Console.Write($"\n {number}! =");
            factorial(number, 1);

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static void factorial(int number, int res)
        {
            if (number == 1)
            {
                res *= number;
                Console.Write($" {number} = {res}\n");
            }   
            else
            {
                res *= number;
                Console.Write($" {number} X");
                factorial((number-1), res);
            }
        }
    }
}
