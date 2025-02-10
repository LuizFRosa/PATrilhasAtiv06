using System;
	

class Program
{
   public static void Main()
    {
   	Console.WriteLine("digite uma palavra");
   	string palavra = (Console.ReadLine());
   	
   	for (int i = 0; i < palavra.Length; i++)
    	{
   		Console.WriteLine(palavra[i]);
    		
    	}
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
