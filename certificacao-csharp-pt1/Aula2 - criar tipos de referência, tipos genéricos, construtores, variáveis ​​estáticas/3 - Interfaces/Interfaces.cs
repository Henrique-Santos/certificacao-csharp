namespace certificacao_csharp_roteiro {
    class Interfaces:IAulaItem {
        public void Executar() 
        {
            IEletrodomestico eletro = new Televisao();
            eletro.Ligar();

            eletro = new Abajur();
        }
    }

    /*
    Por padrão toda Interface no .NET começa com a letra I. 

    A utilização e implementação dos métodos de uma interface são obrigatórios a todos os métodos que a usam.
    */
    interface IEletrodomestico 
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao 
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico // O simbolo de dois pontos ':', indica que a classe está impementando a interface IEletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
