using System;
using System.Collections.Generic;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionUniforme : IDistribucion
    {
        public float A { get; protected set; }
        public float B { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }

        public DistribucionUniforme(float a, float b)
        {
            if (b <= a)
                throw new NotSupportedException("A debe ser menor que B");

            A = a;
            B = b;
            Generador = new GeneradorDelSistema();
        }

        public DistribucionUniforme(float a, float b, IGeneradorNumerosAleatorios generador)
        {
            if (b <= a)
                throw new NotSupportedException("A debe ser menor que B");

            A = a;
            B = b;
            Generador = generador;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public float Generar()
        {
            var aleatorio = Generador.Generar();

            var variable = A + aleatorio * (B - A);

            return variable;
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
            var n = intervalos.Count;

            var frecuenciaEsperada = 1 / (float)n;

            var frecuencias = new List<float>(n);

            for (int i = 0; i < n; i++)
            {
                frecuencias.Add(frecuenciaEsperada);
            }

            return frecuencias;
        }

        public int CantidadParametros()
        {
            return 2;
        }
    }
}
