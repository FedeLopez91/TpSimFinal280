using System;
using System.Collections.Generic;
using Meta.Numerics.Statistics.Distributions;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionNormal : IDistribucion
    {
        public float Media { get; protected set; }
        public float Varianza { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }

        public DistribucionNormal(float media, float varianza)
        {
            if (varianza < 0)
                throw new NotSupportedException("La varianza no puede ser negativa");

            Media = media;
            Varianza = varianza;
            Generador = new GeneradorDelSistema();
        }
        public DistribucionNormal(float media, float varianza, IGeneradorNumerosAleatorios generador)
        {
            if (varianza < 0)
                throw new NotSupportedException("La varianza no puede ser negativa");

            Media = media;
            Varianza = varianza;
            Generador = generador;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public float Generar()
        {
            var aleatorio1 = Generador.Generar();
            var aleatorio2 = Generador.Generar();

            var z = Math.Sqrt(-2 * Math.Log(aleatorio1)) * Math.Cos(2 * Math.PI * aleatorio2);

            var variable = Media + z * Varianza;

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

            var d = new NormalDistribution(Media, Varianza);

            foreach (var intervalo in intervalos)
            {
                var frecuencia = d.LeftProbability(intervalo.Fin) - d.LeftProbability(intervalo.Inicio);

                frecuencias.Add((float)frecuencia);
            }

            return frecuencias;
        }

        public int CantidadParametros()
        {
            return 2;
        }
    }
}
