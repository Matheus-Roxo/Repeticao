using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o usuário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            while(nome == senha){
            Console.WriteLine("A senha deve ser diferente do usuário, digite uma nova senha: ");
            Console.WriteLine("Digite a sua senha: ");
            senha = Console.ReadLine();
            }
            Console.WriteLine("Você foi cadastrado com sucesso!");
        }
    }
}
