using System;
using Meta.Numerics.Statistics.Distributions;

namespace NumerosAleatorios
{
    public static class ChiCuadrado
    {
        public static float Calcular(float observada, float esperada)
        {
            if (!(esperada > 0))
                throw new NotSupportedException("La frecuencia esperada debe ser mayor a cero");

            var valor = (float)Math.Pow(esperada - observada, 2) / esperada;

            return valor;
        }

        public static float ValorDeTabla(int grados, float alfa)
        {
            if (!(grados > 0))
                throw new NotSupportedException("Los grados de libertad deben ser mayores a cero");

            var d = new ChiSquaredDistribution(grados);

            var valor = d.InverseRightProbability(alfa);
            return (float)valor;
        }
    }
}
