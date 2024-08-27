using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace NeuralNetworkTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);

            // Criar uma lista de entradas
            List<Entradas> listaEntradas = new List<Entradas>();

            // Solicitar ao usuário que insira os dados
            Console.WriteLine("Quantos exemplos de treino você deseja inserir?");
            int numExemplos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numExemplos; i++)
            {
                Console.WriteLine($"Insira os dados do exemplo {i + 1}:");

                Console.Write("Entrada 1: ");
                double entrada1 = double.Parse(Console.ReadLine());

                Console.Write("Entrada 2: ");
                double entrada2 = double.Parse(Console.ReadLine());

                Console.Write("Resultado Esperado: ");
                int resultadoEsperado = int.Parse(Console.ReadLine());

                // Adicionar a nova entrada à lista
                listaEntradas.Add(new Entradas(entrada1, entrada2, resultadoEsperado));
            }

            // Treinar o neurônio artificial com a lista de entradas
            neuronioArtificial.Treinar(listaEntradas);

            // Testar o neurônio artificial com novas entradas
            Console.WriteLine("Agora vamos testar o neurônio. Insira os valores de entrada.");

            Console.Write("Entrada 1: ");
            double testEntrada1 = double.Parse(Console.ReadLine());

            Console.Write("Entrada 2: ");
            double testEntrada2 = double.Parse(Console.ReadLine());

            int resposta = neuronioArtificial.Perguntar(testEntrada1, testEntrada2);
            Console.WriteLine($"Resposta: {resposta}");

            Console.ReadKey();
        }
    }
}
