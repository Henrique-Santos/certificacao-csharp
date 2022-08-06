using System;
using System.Diagnostics;

namespace _01._3.Finalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }

            GC.Collect(); // Força o coletor de lixo a rodar, por padrão o GC só roda quando tem muitas instancias de objetos no heap

            Console.ReadKey();
        }
    }

    class Livro
    {
        static int UltimoId = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            UltimoId++;
            Id = UltimoId;
            //Trace.WriteLine("Livro " + Id + " está sendo criado");
        }

        // Referencia um finalizador com o simbolo -> ~
        //~Livro()
        //{
        //    //LIBERAR SOMENTE OS RECURSOS NÃO-GERENCIADOS


        //    Trace.WriteLine("Livro " + Id + " está sendo finalizado");
        //}
    }
}
