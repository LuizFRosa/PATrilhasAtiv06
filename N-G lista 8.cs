using System;

class Program
{
     static void Main()
    {
     	int tabuada = 5;
        
        for(int i =0; i <= 10; i++)
        {
        	
        	int resultado = tabuada *i;
        	Console.WriteLine("a tabuada do 5 é: {0} X {1} = {2}",tabuada,i,resultado);
        }
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
