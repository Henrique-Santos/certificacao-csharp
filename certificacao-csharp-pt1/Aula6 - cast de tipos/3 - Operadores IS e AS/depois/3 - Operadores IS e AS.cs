using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            //Animal animal = obj as Animal; // Faz uma conversao com seguranca, sem lancar excecao quando nao for possivel converter
            if (obj is Animal animal) // Verificando o TIPO de um objeto, se for já faz a conversao
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal");
        }
    }
}
