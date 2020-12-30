using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    // 7.6%
    public class COFINS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.076;
        }
    }
}
