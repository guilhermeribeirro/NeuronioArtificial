using System;
using System.Collections.Generic;
using System.ComponentModel;
using ConsoleApp1;

namespace NeuralNetworkTraining
  {


    class Program
    {

        static void Main(string[] args)
        {
            NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);

             List<Entradas>listaEntradas = new List<Entradas>();

            Console.WriteLine("Quantos exemplos do treino voce deseja inserir? ");
            int numExemplos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numExemplos; i++)
            {
                Console.WriteLine($"Insira os dados do exemplo {i + 1}:");

                Console.Write("Entrada 1: ");
                double entrada1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Entrada 2: ");
                double entrada2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Resultado esperado na saida: ");
                int resultadoEsperado = int.Parse(Console.ReadLine());

                listaEntradas.Add(new Entradas(entrada1, entrada2, resultadoEsperado));
                

            }


            neuronioArtificial.Treinar(listaEntradas);

            Console.WriteLine($"Agora inseri outros valores que poderemos testar: ");
            Console.WriteLine("Entrada 1: ");
            double Novaentrada1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrada 2: ");
            double Novaentrada2 = double.Parse(Console.ReadLine());

            int repostaObtida = neuronioArtificial.Perguntar(Novaentrada1, Novaentrada2);

            Console.WriteLine("Resposta obtida");
            Console.WriteLine($"{repostaObtida}");




        }
    }
}