using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    // Por usar conversao implicita e explicita, nao é necessario ficar chamando métodos para fazer a conversao
    class OperadoresDeConversao : IAulaItem
    {
        public void Executar()
        {
            ///<image url="$(ProjectDir)img14.png" />

            AnguloEmGraus anguloEmGraus = 45; // O compilador reconhece a conversao implicita
            Console.WriteLine(anguloEmGraus);

            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine(anguloEmRadianos);

            double graus = anguloEmGraus;

            anguloEmRadianos = (AnguloEmRadianos)anguloEmGraus; // Conversao explicita
            anguloEmGraus = anguloEmRadianos;
            Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }

    public struct AnguloEmRadianos
    {
        public double Radianos { get; }

        public AnguloEmRadianos(double radianos)
        {
            this.Radianos = radianos;
        }

        // Obriga a conversao explicita de um AnguloEmGraus para um AnguloEmRadianos
        public static explicit operator AnguloEmRadianos(AnguloEmGraus graus)
        {
            return new AnguloEmRadianos(graus.Graus * Math.PI / 180);
        }

        public static implicit operator AnguloEmRadianos(double radianos)
        {
            return new AnguloEmRadianos(radianos);
        }

        public static explicit operator double(AnguloEmRadianos radianos)
        {
            return radianos.Radianos;
        }

        public override string ToString()
        {
            return String.Format("{0} radianos", this.Radianos);
        }
    }

    public struct AnguloEmGraus
    {
        public double Graus { get; }

        public AnguloEmGraus(double graus) { this.Graus = graus; }

        /* Um OPERADOR de conversao nao possui nome, por ser implicito o cast nao é exigido*/
        public static implicit operator AnguloEmGraus(AnguloEmRadianos radianos)
        {
            return new AnguloEmGraus(radianos.Radianos * 180 / Math.PI);
        }

        public static implicit operator AnguloEmGraus(double graus)
        {
            return new AnguloEmGraus(graus);
        }

        public static implicit operator double(AnguloEmGraus graus)
        {
            return graus.Graus;
        }

        public override string ToString()
        {
            return String.Format("{0} graus", this.Graus);
        }
    }

}
