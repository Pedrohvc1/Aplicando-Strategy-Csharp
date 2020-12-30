using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    // 9%
    public class CSLL : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.09;
        }
    }
}
