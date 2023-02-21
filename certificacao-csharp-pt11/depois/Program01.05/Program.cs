using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._05
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarefa1 = new Task(() => ExecutaTrabalho(1)); // Uma tarefa/task que recebe uma acao/action
            tarefa1.Start(); // Para uma Task ser executada é preciso que ela seja iniciada
            tarefa1.Wait(); // Uma Task trabalha de maneira assincrona, o Wait epera a Task ser completada pra continuar a execucao 

            var tarefa2 = Task.Run(() => ExecutaTrabalho(2));
            tarefa2.Wait();

            var tarefa3 = Task.Run(() =>
            {
                return CalcularResultado(2, 3);
            });

            Console.WriteLine("O resultado é: {0}", tarefa3.Result);

            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        public static void ExecutaTrabalho(int item)
        {
            Console.WriteLine("Trabalho iniciado: {0}", item);
            Thread.Sleep(2000);
            Console.WriteLine("Trabalho terminado: {0}", item);
            Console.WriteLine();
        }

        public static int CalcularResultado(int numero1, int numero2)
        {
            Console.WriteLine("Trabalho iniciado");
            Thread.Sleep(2000);
            Console.WriteLine("Trabalho terminado");
            Console.WriteLine();
            return numero1 + numero2;
        }
    }
}
