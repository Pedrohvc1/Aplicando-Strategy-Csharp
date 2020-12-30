using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalcudoraImpostos
    {
        public void Calculo(Orcamento orcamento, Imposto imposto)
        {
            double result = imposto.Calcula(orcamento);
            Console.WriteLine(imposto + " = R$ " + result.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
