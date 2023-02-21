using Programa05_1.Modelo;
using System;

namespace Programa05
{
    class Program
    {
        static void Main(string[] args)
        {

            //TAREFA 1: obter as propriedades de CarrinhoCliente
            var tipo = typeof(CarrinhoCliente);
            var propriedades = tipo.GetProperties();

            foreach (var propriedade in propriedades)
            {
                Console.WriteLine("Propriedade: {0}", propriedade.Name);

                //TAREFA 2: descobrir se podem ler ou escrever
                if (propriedade.CanRead)
                {
                    Console.WriteLine("\tPode ler");
                    Console.WriteLine("\t\tMétodo get: {0}", propriedade.GetMethod);
                }

                if (propriedade.CanWrite)
                {
                    //TAREFA 3: descobrir seus acessadores getters e setters
                    Console.WriteLine("\tPode escrever");
                    Console.WriteLine("\t\tMétodo set: {0}", propriedade.SetMethod);
                }
            }

            Console.ReadLine();
        }
    }
}
