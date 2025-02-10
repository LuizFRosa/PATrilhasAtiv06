using System;
	

class Program
{
   public static void Main()
    {
   	Console.WriteLine("escolha um numero inteiro positivo");
   	int num = int.Parse(Console.ReadLine());
   	
   	for (int i = 0; i < num; i += 2)
    	{
    		Console.WriteLine(i);
    		
    	}
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
