namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            int contPrimus = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n VERIFICAÇÃO DE NÚMERO PRIMO");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string ifPrimusNumberStr = "";

                Console.Write("\n Digite o número que quer verificar se é um primo: ");
                ifPrimusNumberStr = Console.ReadLine();

                if (double.TryParse(ifPrimusNumberStr, out double value))
                {
                    number = value;
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

            for (int divNumber = 1; divNumber <= number; divNumber++)
            {
                if ((number % divNumber) == 0)
                    contPrimus++;
            }

            if ((number == 1) || (number == 0) || (contPrimus > 2))
            {
                Console.Clear();
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine($"\n O número {number} não é primo!");
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n Aperte Enter para sair...");
                Console.ReadLine();
            }
            else if (contPrimus == 2)
            {
                Console.Clear();
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine($"\n O número {number} é primo!");
                Console.WriteLine("\n ---------------------------------------");
                Console.WriteLine("\n Aperte Enter para sair...");
                Console.ReadLine();
            }
        }
    }
}
