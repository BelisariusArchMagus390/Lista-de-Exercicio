namespace Exercicio_14
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
                Console.WriteLine($"\n NÚMERO DE FIBONACCI");
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
            Console.WriteLine("\n F1 = 1");
            Console.WriteLine(" F2 = 1");
            fibonacciNumber(number, 1, 1, 3);

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static void fibonacciNumber(int originalNumber, int firstNumber, int secondNumber, int cont)
        {
            int thirdNumber = 0;

            if (secondNumber != originalNumber)
            {
                thirdNumber = firstNumber + secondNumber;

                Console.WriteLine($" F{cont} = {firstNumber} + {secondNumber} = {thirdNumber}");

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                cont++;

                fibonacciNumber(originalNumber, firstNumber, secondNumber, cont);
            }
        }
    }
}
