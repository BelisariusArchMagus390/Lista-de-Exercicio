namespace Exercicio_1
{
    internal class Program
    {
        static decimal[] volumeValues = new decimal[3];

        static void Main(string[] args)
        {
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();

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

                if (decimal.TryParse(valueStr, out decimal value))
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

            decimal resultVolume = volumeValues[0] * volumeValues[1] * volumeValues[2];

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O volume da caixa é: {resultVolume}");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
