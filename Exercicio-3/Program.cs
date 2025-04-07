namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] travelValues = new double[3];
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n CÁLCULO DE COMBÚSTIVEL CONSUMIDO POR KILÔMETRO PERCORRIDO");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite a quilometeragem inicial do veículo no início da viagem: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite a quilometragem final ao término da viagem: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite a quantidade de combustível consumida durante a viagem (em litros): ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    travelValues[qt] = value;
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

            double initialMiles = travelValues[0];
            double finalMiles = travelValues[1];
            double qtFuel = travelValues[2];

            double fuelByMiles = qtFuel / (finalMiles - initialMiles);

            string result = String.Format("{0:0.##}", fuelByMiles);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O consumo de combustível por quilômetro percorrido durante a viagem é: {result} L/Km");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
