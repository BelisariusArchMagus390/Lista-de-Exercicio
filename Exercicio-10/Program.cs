namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] imcValues = new double[2];
            int qt = 0;
            string option = "0";

            while (qt <= 1)
            {
                Console.Clear();

                Console.WriteLine(" ---------------------------");
                Console.WriteLine($"\n CÁLCULO DE IMC DE UM ADULTO");
                Console.WriteLine("\n ---------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o peso do adulto (em Kg): ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite a altura da adulto (em M): ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    imcValues[qt] = value;
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

            double weight = imcValues[0];
            double height = imcValues[1];

            double lol = (Math.Pow(height, 2));
            double imcResult = weight / lol;
            string result = String.Format("{0:0.##}", imcResult);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n IMC da pessoa: {result}");
            Console.WriteLine("\n ---------------------------------------");

            showImcResults(imcResult);

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }

        static void showImcResults(double imc)
        {
            if (imc < 18.5)
                Console.WriteLine("\n Condição: Abaixo do peso.");
            else if ((imc > 18.5) && (imc < 25))
                Console.WriteLine("\n Condição: Peso normal.");
            else if ((imc > 25) && (imc < 30))
                Console.WriteLine("\n Condição: Acima do peso.");
            if (imc > 30)
                Console.WriteLine("\n Condição: Obeso.");
        }
    }
}
