using System;
using System.Collections.Generic;
using Meta.Numerics.Statistics.Distributions;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionExponencialNegativa : IDistribucion
    {
        public float Lambda { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }

        public DistribucionExponencialNegativa(float lambda)
        {
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");

            Lambda = lambda;
            Generador = new GeneradorDelSistema();
        }

        public DistribucionExponencialNegativa(float lambda, IGeneradorNumerosAleatorios generador)
        {
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");

            Lambda = lambda;
            Generador = generador;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public float Generar()
        {
            //x=-1/lambda*ln(1-r1)
            var aleatorio = Generador.Generar();

            var variable = (-1 / Lambda) * Math.Log(1 - aleatorio);

            return (float)variable;
        }

        public List<float> Generar(int cantidad)
        {
            var variables = new List<float>(cantidad);

            for (int i = 0; i < cantidad; i++)
            {
                variables.Add(Generar());
            }

            return variables;
        }

        public List<float> FrecuenciasEsperadas(List<Intervalo> intervalos)
        {
            var frecuencias = new List<float>(intervalos.Count);

            var d = new ExponentialDistribution(1/Lambda);

            foreach (var intervalo in intervalos)
            {
                var frecuencia = d.LeftProbability(intervalo.Fin) - d.LeftProbability(intervalo.Inicio);

                frecuencias.Add((float)frecuencia);
            }

            return frecuencias;
        }

        public int CantidadParametros()
        {
            return 1;
        }
    }
}
