using System;

namespace _01_04
{
    class Program
    {
        delegate int Operacao(int a, int b);

        static void Main(string[] args)
        {
            Operacao operacao = (x, y) => x + y; //expressão lambda
            Console.WriteLine(operacao(3, 2));

            // Delegado de Função (possui retorno)
            Func<int, int, int> somar = (x, y) => x + y;
            Console.WriteLine(somar(3, 2));

            // Delegado de Ação (não possui retorno)
            Action<string> imprimirMensagem = 
                (mensagem) => 
                {
                    Console.WriteLine(mensagem);
                };

            imprimirMensagem("Olá, Alura!");

            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Números divisíveis por 3:");
            // Predicate é um tipo de Delegado que por padrão retorna um valor booleano
            Predicate<int> divisivelPor3 = (numero) => numero % 3 == 0;
            // Retorna uma nova lista, com todos os números que atendem ao Predicate(divisivelPor3)
            var divisiveis = Array.FindAll(numeros, divisivelPor3);

            foreach (var numero in divisiveis)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}