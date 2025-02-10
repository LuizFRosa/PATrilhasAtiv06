using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };
        double[] nota1 = { 8.5, 7.0, 9.2, 6.8, 7.5 };
        double[] nota2 = { 7.5, 8.0, 9.0, 7.2, 8.1 };
        
        Console.WriteLine("\nListagem de Alunos:");
        Console.WriteLine("Nome\tNota 1\tNota 2\tMédia");
        
        for (int i = 0; i < 5; i++)
        {
            double media = (nota1[i] + nota2[i]) / 2;
            Console.WriteLine("{0}\t{1}\t{2}\t{3:F2}", nomes[i], nota1[i], nota2[i], media);
        }
      
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
