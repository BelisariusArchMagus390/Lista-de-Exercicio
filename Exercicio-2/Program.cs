namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] volumeValues = new double[2];
            int qt = 0;
            string option = "0";

            while (qt <= 1)
            {
                Console.Clear();

                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine($"\n CÁLCULO DO VOLUME DE UM CILINDRO");
                Console.WriteLine("\n ---------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o raio do cilindro: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite a altura do cilindro: ");
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

            double pi = Math.PI;
            double radius = Math.Abs(volumeValues[0]);
            double height = Math.Abs(volumeValues[1]);

            double volume = pi * Math.Pow(radius, 2) * height;
            string result = String.Format("{0:0.##}", volume);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O volume do cilindro é: {result}");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
