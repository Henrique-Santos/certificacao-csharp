using System;
using System.Collections.Generic;

namespace certificacao_csharp_roteiro
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();

            // Utilizando as propriedades indexadas.
            sala["D01"] = new ClienteCinema("Maria de Souza");
            sala["D02"] = new ClienteCinema("José da Silva");

            sala.ImprimirReservas();
        }
    }

    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas
            = new Dictionary<string, ClienteCinema>();

        /*
        Normalmente, no C# e no .NET, costumamos agrupar os métodos GET e SET numa mesma entidade que 
        chamamos de propriedade. 
        */

        /*
        Como os métodos get e set não recebem parametros, por isso é necessário uma propriedade indexada.
        */
        public ClienteCinema this[string codigoAssento] // Uma propriedade indexada não possui nome.
        {
            get
            {
                return reservas[codigoAssento];
            }
            set
            {
                reservas[codigoAssento] = value; // O value, representa o valor recebido no método set, que é um dado do tipo ClienteCinema.
            }
        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}
