using System;
using System.Globalization;

namespace CursoDesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto cofins = new COFINS();
            Imposto piss = new PISS();
            Imposto csll = new CSLL();


            Console.Write("Qual o orçamento desejado: ");
            var orc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                             
            Orcamento orcamento = new Orcamento(orc);
            CalcudoraImpostos calculador = new CalcudoraImpostos();

            calculador.Calculo(orcamento, icms);
            calculador.Calculo(orcamento, iss);
            calculador.Calculo(orcamento, cofins);
            calculador.Calculo(orcamento, piss);
            calculador.Calculo(orcamento, csll);
        }
    }
}
