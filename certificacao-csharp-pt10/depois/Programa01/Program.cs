using System;

namespace Programa01
{
    //Criar e aplicar atributos
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio("Relatório de Vendas");
            //Imprimir relatório detalhado OU resumido de acordo com a compilação
            relatorio.Imprimir();

            //Verifica se a classe Venda define o atributo [Serializable]
            if (Attribute.IsDefined(typeof(Venda), typeof(SerializableAttribute)))
            {
                Console.WriteLine("A classe Venda DEFINE o atributo Serializable");
            }
            else
            {
                Console.WriteLine("A classe Venda NÃO DEFINE o atributo Serializable");
            }                 

            Console.ReadLine();
        }
    }
}
