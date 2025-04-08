namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayValues = new int[3];
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n ORDEM DECRESCENTE DE TRÊS VALORES");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o primeiro valor (apenas números inteiros): ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite o segundo valor (apenas números inteiros): ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite o terceiro valor (apenas números inteiros): ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (int.TryParse(valueStr, out int value))
                {
                    if (checkIfHaventNumber(arrayValues, value))
                    {
                        arrayValues[qt] = value;
                        qt += 1;
                        option = qt.ToString();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n Erro! Esse valor já foi digitado.");
                        Console.WriteLine(" Aperte Enter para continuar...");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Erro! O que foi digitado não é um número inteiro.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            arrayValues = sortArray(arrayValues);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------------\n");

            showValues(arrayValues);

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static bool checkIfHaventNumber(int[] arrayValues, int value)
        {
            bool response = false;
            foreach (int number in arrayValues)
            {
                if (value == number)
                {
                    response = false;
                    break;
                }
                else
                    response = true;
            }
            return response;
        }

        static int[] sortArray(int[] arrayValues)
        {
            while (true)
            {
                Console.WriteLine("lol");
                if (arrayValues[0] < arrayValues[1])
                {
                    int first = arrayValues[0];
                    int second = arrayValues[1];

                    arrayValues[0] = second;
                    arrayValues[1] = first;
                }

                if (arrayValues[1] < arrayValues[2])
                {
                    int first = arrayValues[1];
                    int second = arrayValues[2];

                    arrayValues[1] = second;
                    arrayValues[2] = first;
                }

                if ((arrayValues[0] > arrayValues[1]) && (arrayValues[1] > arrayValues[2]))
                {
                    break;
                }
            }

            return arrayValues;
        }

        static void showValues(int[] arrayValues)
        {
            foreach (int number in arrayValues)
                Console.WriteLine($" {number}");
        }
    }
}
