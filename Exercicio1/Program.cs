using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota:");
            int nota = int.Parse(Console.ReadLine());
           
            while(nota >= 10){
            Console.WriteLine("Valor inválido, Digite o valor novamente");
            Console.WriteLine("Digite a nota: ");
            nota = int.Parse(Console.ReadLine());
            }

        }
    }
}
