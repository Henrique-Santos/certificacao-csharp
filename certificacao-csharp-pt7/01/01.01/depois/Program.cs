using System;

namespace _01_01
{
    /// <image url="$(ProjectDir)/img1.png"/>
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou1; // Removendo um dos métodos que foi associado a Action
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();

        }

        static void CampainhaTocou1()
        {
            Console.WriteLine("A campainha tocou.(1)");
        }
        static void CampainhaTocou2()
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }

    class Campainha
    {

        /*
         Para assinarmos um evento, é necessário usar um delegate com uma assinatura que combine com o método que o emissor do evento espera invocar. 
         Com isto, vemos a importância dos delegates para a representação da assinatura de métodos!
         */
        public Action OnCampainhaTocou { get; set; }

        public void Tocar()
        {
            // Esse evento está sendo disparado para todos os manipuladores de uma vez só (No nosso caso existem 2 métodos manipulando esse evento)
            OnCampainhaTocou?.Invoke();
        }
    }
}


