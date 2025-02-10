using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números primos de 1 a 100:");
        
        for (int num = 2; num <= 100; num++)
        {
            bool ehPrimo = true;
            
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
            
            if (ehPrimo)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
