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
                Console.WriteLine($"\n ORDEM DECRESCENTE DE TRÊS VALORES.");
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

            showValues(arrayValues);
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
            int length = arrayValues.Length;

            for (int outer = 0; outer < length; outer++)
            {
                int val = arrayValues[outer];

                for (int inter = 0; inter < length; inter++)
                {
                    if ((arrayValues[inter] > val))
                    {
                        arrayValues[outer] = arrayValues[inter];
                        arrayValues[inter] = val;
                    }
                }
            }

            return arrayValues;
        }

        static void showValues(int[] arrayValues)
        {
            foreach (int number in arrayValues)
                Console.WriteLine(number);
        }
    }
}
