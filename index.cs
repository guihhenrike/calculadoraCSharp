using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                Console.WriteLine("Saindo...");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
