using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NeuronioArtificial
    {
        public Pesos pesos { get; private set; }

        public double o { get; private set; }

        public double taxaAprendizado { get; private set; }
        
        public int erro { get; private set; }

        public NeuronioArtificial(double pTaxaAprendizado)
        {
            o = 0.0;
            taxaAprendizado = pTaxaAprendizado;
            pesos = new Pesos();
            this.taxaAprendizado = taxaAprendizado;

        }

        public void Treinar(List<Entradas> listaEntradas)
        {

            foreach (var item in listaEntradas)
            {
                o = item.Entrada1 * pesos.W1
                    + item.Entrada2 * pesos.W2;
                if (FuncaoClassificacao(o) != item.ResultadoEsperado)
                {
                    int resultadoClassificacao = FuncaoClassificacao(o);
                    int erro = item.ResultadoEsperado - resultadoClassificacao;
                }

            }
        }

        private int FuncaoClassificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }


        private bool CalcularErro()
        {
            return true;
        }
        private double RecalcularNovoPeso()
        {

            pesos.W1 += taxaAprendizado * erro * item.Entrada1;
            pesos.W2 += taxaAprendizado * erro * item.Entrada2;
        }

        public int Perguntar(double X1, double X2)
        {
            o = X1 * pesos.W1 + X2 * pesos.W2;
            return FuncaoClassificacao(o);
        }
    }
}
