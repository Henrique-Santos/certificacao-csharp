using System;
using System.Collections.Generic;

namespace _01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Campainha campainha = new Campainha();
                campainha.OnCampainhaTocou += CampainhaTocou1;
                campainha.OnCampainhaTocou += CampainhaTocou2;
                Console.WriteLine("A campainha será tocada.");
                campainha.Tocar("101");

                campainha.OnCampainhaTocou -= CampainhaTocou1;
                Console.WriteLine("A campainha será tocada.");
                campainha.Tocar("202");
            }
            catch(AggregateException e)
            {
                foreach (var exc in e.InnerExceptions)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();

        }

        // O primeiro parametro se refere ao emissor de evento, e segundo, aos argumentos do evento
        static void CampainhaTocou1(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine("A campainha tocou no apartamento " + args.Apartamento + " .(1)");
            throw new Exception("Ocorreu um erro em CampainhaTocou1"); //Simulando uma situação de erro
        }
        static void CampainhaTocou2(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine("A campainha tocou no apartamento " + args.Apartamento + " .(2)");
            throw new Exception("Ocorreu um erro em CampainhaTocou2");
        }
    }

    class Campainha
    {
        /*
         Diferente de um event, uma Action fica exposta publicamente na classe Campainha, 
         e dessa forma pode ser executada diretamente por um código externo.
         */

        // Definindo um manipulador de eventos, e qual a classe de argumento de evento que ele utilizará
        public event EventHandler<CampainhaEventArgs> OnCampainhaTocou;

        public void Tocar(string apartamento)
        {
            List<Exception> erros = new List<Exception>();
            // Disparando o evento individualmente para os manipuladores
            foreach (var manipulador in OnCampainhaTocou.GetInvocationList())
            {
                try
                {
                    manipulador.DynamicInvoke(this, new CampainhaEventArgs(apartamento));
                }
                catch (Exception e)
                {
                    erros.Add(e.InnerException); // Criando uma lista de erros
                }
            }

            throw new AggregateException(erros);

        }
    }

    // EventArgs é uma classe de argumento vazio, pois não armazena nenhuma informação sobre evento. Por isso a necessidade de criar uma classe derivada
    class CampainhaEventArgs : EventArgs
    {
        public CampainhaEventArgs(string apartamento)
        {
            Apartamento = apartamento;
        }

        public string Apartamento { get; }
    }
}

/// <image url="$(ProjectDir)/img2.png"/>


