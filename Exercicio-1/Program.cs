﻿namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] volumeValues = new double[3];
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();
                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine($"\n CÁLCULO DO VOLUME DE UMA CAIXA RETANGULAR");
                Console.WriteLine("\n ---------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o comprimento da caixa: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite a largura da caixa: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite a altura da caixa: ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    volumeValues[qt] = value;
                    qt += 1;
                    option = qt.ToString();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Erro! Foi digitado letras ou múltiplos números.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            double length = Math.Abs(volumeValues[0]);
            double width = Math.Abs(volumeValues[1]);
            double height = Math.Abs(volumeValues[2]);

            double volume = length * width * height;
            string result = String.Format("{0:0.##}", volume);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O volume da caixa é: {result}");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
