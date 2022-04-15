using System;

namespace ExercicioTurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Bem vindo ao Banco Cast, vamos realizar seu cadastro!");
            Console.Write("Digite Seu Nome: ");
            string nome = Console.ReadLine();
            int numConta = new Random().Next(1000, 9999);
            Console.WriteLine("Seu número de conta será: " + numConta);
            Console.Write("Você deseja fazer um saque inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if(resposta == 's')
            {
                Console.Write("Digite o valor do deposito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numConta, nome, deposito);

            }
            else
            {
                conta = new ContaBancaria(numConta, nome);
            }
            Console.WriteLine(conta);
            Console.Write("Realizar Deposito !\nDigite o Valor: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("\nDados Atualizados ! \n " + conta);
            Console.Write("Realizar Saque !\nDigite o Valor: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("\nDados Atualizados ! \n " + conta);
        }
    }
}
