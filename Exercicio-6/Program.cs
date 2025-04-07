namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] averageValues = new double[4];
            int qt = 0;
            string option = "0";

            while (qt <= 3)
            {
                Console.Clear();

                Console.WriteLine(" -------------------------------------------------------------------");
                Console.WriteLine($"\n CÁLCULO DA MÉDIA PONDERADA DA NOTA DE DUAS PROVAS DE UM ALUNO");
                Console.WriteLine("\n -------------------------------------------------------------------");

                string valueStr = "";

                switch (option)
                {
                    case "0":
                        Console.Write("\n Digite a nota da primeira prova: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "1":
                        Console.Write("\n Digite o peso da primeira prova: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\n Digite a nota da segunta prova: ");
                        valueStr = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("\n Digite o peso da segunda prova: ");
                        valueStr = Console.ReadLine();
                        break;
                }

                if (double.TryParse(valueStr, out double value))
                {
                    averageValues[qt] = value;
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

            double note1 = averageValues[0];
            double weightNote1 = averageValues[1];
            double note2 = averageValues[2];
            double weightNote2 = averageValues[3];

            double averageResult = ((note1 * weightNote1) + (note2 * weightNote2)) / (weightNote1 + weightNote2);

            string result = String.Format("{0:0.##}", averageResult);

            Console.Clear();

            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine($"\n A média ponderada das duas provas do aluno é: {result}");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
