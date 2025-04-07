namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sellerValues = new double[3];
            int qt = 0;
            string option = "0";

            while (qt <= 2)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n CÁLCULO DE SALÁRIO TOTAL DE VENDEDORES");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite o salário base do(a) vendedor(a): ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite o total de vendas: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite o percentual da comissão (em número inteiro): ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    sellerValues[qt] = value;
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

            double baseSalary = sellerValues[0];
            double totalSales = sellerValues[1];
            double comission = sellerValues[2] / 100;

            double totalSalary = (totalSales * comission) + baseSalary;

            string result = totalSalary.ToString("C2");

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n O salário total do(a) vendedor(a) é: {result}");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
