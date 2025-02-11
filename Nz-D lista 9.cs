using System;
using System.Linq;

class Program
{
    static void Main()
    {
       
      	int[] vetor = {1,2,3,4,5,6,7,9,0};
    	
    	  int maior = vetor.Max();
    	  Console.WriteLine("o maior numero é :"+maior);
        
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
