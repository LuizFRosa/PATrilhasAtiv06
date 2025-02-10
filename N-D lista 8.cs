sing System;

class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Escolha um número inteiro positivo:");
        int num = int.Parse(Console.ReadLine());
        
        if (num <= 0)
        {
            Console.WriteLine("Por favor, insira um número positivo.");
            return; 
        }

        int soma = 0;

        for (int i = 1; i <= num; i++)
        {
            soma += i; 
        }
        
        Console.WriteLine("A soma dos números de 1 até " + num + " é: " + soma);

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
