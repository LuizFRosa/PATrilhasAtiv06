using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número inteiro para verificar se é primo:");
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine(num + " não é um número primo.");
        }
        else
        {
            bool isPrimo = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)  
                {
                    isPrimo = false;
                    break;
                }
            }

            if (isPrimo)
                Console.WriteLine(num + " é um número primo.");
            else
                Console.WriteLine(num + " não é um número primo.");
        }
              Console.WriteLine("Clique qualquer botão para encerrar...");
              Console.ReadKey();
    }
}
