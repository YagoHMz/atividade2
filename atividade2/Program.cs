using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Double[] salario = new Double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o salário de n° " + (i + 1));
            Double.TryParse(Console.ReadLine(), out salario[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            if (salario[i] < 1000)
            {
                salario[i] = salario[i] + (salario[i] * 0.1);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Salarios atualizadoss:");
            Console.WriteLine("Salario " + (i + 1) + ": " + salario[i]);
        }

    }
}
