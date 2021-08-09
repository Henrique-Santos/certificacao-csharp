using System;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            Console.WriteLine(primeiroDia);

            /*
             Para ligar o bits, usamos um operador binário. Esse operador somará cada um dos bits de
            um número.
             O operador binário é representado pelo símbolo pipe "|"
             */
            DiasDeTrabalho diasDeTrabalho
                = DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;

            Console.WriteLine(diasDeTrabalho);
        }
    }

    /*
    Toda enumeração começa com o valor "0" por padrão.
    Ainda assim, podemos ainda atribuir valores diversos a essa enumeração. Se alguma valor não for
    explicitado ele pegará o valor da continuação do último valor atribuído.
    Temos a possibilidade de trocar o tipo padrão dessa enumeração que por padrão é int. Trocaremos,
    por exemplo, por um inteiro longo 'long', colocando dois pontos ':' depois do enum.
    */
    [Flags]
    enum DiasDaSemana : long { Seg = 3, Ter = 10, Qua = 15, Qui, Sex, Sab, Dom }

    /*
     A Flag Atribute, faz com que apareça o valor impresso de uma maneira mais agradavel. Ao invés de
    imprimir 0 é impresso Seg.
     */
    [Flags]
    enum DiasDeTrabalho { Seg = 0, Ter = 1, Qua = 2, Qui = 4, Sex = 8, Sab = 16, Dom = 32 }
}

