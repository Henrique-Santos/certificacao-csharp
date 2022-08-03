using System;

namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato() { Nome = "Pantera" };
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }
    }

    interface IAnimal
    {
        void Beber();
        void Comer();
        void Andar();
    }

    class Animal : IAnimal
    {
        public String Nome { get; set; }

        public void Beber() 
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer() // O modificador virtual, permite a substituição de método, a partir de uma classe derivada.
        {
            Console.WriteLine("Animal.Comer");
        }

        public void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    class Gato : Animal
    {
        public new void Beber() // O modificador new, indica que estamos ocultando o método da classe base, que tem o mesmo nome e função
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer() // O modificador override, indica que este método está sendo substituido.
        {
            Console.WriteLine("Gato.Comer");
        }

        public new void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}