using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: Criar e executar uma tarefa-mãe e 10 tarefas-filhas que levam 1s cada uma para terminar.

            // O Factory cria uma nova Task.
            var tarefaMae =
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa-mãe iniciou.");

                    for (int i = 0; i < 10; i++)
                    {
                        int tarefaId = i;

                        // O primeiro parametro é a Action a ser executada
                        // O segunda parametro é o identificador da Task Filha
                        // O terceiro parametro anexa a Task a Task Mae que a encapsula, definindo uma hierarquia
                        var tarefaFilha = 
                            Task.Factory.StartNew((id) => ExecutarFilha(id), tarefaId, TaskCreationOptions.AttachedToParent);
                    }
                });

            tarefaMae.Wait();
            Console.WriteLine("Tarefa-mãe terminou.");

            Console.ReadLine();
        }

        private static void ExecutarFilha(object i)
        {
            Console.WriteLine("\tTarefa-filha {0} iniciou.", i);
            Thread.Sleep(1000);
            Console.WriteLine("\tTarefa-filha {0} terminou", i);
        }
    }
}