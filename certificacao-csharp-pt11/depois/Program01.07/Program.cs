using System;
using System.Threading.Tasks;

namespace Program01._09
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarefa = Task.Run(() => Ola());
            // Tarefa de continuacao. Como parametros ele recebe a Task anterior e o segundo parametro
            // é um Enum que diz que só será executado se nao tiver falha na Task anterior.
            // Por padrao uma excecao lancada em uma Task nao impede a execucao da próxima
            tarefa.ContinueWith((tarefaAnterior) => Mundo(), TaskContinuationOptions.NotOnFaulted);

            // Exige que a tarefa anterior tenha ocorrido algum erro
            tarefa.ContinueWith((tarefaAnterior) => Erro(tarefaAnterior), TaskContinuationOptions.OnlyOnFaulted);
            

            Console.ReadLine();
        }

        private static void Mundo()
        {
            Console.WriteLine("Mundo");
        }

        private static void Ola()
        {
            Console.WriteLine("Olá");
            throw new ApplicationException("Opa! Ocorreu erro no método Olá");
        }

        private static void Erro(Task tarefaAnterior)
        {
            var excecoes = tarefaAnterior.Exception.InnerExceptions;

            foreach (var excecao in excecoes)
            {
                Console.WriteLine(excecao);
            }
        }
    }
}