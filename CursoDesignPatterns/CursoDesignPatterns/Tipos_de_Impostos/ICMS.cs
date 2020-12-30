using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {            
            return orcamento.Valor * 0.18;
        }
        
    }
}
