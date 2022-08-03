using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            int numeroConvertido = int.Parse(textoDigitado); // O método Parse força a conversão
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            int.TryParse(textoDigitado, out numeroConvertido); // Não lança exeção se não conseguir converter

            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("texto não é um número");
            }

            textoDigitado = "R$ 123,45";
            decimal.TryParse(textoDigitado, 
                System.Globalization.NumberStyles.Currency, //moeda
                System.Globalization.CultureInfo.CurrentCulture, //pt-BR
                out decimal valorConvertido);
            Console.WriteLine(valorConvertido);
        }
    }
}
