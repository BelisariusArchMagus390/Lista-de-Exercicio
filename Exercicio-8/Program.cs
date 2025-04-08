namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sumValues = new double[3];
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n SOMA DE VALORES");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o valor de A: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite o valor de B: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite o valor de C: ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    sumValues[qt] = value;
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

            double A = sumValues[0];
            double B = sumValues[1];
            double C = sumValues[2];

            if ((A + B) < C)
            {
                Console.Clear();

                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n A soma de A e B é menor que C.");
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n Aperte Enter para sair...");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();

                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n A soma de A e B é maior que C.");
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n Aperte Enter para sair...");
                Console.ReadLine();
            }
        }
    }
}
