using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    // usando o padrão de projeto  - Strategy
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
