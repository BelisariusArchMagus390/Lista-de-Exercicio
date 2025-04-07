namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsiusValue = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n CONVERSÃO DE VALOR EM CELSIUS PARA FAHRENHEIT");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string celsiusValueStr = "";

                Console.Write("\n Digite o valor de temperatura em Celsius (ºC): ");
                celsiusValueStr = Console.ReadLine();

                if (double.TryParse(celsiusValueStr, out double value))
                {
                    celsiusValue = value;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Erro! Foi digitado letras ou múltiplos números.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            double fahrenheitValue = (celsiusValue * 1.8) + 32;

            string result = String.Format("{0:0.##}", fahrenheitValue);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O valor da temperatura informada em Fahrenheit é: {result} ºF");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
