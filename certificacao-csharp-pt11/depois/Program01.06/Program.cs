using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de threads:");
            Console.WriteLine(Process.GetCurrentProcess().Threads.Count);

            Task[] tarefas = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                /*
                 Quando se trabalha de forma assincrona as chamadas para o método Correr() estao competindo com a execucao do método Main.
                 A primeira vez que o método Correr é chamado já teremos executado 10x o for 
                 */
                // Guardar o valor de i numa variável LOCAL, faz com que o valor seja preservado!
                int numeroCorredor = i;

                var tarefa = Task.Run(() => Correr(numeroCorredor));
                tarefas[i] = tarefa;
            }

            Task.WaitAll(tarefas); // Aguardando a execucao de todas as tarefas assincronas

            Console.WriteLine("Número de threads:");
            Console.WriteLine(Process.GetCurrentProcess().Threads.Count);


            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        public static void Correr(int numeroCorredor)
        {
            Console.WriteLine("Corredor {0} largou", numeroCorredor);

            Thread.Sleep(1000);
            Console.WriteLine("Corredor {0} terminou", numeroCorredor);
        }
    }
}
