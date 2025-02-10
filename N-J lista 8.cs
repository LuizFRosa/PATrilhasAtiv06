using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("soma dos numeros de 1 a 100:");
        int soma =0;
        
        for (int i = 0; i <= 100; i+=2)
        {
        	soma+=i;
        }
        Console.WriteLine("a soma dos numeros de 1 a 100 é "+soma);
      
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
