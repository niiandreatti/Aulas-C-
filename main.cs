using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Calculadora Simples, Digite para escolher as operações");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Digite o primeiro número:");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                float num2 = float.Parse(Console.ReadLine());

                float resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("A soma deu: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("A subtração deu: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("A multiplicação deu: " + resultado);
                        break;
                    case 4:
                        if (num2 != 0)  
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("A divisão deu: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida."); 
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
