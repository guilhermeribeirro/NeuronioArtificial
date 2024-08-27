using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pesos
    {
        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }

        public Pesos()
        {
            GerarAleatorio();
        }

        public double W1 { get; set; }
        public double W2 { get; set; }

        private void GerarAleatorio()
        {
            Random rand = new Random();
            W1 = rand.NextDouble() * 2 - 1; 
            W2 = rand.NextDouble() * 2 - 1; 
        }

    }
}
