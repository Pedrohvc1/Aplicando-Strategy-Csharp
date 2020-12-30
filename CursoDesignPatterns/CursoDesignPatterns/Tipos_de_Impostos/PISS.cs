using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    //1.65%
    public class PISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.0165;
        }
    }
}
